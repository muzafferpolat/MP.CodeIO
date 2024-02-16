using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpEntities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public Instructor(int id, string firsName, string lastName, string comment, string image)
        {
            Id = id;
            FirstName = firsName;
            LastName = lastName;
            Comment = comment;
            Image = image;
        }
    }
}
