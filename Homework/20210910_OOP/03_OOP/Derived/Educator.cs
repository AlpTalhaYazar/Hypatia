using System;

namespace _03_OOP.Derived
{
    public class Educator : School
    {
        static int _nextEducatorID = 0;
        static int _nextLectureID = 0;
        static int _nextHomeworkID = 0;
        static int _tempChoosen = 0;
        public int EducatorID { get; set; }

        public void CreateLecture(Lecture[] lectures, string lectureName, int lectureTime)
        {
            lectures[_nextLectureID] = new Lecture(lectureName, lectureTime, EducatorID, _nextLectureID);
            _nextLectureID++;
        }
        public void SetHomework(Homework[] homeworks, string homeworkName, string homeworkDescription, int homeworkDeliveryTime)
        {
            homeworks[_nextHomeworkID] = new Homework(homeworkName, homeworkDescription, homeworkDeliveryTime, EducatorID, _nextHomeworkID);
            _nextHomeworkID++;
        }

        public void ShowApplicants(Lecture lecture, Student[] students)
        {
            for (int i = 0; i < lecture.Applicants.Length; i++)
            {
                Console.WriteLine(students[(Array.IndexOf(students, lecture.Applicants[i]))].Name);
            }
        }
        public void AcceptApplicants(Lecture lecture, Student[] students)
        {
            ShowApplicants(lecture, students);
            Console.WriteLine("Kimi Kabul etmek istersiniz");
            int.TryParse(Console.ReadLine(), out _tempChoosen);
            lecture.ChoosenOnes[lecture.ChoosenNo] = _tempChoosen;
            lecture.ChoosenNo++;
        }

        public Educator(string userName, string password, string name) : base(userName, password, name)
        {
            this.UserName = userName;
            this.Password = password;
            this.Name = name;
            this.EducatorID = _nextEducatorID;
            _nextEducatorID++;
        }
    }
}
