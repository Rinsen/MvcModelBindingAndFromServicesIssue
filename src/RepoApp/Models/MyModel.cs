using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RepoApp.Models
{
    public class MyModel : IValidatableObject
    {

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
