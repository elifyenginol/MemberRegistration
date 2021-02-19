using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
    }
}
