using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "geology", "physical education", "music", "art", "social studies", "botany" };
            Student[] studentsEMail = { new Student("Diego.Maradona@epam.com"), new Student("Pele.Nascimento@epam.com"), new Student("Lionel.Messi@epam.com") };
            Student[] studentsFullName = { new Student("Diego","Maradona"), new Student("Pele","Nascimento"), new Student("Lionel","Messi") };

            Dictionary<Student, HashSet<string>> studentSubjectDict = new Dictionary<Student, HashSet<string>>();


            for (int i = 0; i < 3; i++)
            {
                var emailSub = new HashSet<string>();
                var nameSub = new HashSet<string>();
                for (int j = 0; j < 3; j++)
                {
                    var rnd = new Random();
                    emailSub.Add(subjects[rnd.Next(0, 5)]);
                    nameSub.Add(subjects[rnd.Next(0, 5)]);
                }
                studentSubjectDict[studentsEMail[i]] = emailSub;
                studentSubjectDict[studentsFullName[i]] = nameSub;


            }

            foreach (var studentSubject in studentSubjectDict)
            {
                Console.WriteLine($"Студент {studentSubject.Key} посещает уроки:");
                foreach (var sub in studentSubject.Value)
                {
                    Console.WriteLine(sub);
                }
            }
            Console.ReadLine();
        }
    }
}
