using Microsoft.AspNet.Mvc.ModelBinding.Validation;
using RepoApp.Models;
using System;
using Microsoft.Framework.DependencyInjection;

namespace RepoApp
{
    public class MyModelValidatorProvider : IModelValidatorProvider
    {
        public IServiceProvider ServiceProvider { get; set; }

        public void GetValidators(ModelValidatorProviderContext context)
        {
            if (context.ModelMetadata.ModelType == typeof(MyModel))
            {
                context.Validators.Add(ServiceProvider.GetService<MyModelValidator>());
            }
        }
    }
}
