using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpDal
{
    internal class CategoryManager : IBaseManager
    {
        public void Add()
        {
            Console.WriteLine("Kategori eklendi");
        }

        public void GetAll()
        {
            Console.WriteLine("Kategoriler listelendi.");
        }

        public void Remove()
        {
            Console.WriteLine("Kategori silindi");
        }

        public void Update()
        {
            Console.WriteLine("Kategori güncellendi");
        }
    }
}
