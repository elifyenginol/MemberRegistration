using FluentValidation;
using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.Entities.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind < IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
