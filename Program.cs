using System;

namespace EncryptTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Key");
            string strk = Console.ReadLine();
            while (strk.Length != 10)
            {
                Console.WriteLine("Error, Enter Key Again");
                strk = Console.ReadLine();
            }
            char[] ck = new char[10];
            ck = strk.ToCharArray();
            int[] ik = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ik[i] = ck[i] - 48;
                    sum += ik[i];
                }
                catch
                {
                    Console.WriteLine("Error,not allow char");
                }
            }
            int x = 1;
            while (x == 1)
                if (sum != 45)
                {
                    Console.WriteLine("Error,Duplicate");
                    Console.WriteLine("Enter Key");
                    strk = Console.ReadLine();
                    while (strk.Length > 10 || strk.Length < 10)
                        Console.WriteLine("Error, Enter Key Again");
                    ck = strk.ToCharArray();
                    sum = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            ik[i] = ck[i] - 48;
                            sum += ik[i];
                        }
                        catch
                        {
                            Console.WriteLine("Error,not allow char");
                        }
                    }
                }
                else
                {
                    x = 0;
                }

            Console.WriteLine("Enter Message");
            string strm = Console.ReadLine();
            char[] cm = new char[strm.Length];
            cm = strm.ToCharArray();
            int[] im = new int[10];
            int sum2 = 0;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    im[i] = cm[i] - 48;
                    sum2 += im[i];
                }
                catch
                {
                    Console.WriteLine("Error,not allow char");
                }
            }
            for (int i = 0; i < 10; i++)
                Console.Write(im[ik[i]]);
            if (strm.Length > 10)
                for (int i = 0; i < strm.Length - 10; i++)
                {
                    Console.Write(im[ik[i]]);

                }
        }
    }
}