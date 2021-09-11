using System;

namespace _03_OOP.Derived
{
    public class Student : School
    {
        static int _nextStudentID = 0;
        public int StudentID { get; set; }

        public Student(string userName, string password, string name) : base(userName, password, name)
        {
            this.UserName = userName;
            this.Password = password;
            this.Name = name;
            this.StudentID = _nextStudentID;
            this.AuthLevel = 2;
            _nextStudentID++;
        }

        public void ShowLectures(Lecture lecture)
        {
            for (int i = 0; i < lecture.LectureName.Length; i++)
            {
                Console.WriteLine(lecture.LectureName);
            }
        }
        public void ApplyLecture(Student student, Lecture lecture)
        {
            int Quota = lecture.ApplicantNo;
            if (Quota <= 30)
            {
                lecture.Applicants[Quota] = student.StudentID;
                lecture.ApplicantNo++;
            }
            else
                Console.WriteLine("Dersin Kotasi Dolmustur!");
            return;
        }

        public void IncludedLectures(Lecture lecture, Student[] students)
        {
            for (int i = 0; i < lecture.ChoosenOnes.Length; i++)
            {
                Console.WriteLine(students[(Array.IndexOf(students, lecture.Applicants[i]))].Name);
            }
        }
    }
}
