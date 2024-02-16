
using MpEntities;
using SanalDatabese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDal
{
    public class CourseManager : IBaseManager
    {
        MqlDb _MqlDb;
        public void Add()
        {
            Console.WriteLine("Kurs eklendi.");
        }

        public void GetAll()
        {
            Console.WriteLine("Kurslar listelendi.");
        }

        public void Remove()
        {
            Console.WriteLine("Kurs silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kurs güncellendi.");
        }
    }
}
