using System;
using System.Security.Cryptography;
using System.Text;


namespace Л1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                
                Console.WriteLine("Вводи размер (до 300):");
                while (true)
                {

                    if (!int.TryParse(Console.ReadLine(),out n))
                    {
                        Console.WriteLine("Цифры...\n");
                        continue;
                    }
                    
                    n = Convert.ToInt32(n);
                    break;
                }
                if (n<1|n>300)
                {
                    Console.WriteLine("От 1 до 300...\n");
                }
            } while (n<1|n>600);
                string s;
                string all = null;
            Console.Clear();
                for (int i = 0; i < 23; i++)
                {
                Random rnd = new Random();
                char[] temp = new char[1];
                temp[0] = (char)rnd.Next(1, 255);
                var md5 = MD5.Create();
                    var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(temp));
                    s = (Convert.ToBase64String(hash));
                    all += s;
                }
                char[] ar = all.ToCharArray();
            Console.Clear();
            Console.WriteLine("Нормальный - 1, только буквы - 2, только цифры - 3");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.Write("Твой пароль:  \n");
            switch (v)
            {
                case 1:
                    {
                        for (int i = 0; i < --n; i++)
                        {
                            if (ar[i] == '=')
                            {
                                Console.Write('5');
                            }
                            else
                            {
                                Console.Write(ar[i]);
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (ar[i] == '=')
                            {
                                Console.Write('f');
                            }
                            int g= Convert.ToInt32(ar[i]);

                            if ((g >= 97 && g <= 113) || (g >= 65 && g <= 91))
                            {
                                Console.Write(ar[i]);
                            }
                            else
                            {
                                Random rnd = new Random();
                                int value = rnd.Next(65,91);
                                char g1 = Convert.ToChar(value);
                                Console.Write(g1);
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (ar[i] == '=')
                            {
                                Console.Write('5');
                            }
                            if (ar[i] == '1'| ar[i] == '2' | ar[i] == '3' | ar[i] == '4' | ar[i] == '5' | ar[i] == '6' | ar[i] == '7' | ar[i] == '8' | ar[i] == '9' | ar[i] == '0')
                            {
                                Console.Write(ar[i]);
                            }
                            else
                            {
                                Random rnd = new Random();
                                int value = rnd.Next();
                                Console.Write(value);
                            }
                        }
                    }
                    break;
            }
            
            
            Console.Write("\n\n");
        }
    }
}
