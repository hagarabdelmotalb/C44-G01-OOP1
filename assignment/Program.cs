using System.Drawing;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            //WeekDays[] values = (WeekDays[])Enum.GetValues(typeof(WeekDays));
            //foreach (WeekDays day in values)
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Problem2
            //Person[] person = new Person[3];
            //person[0] = new Person("hagar",21);
            //person[1] = new Person("noor", 20);
            //person[2] = new Person("ali", 22);


            //foreach (Person p in person) {
            //    Console.WriteLine($"Name : {p.name} , age : {p.age } " );
            //}
            #endregion

            #region problem3
            //Console.Write("Enter a season: ");
            //string value = Console.ReadLine();

            //bool isDefined = Enum.TryParse(typeof(Color), value, true, out object result);

            //if (isDefined)
            //{
            //    Seasons season = (Seasons)result;

            //    switch (season)
            //    {
            //        case Seasons.Spring:
            //            Console.WriteLine("Spring march to may");
            //            break;
            //        case Seasons.Winter:
            //            Console.WriteLine(" winter December to February");
            //            break;
            //        case Seasons.Summer:
            //            Console.WriteLine("summer june to august");
            //            break;
            //        case Seasons.Autumn:
            //            Console.WriteLine("autumn September to November");
            //            break;
            //    }
            //}
            #endregion

            #region problem4
            //Console.Write("Enter a color: ");
            //string value = Console.ReadLine();

            //bool isDefined = Enum.TryParse(typeof(Color), value, true, out _);

            //if (isDefined)
            //{
            //    Console.WriteLine("Primary color");
            //}
            //else
            //{
            //    Console.WriteLine("Not a primary color");
            //}
            #endregion

            #region problem5
            //Console.Write("Please enter x1 : ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Please Enter y1 : ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter x2 : ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Please Enter y2 : ");
            //double y2 = double.Parse(Console.ReadLine());

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);

            //double dx = p1.X - p2.X;
            //double dy = p1.Y - p2.Y;

            //Console.WriteLine("the distance " + Math.Sqrt(dx * dx + dy * dy));
            #endregion

            #region problem6
            Person[] person = new Person[3];
            for (int i = 0; i < 3; i++) {
                Console.Write("enter the name and age : ");
                String input = Console.ReadLine();
                String[] parts = input.Split(' ');

                String name = parts[0];
                int age = int.Parse(parts[1]);

                person[i] = new Person(name, age);

            }
            Person oldest = new Person();

            for (int i = 0; i < 3; i++) {
                if (person[i].age > oldest.age)
                {
                    oldest = person[i];
                }
            }
            Console.WriteLine("the oldest person is" + oldest.name);

            #endregion


        }
    }
}
