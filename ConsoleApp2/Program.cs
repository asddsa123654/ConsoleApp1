using System;

namespace StudentApp
{
    class Student
    {
        private string name;
        private int age;
        private int course;
        private double rating;

        public Student(string name, int age, int course, double rating)
        {
            this.name = name;
            this.age = age;
            this.course = course;
            this.rating = rating;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public void EditStudent(string name, int age, double rating)
        {
            this.name = name;
            this.age = age;
            this.rating = rating;
        }

        public void StudentRating()
        {
            Console.WriteLine($"Рейтинг студента: {rating}");
        }

        public string GetRole()
        {
            if (course >= 1 && course <= 4)
                return "бакалавр";
            else if (course >= 5)
                return "магiстр";
            else
                return "Невiрний курс";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Єгор Петренко", 20, 3, 4.5);

            Console.WriteLine($"Iм'я: {student.Name}");
            Console.WriteLine($"Вiк: {student.Age}");
            Console.WriteLine($"Курс: {student.Course}");
            student.StudentRating();
            Console.WriteLine($"Роль: {student.GetRole()}");

            student.EditStudent("Роман Бiляєв", 21, 4.8);
            Console.WriteLine("\nПiсля редагування:");
            Console.WriteLine($"Iм'я: {student.Name}");
            Console.WriteLine($"Вiк: {student.Age}");
            Console.WriteLine($"Курс: {student.Course}");
            student.StudentRating();
            Console.WriteLine($"Роль: {student.GetRole()}");
        }
    }
}
