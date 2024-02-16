using SanalDatabese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDal
{
    public class ProjectManager
    {
        MqlDb mqlDb;
        public ProjectManager() 
        { 
            mqlDb = new MqlDb();
        }
        public void Add(IBaseManager baseManager) 
        {
            baseManager.Add();
        }
        public void Remove(IBaseManager baseManager)
        {
            baseManager.Remove();
        }
        public void Update(IBaseManager baseManager)
        {
            baseManager.Update();
        }
        public void GetAll(IBaseManager baseManager)
        {
            baseManager.GetAll();
        }
    }
}
