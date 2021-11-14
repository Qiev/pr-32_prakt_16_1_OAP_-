using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt_16_1_OAP_Давыдова
{
    class MyException : Exception { }
    class Dannie
    {
        private string str1;
        private string str2;
        private string str3;
        private string str4;
        private string str5;
        private string str6;

        public string nazv
        {
            get { return str1; }
            set
            {
                str1 = value;
            }
        }
        public string ind
        {
            get { return str2; }
            set
            {
                str2 = value;
                for (int i = 0; i < ind.Length; i++)
                {
                    if (!char.IsDigit(ind[i]))
                    {
                        throw new MyException();
                    }
                }
            }
        }
        public string city
        {
            get { return str3; }
            set
            {
                str3 = value;
                for (int i = 0; i < city.Length; i++)
                {
                    if (Char.IsDigit(city[i]))
                        throw new MyException();
                }
            }
        }
        public string street
        {
            get { return str4; }
            set
            {
                str4 = value;
            }
        }
        public string home
        {
            get { return str5; }
            set
            {
                str5 = value;
            }
        }
        public string phone
        {
            get { return str6; }
            set
            {
                str6 = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dannie dannie = new Dannie();
            Console.WriteLine("название организации:");
            dannie.nazv = Console.ReadLine();
            Console.WriteLine("почтовый индекс: ");
            dannie.ind = Console.ReadLine();
            Console.WriteLine("город организации: ");
            dannie.city = Console.ReadLine();
            Console.WriteLine("улица организации: ");
            dannie.street = Console.ReadLine();
            Console.WriteLine("дом организации:");
            dannie.home = Console.ReadLine();
            Console.WriteLine("номер телефона: ");
            dannie.phone = Console.ReadLine();
            Console.WriteLine("организация: \n");
            Console.WriteLine("название:    " + dannie.nazv);
            Console.WriteLine("почтовый индекс:     " + dannie.ind);
            Console.WriteLine("город:    " + dannie.city);
            Console.WriteLine("улица, дом:      " + dannie.street + ", " + dannie.home);
            Console.WriteLine("номер телефона:      " + dannie.phone);

            Console.ReadKey();
        }
    }
}
