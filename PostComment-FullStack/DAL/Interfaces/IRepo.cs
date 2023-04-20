using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<TYPE, ID, RET>
    {
        RET Create(TYPE obj);
        List<TYPE> Read();
        TYPE Read(ID id);
        RET Update(TYPE obj);
        bool Delete(ID id);
    }
}
