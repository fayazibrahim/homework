using System;

namespace tP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Serxan Azizli", "Rahib Aliyev", "Taleh Quliyev" };
            string option;
            do
            {
                   Console.WriteLine("\n1.Butun telebelere bax");
                   Console.WriteLine("2.Yeni telebe elave et");
                   Console.WriteLine("3.Telebeler uzre axtaris et");
                   Console.WriteLine("4.Telebelerin adlarina bax");
                   Console.WriteLine("5.Siyahide olub olmadigina bax");
                   Console.WriteLine("0.Menudan cix");

                   Console.WriteLine("\nisteyinizle bagli reqemi daxil edin:");
                   option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;

                    case "2":
                        Console.WriteLine("Yeni telebe elave edin:");
                        string std = Console.ReadLine();

                        std = std.Substring(0, 1).ToUpper() + std.Substring(1).ToLower();

                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = std;


                        break;

                    case "3":
                        Console.WriteLine("Telebeler uzre axtaris edin");

                        break;


                    case "4":
                        for (int i = 0; i < students.Length; i++)
                        {
                            int index = students[i].IndexOf(' ');
                            index = students[i].IndexOf(' ', index - 1);
                            string result = students[i].Substring(0, index);
                            Console.WriteLine(result);
                        }
                        break;


                    case "5":
                        Console.WriteLine("Telebenin adini daxil edin");
                        string insert = Console.ReadLine();
                        bool daxil = false;
                        for (int i = 0; i < students.Length; i++)
                        { }


                        break; ;


                    case "0":
                        Console.WriteLine("Menudan ayril");
                        break;


                }            
            
             }
                      while (option != "0");

        }

    }
            
}
