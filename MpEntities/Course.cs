using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MpEntities
{
    public class Course
    {
        public Course(int id, string title, string comment, string image, int instructorId)
        {
            Id = id;
            Title = title;
            Comment = comment;
            Image = image;
            InstructorId = instructorId;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public int InstructorId { get; set; }
    }
}
