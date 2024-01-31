namespace _13_Event
{
    internal class Program
    {
        //static void HardWork()
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"Operation {i+1} working" );
        //        Thread.Sleep(random.Next(500));
        //        Console.WriteLine($"Operation {i + 1} Finished");
        //    }
        //}

        public delegate void ExamDelegate(string t);
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birth { get; set; }
            public void PassExam(string task)
            {
                Console.WriteLine($"Student {FirstName} passed the exam {task}");
            }

        }
        class Teacher
        {
            public ExamDelegate ExamEvent;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}