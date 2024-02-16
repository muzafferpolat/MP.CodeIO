using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDal.Concrete
{
    internal class InstructorManager : IBaseManager
    {
        public void Add()
        {
            Console.WriteLine("Eğitmen eklendi.");
        }

        public void GetAll()
        {
            Console.WriteLine("Eğitmenler listelendi.");
        }

        public void Remove()
        {
            Console.WriteLine("Eğitmen silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Eğitmen güncellendi.");
        }
    }
}
