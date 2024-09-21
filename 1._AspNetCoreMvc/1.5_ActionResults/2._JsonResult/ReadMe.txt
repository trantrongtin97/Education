=========================================================================================================== Asp.Net Core Json Result
JsonJsonSerializerOptions

PropertyNamingPolicy: This property controls the naming policy applied to the properties of serialized objects. 
						It determines how property names are written in the JSON output.
	- If set to JsonNamingPolicy.CamelCase, the JSON output will have property names in camelCase (e.g., FirstName becomes firstName). The default is CamelCase.
	- If set to null, the property names will be serialized as defined in the C# class (no transformation).

WriteIndented: This property controls whether the JSON output should be formatted with indents for better readability.
	- When set to true, the JSON output will be formatted with indents and line breaks, making it more human-readable.
	- When set to false, the JSON output will be compact without any unnecessary whitespace, which is more efficient for data transfer. The default is false.

DefaultIgnoreConditionL: This property determines the conditions under which properties are ignored during serialization.
	- Setting DefaultIgnoreCondition to JsonIgnoreCondition.WhenWritingNull will ignore properties with null values. 
		If a property is null, it will not be included in the JSON output.
	- The default is JsonIgnoreCondition.Never, which means properties are always included.

IgnoreReadOnlyProperties: This property specifies whether read-only properties should be ignored during serialization.
	- When set to true, the JSON output will exclude properties with only a getter (or private setter) from the JSON output.
	- When set to false, the JSON output will include properties with only a getter (or private setter). The default is false.