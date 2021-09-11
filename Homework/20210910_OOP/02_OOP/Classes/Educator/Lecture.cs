using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP.Classes
{
    class Lecture
    {
        [Key]
        public int LectureID { get; set; }
        public string LectureName { get; set; }
        public int LectureTime { get; set; }

        internal Lecture(string lectureName, int lectureTime)
        {
            this.LectureName = lectureName;
            this.LectureTime = lectureTime;
        }
    }
}
