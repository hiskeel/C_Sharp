namespace _07_Interfaces
{
    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }

    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        StudentCard Card { get; set; }


    }
    class Auditory
    {
        Student[] students  = null;
        public Auditory()
        {
            students = new Student[]//Array
            {
                new Student
                {
                    FirstName = "Bill",
                    LastName = "Tomson",
                    Birthdate = new DateTime(2005, 4, 7),
                    Card = new StudentCard() { Number = 123456, Series = "AA" }
                },
                new Student
                {
                    FirstName = "Olga",
                    LastName = "Ivanchuk",
                    Birthdate = new DateTime(2003, 10, 17),
                    Card = new StudentCard() { Number = 321456, Series = "BA" }
                },
                new Student
                {
                    FirstName = "Candice",
                    LastName = "Leman",
                    Birthdate = new DateTime(2006, 3, 12),
                    Card = new StudentCard() { Number = 7412585, Series = "AA" }
                },
                new Student
                {
                    FirstName = "Nicol",
                    LastName = "Taylor",
                    Birthdate = new DateTime(2004, 7, 14),
                    Card = new StudentCard() { Number = 963258, Series = "BK" }
                }
             };
        }
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
        }
    }
}