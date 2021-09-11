namespace _03_OOP
{
    public class Homework
    {
        public int HomeworkID { get; private set; }
        public string HomeworkName { get; set; }
        public string HomeworkDescription { get; set; }
        public int HomeworkDeliveryTime { get; set; }
        public int CreatorID { get; private set; }

        internal Homework(string homeworkName, string homeworkDescription, int homeworkDeliveryTime, int creatorID, int homeworkID)
        {
            this.HomeworkName = homeworkName;
            this.HomeworkDescription = homeworkDescription;
            this.HomeworkDeliveryTime = homeworkDeliveryTime;
            this.CreatorID = creatorID;
            this.HomeworkID = homeworkID;
        }
    }
}
