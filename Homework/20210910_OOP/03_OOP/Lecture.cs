using System;

namespace _03_OOP
{
    public class Lecture
    {
        public int LectureID;
        public string LectureName { get; set; }
        public int LectureTime { get; set; }
        public int CreatorID { get; private set; }

        public int ApplicantNo;
        public int[] Applicants { get; set; }

        public int ChoosenNo;
        public int[] ChoosenOnes { get; set; }

        public Lecture(string lectureName, int lecturetime, int creatorID, int lectureID)
        {
            this.LectureName = lectureName;
            this.LectureTime = lecturetime;
            this.CreatorID = creatorID;
            this.LectureID = lectureID;
            this.Applicants = new int[30];
            this.ChoosenOnes = new int[30];
            this.ApplicantNo = 0;
            this.ChoosenNo = 0;
        }
    }
}
