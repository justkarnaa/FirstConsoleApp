using System;
using System.IO;


namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int no = Convert.ToInt32(Console.ReadLine());
            FileStream fs = new FileStream(@"C:\Training\CSharp\FirstConsoleApp\hands_on_1.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < no; i++)
            {
                Console.WriteLine("Enter the registration number: ");
                int regno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the course");
                string course = Console.ReadLine();
                Console.WriteLine("Enter the course title");
                string coursetitle = Console.ReadLine();
                sw.WriteLine("Reg no: {0}", regno);
                sw.WriteLine("Course: " + course);
                sw.WriteLine("Course Title: " + coursetitle);
                sw.WriteLine();
                sw.WriteLine("***************************************************************************");
                sw.WriteLine();
            }
            sw.Close();
            fs.Close();
        }
    }
}
