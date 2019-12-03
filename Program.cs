using System;
using Uchet;

namespace modul1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("System Uchet");
            var peopleOne = new UchPerson("Vasy Petrov", 51, "mehanik", 20);
            Console.WriteLine($"{ peopleOne.Name}, {peopleOne.Vozrast}, {peopleOne.Dolzhnost}, {peopleOne.Time}");
            var peopleTwo = new UchPerson("Ivan Sidorov", 34, "mehanik", 24);
            Console.WriteLine($"{ peopleTwo.Name}, {peopleTwo.Vozrast}, {peopleTwo.Dolzhnost}, {peopleTwo.Time}");
            var peopleThree = new UchPerson("Sasha Vaskin", 45, "mehanik", 19);
            Console.WriteLine($"{ peopleThree.Name}, {peopleThree.Vozrast}, {peopleThree.Dolzhnost}, {peopleThree.Time}"); 
            var peopleFour = new UchPerson("Petya Pupkin", 30, "mehanik", 21);
            Console.WriteLine($"{ peopleFour.Name}, {peopleFour.Vozrast}, {peopleFour.Dolzhnost}, {peopleFour.Time}"); ;

            UchPerson[] buchofPeople = { peopleOne, peopleTwo, peopleThree, peopleFour };

            //Console.WriteLine(UchPerson);
            //peopleOne.Use(1);
            //peopleTwo.Use(2);
            //peopleThree.Use(3);
            //peopleFour.Use(4);

            Console.ReadKey();
        }
   
       
    }
    }

