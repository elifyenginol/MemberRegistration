using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                FirstName = "Zeliha Elif",
                LastName = "Yenginol",
                DateOfBirth = new DateTime(1999,1,24),
                Email = "elifyenginol5@gmail.com"


            });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
