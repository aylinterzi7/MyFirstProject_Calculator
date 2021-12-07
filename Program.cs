using System;

namespace hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1=0, sayı2= 0;
            Console.WriteLine("Lütfen bir işlem seçiniz");
            Console.WriteLine("1-Toplama\n2-çıkarma\n3-bölme\n4-çarpma");
            string işlem = Console.ReadLine();
            try
            {
                Console.WriteLine("lütfen 1. sayıyı giriniz");
                 sayı1 = int.Parse(Console.ReadLine());
                Console.WriteLine("lütfen 2. sayıyı giriniz");
                 sayı2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);       
            }
            

            if (işlem == "1")
            {

                Console.WriteLine(sayı1 + sayı2);

            }
            else if (işlem == "2")
            {

                Console.WriteLine(sayı1 - sayı2);

            }
            else if (işlem == "3")
            {
                try
                {
                    Console.WriteLine(sayı1 / sayı2);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);   
                   
                }
                

            }
            else
                    
            {

                Console.WriteLine(sayı1 * sayı2);
            
            }


        }
            
        }
    }

