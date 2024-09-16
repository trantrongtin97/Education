using System.Text.RegularExpressions;

namespace AspNetCore_WebApp_Mvc_CustomRouteConstraints.CustomRouteConstraint
{
    public class TTTRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext)); 

            if (route == null)
                throw new ArgumentNullException(nameof(route));

            if (routeKey == null)
                throw new ArgumentNullException(nameof(routeKey)); 

            if (values == null)
                throw new ArgumentNullException(nameof(values)); 

            if (values.TryGetValue(routeKey, out object? routeValue))
            {
                var parameterValueString = Convert.ToString(routeValue);
                // The regex pattern checks for at least one alphabet character and one numeric character
                if (Regex.IsMatch(parameterValueString ?? string.Empty, "^(?=.*[a-zA-Z])(?=.*[0-9])[A-Za-z0-9]+$"))
                {
                    return true; 
                }
                else
                {
                    return false; 
                }
            }
            return false; 
        }
    }
}
