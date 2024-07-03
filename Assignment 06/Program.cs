using System.Numerics;

namespace Assignment_06
{
    #region Q1
    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    #endregion

    #region Q3
    enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    #endregion

    #region Q4
    enum Permissions
    {
        Read, Write, Delete, Execute
    }
    #endregion

    #region Q5
    enum Colors
    {
        Red, Greem, Blue
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //WeekDays day;
            //for (int i = 0; i < 7; i++)
            //{
            //    day = (WeekDays)i;
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2
            //Person[] persons = new Person[3];
            //persons[0] = new Person(23, "Mohamed");
            //persons[1] = new Person(22, "Nourhan");
            //persons[2] = new Person(22, "Nour");
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    persons[i].Display();
            //}
            #endregion

            #region Q3
            //Console.Write("Enter Season Name: ");
            //string? SeasonName = Console.ReadLine();
            //if (SeasonName == Season.Spring.ToString())
            //    Console.WriteLine("March to May");
            //else if (SeasonName == Season.Summer.ToString())
            //    Console.WriteLine("June to August");
            //else if (SeasonName == Season.Autumn.ToString())
            //    Console.WriteLine("September to November");
            //else if (SeasonName == Season.Winter.ToString())
            //    Console.WriteLine("December to February");
            //else
            //    Console.WriteLine("Invalid Season!");
            #endregion

            #region Q4

            // ???????

            #endregion

            #region Q5
            //string? ColorName = Console.ReadLine();
            //if (ColorName == Colors.Greem.ToString() ||
            //    ColorName == Colors.Blue.ToString() ||
            //    ColorName == Colors.Red.ToString())
            //{
            //    Console.WriteLine("Is Primary Color");
            //}
            //else
            //    Console.WriteLine("Not Primary Color");
            #endregion

            #region Q6
            Point P1, P2;
            //Console.WriteLine("Point1");
            //do
            //{
            //    Console.Write("X: ");
            //} while (!int.TryParse(Console.ReadLine(), out P1.X));
            //do
            //{
            //    Console.Write("Y: ");
            //} while (!int.TryParse(Console.ReadLine(), out P1.Y));
            //Console.WriteLine("Point2");
            //do
            //{
            //    Console.Write("X: ");
            //} while (!int.TryParse(Console.ReadLine(), out P2.X));
            //do
            //{
            //    Console.Write("Y: ");
            //} while (!int.TryParse(Console.ReadLine(), out P2.Y));

            //double distance = Math.Sqrt(Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2));
            //Console.WriteLine($"Destance: {Math.Round(distance, 2)}");
            #endregion

            #region Q7
            //Person[] persons = new Person[3];
            //int MaxAge = 0;
            //int OldestPerson = -1;
            //for(int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"{i+1} Person");
            //    Console.Write("Name: ");
            //    persons[i].Name = Console.ReadLine();
            //    do
            //    {
            //        Console.Write("Age: ");
            //    } while (!int.TryParse(Console.ReadLine(), out persons[i].Age));

            //    if (persons[i].Age > MaxAge)
            //    {
            //        MaxAge = persons[i].Age;
            //        OldestPerson = i;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Oldest Person: ");
            //persons[OldestPerson].Display();

            #endregion
        }
    }
}
