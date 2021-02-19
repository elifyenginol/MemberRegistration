using DevFramework.Core.DataAccess;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.DataAccess.Abstract
{
    public interface IMemberDal:IEntityRepository<Member>
    {
    } 
}
