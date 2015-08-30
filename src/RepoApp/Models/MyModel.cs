using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RepoApp.Models
{
    public class MyModel : IValidatableObject
    {
        // This is how I would like to do it!
        // But I get a "No parameterless constructor defined for this object." error if I do. :(
        //MyService _myService;

        //public MyModel(MyService service)
        //{
        //    _myService = service;
        //}


        public int MyProperty { get; set; }

        [FromServices]
        public MyService MyService { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            MyService.ValidateMyDataInSomeWay(MyProperty);

            return Enumerable.Empty<ValidationResult>();
        }
    }
}
