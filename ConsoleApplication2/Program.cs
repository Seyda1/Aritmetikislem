using System;

    class Program
    {
        static void Main()
        {
            char islem;
            int s1, s2, sonuc = 0;
            Console.WriteLine("aritmetik işlemi(+,-,*) ve iki sayı giriniz");
           islem= Convert.ToChar(Console.ReadLine());
            s1=Convert.ToInt32(Console.ReadLine());
            s2=Convert.ToInt32(Console.ReadLine());
            switch(islem)
            {
                case '+':
                    sonuc=s1+s2;
                    break;
                case '-':
                    sonuc=s1-s2;
                    break;
                case'*':
                    sonuc = s1 * s2;
                    break;
                

            }
            Console.WriteLine("sonuc={0}",sonuc);
           
            Console.ReadLine();
        }
        
    }

