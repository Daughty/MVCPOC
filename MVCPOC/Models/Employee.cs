//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace MVCPOC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {  
        [Required]
        public string Name { get; set; }

        //[Required]
        public string Email { get; set; }

        //[Required]
        public string Password { get; set; }

        //[Required]
        public string Department { get; set; }
        
        //  [Required]
        public int ID { get; set; }
    }
}