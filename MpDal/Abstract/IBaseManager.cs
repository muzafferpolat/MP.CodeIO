using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDal
{
    public interface IBaseManager
    {
        
        void Add();
        void Remove();
        void Update();
        void GetAll();
    }
}
