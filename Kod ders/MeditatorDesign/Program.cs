// See https://aka.ms/new-console-template for more information
using System;

namespace MeditatorDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Teacher Yusuf = new Teacher(mediator);
            Yusuf.name = " Yusuf ";
            mediator.Teacher = Yusuf;

            Student eda = new Student(mediator);
            eda.name = "Eda";

            Student pınar = new Student(mediator);
            pınar.name = "Pınar";

            mediator.Student = new List<Student> { eda, pınar };

            Yusuf.SendNewImage("Slide1.jpg");
            Yusuf.RecieveQuestions("is it True",eda);

            Console.ReadLine();

        }
    }
    abstract class CourseMember
    {
        protected Mediator Mediator;
        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
    class Teacher : CourseMember
    {
        public string name { get; set; }
        public Teacher(Mediator mediator) : base(mediator)
        {

        }

        public void RecieveQuestions(string questions, Student student)
        {
            Console.WriteLine("Teacher recieve a questions from {0},{1}",student.name,questions);
        }
        public void SendNewImage(string url)
        {
            Console.WriteLine("Teacher changed slide : {0}",url);
            Mediator.UpdateImage(url);
        }
        public void Answer(string answer,Student student)
        {
            Console.WriteLine("Teacher answered questions {0},{1}",student.name,answer);
        }
    }
    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {

        }

        public string name { get; set; }

        public void RecieveImage(string url)
        {
            Console.WriteLine("{1} recieved image {0}",url,name);   
        }

        public void RecieveAnswer(string answer)
        {
            Console.WriteLine("Student recieved Answer {0}", answer);
        }
    }
    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Student { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var students in Student)
            {
                students.RecieveImage(url);
            }
        }
        public void SendQuestion(string questions,Student student)
        {
            Teacher.RecieveQuestions(questions, student);
        }
        public void SendAnswer(string answer,Student student)
        {
            student.RecieveAnswer(answer);
        }
    }
}
