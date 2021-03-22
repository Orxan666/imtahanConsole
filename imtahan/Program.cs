using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imtahan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Aze-srift ucun//
            string userinput;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1.Tələbə adını daxil edin ");
                Console.WriteLine("2.Group yarat");
                Console.WriteLine("3.Tələbə id-sini seç və Groupa əlavə et");
                Console.WriteLine("4.imtahanlar yarat və imtahanların siyahısını göstər");
                Console.WriteLine("5.Exit");
                userinput = Console.ReadLine();
                if (Utilities.IsNumber(userinput))
                {
                    switch (userinput)
                    {
                        case "1":
                            Student.AddStudent();
                            break;
                        case "2":
                            Group.AddGroup();
                            break;
                        case "3":
                            Student.SelectGroupAddStudent();
                            break;
                        case "4":
                            break;
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("yuxaridaki reqemlerden birini daxil edin !!");
                            break;
                    }
                }
    
            } while (userinput != "4");
        }
    }
}
