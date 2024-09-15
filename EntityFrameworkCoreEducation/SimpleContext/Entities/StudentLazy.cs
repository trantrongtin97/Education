using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreEducation.SimpleContext.Entities
{
    public class StudentLazy
    {
        //A private field for the ILazyLoader instance
        private readonly ILazyLoader _lazyLoader;
        //An empty constructor 
        public StudentLazy()
        {
        }
        //one parameterized that takes an ILazyLoader as a parameter to
        //Initialize the ILazyLoader instance
        public StudentLazy(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? StandardId { get; set; }

        //public virtual StudentAddress? StudentAddress { get; set; }
        //Private Field For StudentAddress Navigation Property
        private StudentAddress _StudentAddress;
        //Public Setter and Getter Property for the Private _StudentAddress Field
        public StudentAddress StudentAddress
        {
            get => _lazyLoader.Load(this, ref _StudentAddress);
            set => _StudentAddress = value;
        }
        
    }
}
   
