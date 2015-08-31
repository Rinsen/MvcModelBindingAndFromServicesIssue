using Microsoft.AspNet.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoApp
{
    public class MyModelValidator : IModelValidator
    {
        int value;

        public MyModelValidator()
        {
            value = 0;
        }

        public bool IsRequired
        {
            get
            {
                return false;
            }
        }

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            return Enumerable.Empty<ModelValidationResult>();
        }
    }
}
