using MpDal;
using MpEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpBll
{
    public class CourseBusinessLogicLayer
    {
        ProjectManager projectManager;
        public CourseBusinessLogicLayer()
        {
            projectManager = new ProjectManager();
        }
        public int Add(Course course)
        {
            try
            {
                projectManager.Add(new CourseManager());
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
