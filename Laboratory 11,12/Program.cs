using System;
using Bank;
using Building;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Lifetime;

namespace Laboratory_11_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 11.1. Создать новый класс, который будет являться фабрикой объектов класса банковский счет. Изменить модификатор доступа у конструкторов класса банковский счет на internal. Добавить в фабричный класс перегруженные методы создания счета CreateAccount,которые бы вызывали конструктор класса банковский счет и возвращали номер созданного счета. Использовать хеш-таблицу для хранения всех объектов банковских счетов в фабричном классе. В фабричном классе предусмотреть метод закрытия счета, который удаляет счет из хеш-таблицы (методу в качестве параметра передается номер банковского счета). Использовать утилиту ILDASM для просмотра структуры классов.");
            BankAccountFactory accountFactory = new BankAccountFactory();
            int accountNumber1 = accountFactory.CreateAccount(7777, AccountType.Current);
            int accountNumber2 = accountFactory.CreateAccount(9999, AccountType.Savings);
            Console.WriteLine($"Номер первого счёта: {accountNumber1}");
            Console.WriteLine($"Номер второго счёта: {accountNumber2}");
            accountFactory.CloseAccount(accountNumber2);
            accountFactory.CloseAccount(123);
            int accountCounter = accountFactory.GetAccountCounter();
            Console.WriteLine($"Следующий номер счёта: {accountCounter}");
            Console.WriteLine("Упражнение 11.2. Разбить созданные классы, связанные с банковским счетом, и тестовый пример в разные исходные файлы. Разместить классы в одно пространство имен и создать сборку. Подключить сборку к проекту и откомпилировать тестовый пример со сборкой. Получить исполняемый файл, проверить с помощью утилиты ILDASM, что тестовый пример ссылается на сборку и не содержит в себе классов, связанный с банковским счетом.");
            Console.WriteLine("Домашнее задание 11.1. Для реализованного класса из домашнего задания 7.1 создать новый класс Creator, который будет являться фабрикой объектов класса здания. Для этого изменить модификатор доступа к конструкторам класса, в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса здания. В классе Creator все методы сделать статическими, конструктор класса сделать закрытым. Для хранения объектов класса здания в классе Creator использовать хеш-таблицу. Предусмотреть\r\nвозможность удаления объекта здания по его уникальному номеру из хеш-таблицы. Создать тестовый пример, работающий с созданными классами.");
            Building building1 = Creator.CreateBuilding();
            Building building2 = Creator.CreateBuilding();
            Console.WriteLine(building1);
            Console.WriteLine(building2);
            Creator.DeleteBuilding(building2.Id);
            Console.WriteLine("Домашнее задание 11.2. Разбить созданные классы (здания, фабричный класс) и тестовый пример в разные исходные файлы. Разместить классы в одном пространстве имен. Создать сборку (DLL), включающие эти классы. Подключить сборку к проекту и откомпилировать тестовый пример со сборкой. Получить исполняемый файл, проверить с помощью утилиты ILDASM, что тестовый пример ссылается на сборку и не содержит в себе классов здания и Creator.");
            Console.WriteLine("Упражнение 12.1 Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах. Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode(). Переопределить метод ToString() для печати информации о счете. Протестировать функционирование переопределенных методов и операторов на простом примере.");
            AccountBank account3 = new AccountBank(234343, AccountType.Current);
            AccountBank account4 = new AccountBank(400, AccountType.Savings);
            AccountBank account5 = new AccountBank(600, AccountType.Current);
            Console.WriteLine(account4 == account3);
            Console.WriteLine(account3 != account5);
            Console.WriteLine(account4.Equals(account5)); 
            Console.WriteLine(account3.Equals(account4));  
            Console.WriteLine(account3.ToString());
            Console.WriteLine("Упражнение 12.2. Создать класс рациональных чисел. В классе два поля – числитель и знаменатель. Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, – , ++, --. Переопределить метод ToString() для вывода дроби. Определить операторы преобразования типов между типом дробь, float, int. Определить операторы *, /,%.");
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(3, 4);
            Console.WriteLine($"r1: {r1}");
            Console.WriteLine($"r2: {r2}");
            Console.WriteLine($"r1 == r2: {r1 == r2}");
            Console.WriteLine($"r1 != r2: {r1 != r2}");
            Console.WriteLine($"r1 < r2: {r1 < r2}");
            Console.WriteLine($"r1 > r2: {r1 > r2}");
            Console.WriteLine($"r1 <= r2: {r1 <= r2}");
            Console.WriteLine($"r1 >= r2: {r1 >= r2}");
            Rational sum = r1 + r2;
            Console.WriteLine($"r1 + r2: {sum}");
            Rational difference = r1 - r2;
            Console.WriteLine($"r1 - r2: {difference}");
            Rational incremented = ++r1;
            Console.WriteLine($"++r1: {incremented}");
            Rational decremented = --r1;
            Console.WriteLine($"--r1: {decremented}");
            float f = (float)r1;
            Console.WriteLine($"(float)r1: {f}");
            int i = (int)r1;
            Console.WriteLine($"(int)r1: {i}");
            Rational product = r1 * r2;
            Console.WriteLine($"r1 * r2: {product}");
            Rational quotient = r1 / r2;
            Console.WriteLine($"r1 / r2: {quotient}");
            Rational remainder = r1 % r2;
            Console.WriteLine($"r1 % r2: {remainder}");
            Console.WriteLine("Домашнее задание 12.1. На перегрузку операторов. Описать класс комплексных чисел.Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух комплексных чисел. Переопределить метод ToString() для комплексного числа.Протестировать на простом примере.");
            ComplexNumber c1 = new ComplexNumber(7, 5);
            ComplexNumber c2 = new ComplexNumber(9, 2);
            ComplexNumber sum1 = c1 + c2;
            ComplexNumber difference1 = c1 - c2;
            ComplexNumber product1 = c1 * c2;
            Console.WriteLine($"Сумма: {sum1}");
            Console.WriteLine($"Вычитание: {difference1}");
            Console.WriteLine($"Умножение: {product1}");
            Console.WriteLine($"Равны ли комплексные числа? {c1 == c2}");
            Console.WriteLine($"Не равны комплексные числа? {c1 != c2}");
            Console.WriteLine("Домашнее задание 12.2. Написать делегат, с помощью которого реализуется сортировка книг. Книга представляет собой класс с полями Название, Автор, Издательство и конструктором. Создать класс, являющийся контейнером для множества книг (массив книг).В этом классе предусмотреть метод сортировки книг. Критерий сортировки определяется экземпляром делегата, который передается методу в качестве параметра. Каждый экземпляр делегата должен сравнивать книги по какому-то одному полю: названию, автору,издательству.");
            Book book1 = new Book("Гарри Потер", "Джоан Роулинг", "Bloomsbury");
            Book book2 = new Book("Атака титанов", "Хадзимэ Исаяма", "Коданся");
            Book book3 = new Book("Токийский гуль", "Суи Исида", "Shueisha");
            // Создаем контейнер для книг
            BookContainer container = new BookContainer(new Book[] { book1, book2, book3 });
            // Метод сравнения по названию книги
            Comparison<Book> compareByTitle = (b1, b2) => b1.Title.CompareTo(b2.Title);
            // Сортируем книги по названию
            container.SortBooks(compareByTitle);
            container.PrintBooks();
        }
        
    }
}
