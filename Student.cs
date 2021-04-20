namespace LinqPractice
{
    public class Student
    {
        public int StudentID
        {
            get;
            set;
        }
        public string StudentName
        {
            get;
            set;
        }
        public int Age { get; set; }
        public int StandardID;

        public override string ToString()
        {
            return "StudentID: " + StudentID + "\n" +
                   "StudentName: " + StudentName + "\n";
        }
    }
}