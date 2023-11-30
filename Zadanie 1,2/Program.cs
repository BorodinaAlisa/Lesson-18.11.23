using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1.Необходимо создать программу, которая будет из текстового файла считывать всех студентов и их принадлежность к группе. Далее пользователь создает мероприятие с необходимым количеством участников, оно записывается в специально созданный файл. Далее дозаписать в файл с мероприятием всех участников мероприятия.");
            Console.WriteLine("Задача 2.У каждого есть хобби. Написать программу для слежения за интересующим вас событием(выход сериала, концерт и т.д.).Создать не менее трех человек с разными увлечениями. Пользователь вводит (можно из заранее определенного списка) событие. Если событие совпало с увлечением кого-либо,вывести его реакцию на событие.");
            List<Person> people = new List<Person>()
        {
            new Person("Даша", "концерт Егора Натса"),
            new Person("Евсей", "фан встречу с биг бейби тейпом"),
            new Person("Алиса", "грит мит с оджи будой")
        };
            Console.WriteLine("Введите событие:");
            string event1 = Console.ReadLine();
            foreach (Person person in people)
            {
                if (person.Hobby == event1)
                {
                    Console.WriteLine($"{person.Name} рад(а) наступающему событию!");
                }
                else
                {
                    Console.WriteLine($"{person.Name} не рад(а) этому событию!");
                }
            }
            Console.ReadKey();
        }
    }
}

