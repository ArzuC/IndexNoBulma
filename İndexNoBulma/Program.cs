using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Oluşturduğumuz malzemeler adlı dizi içerisinde kullanıcının girdiği Malzemeyi arayıp, Array.İndexOf metodu le index numarasını bulduk. 
 * İndex numaraları sıfırdan başladığı için index numarasını göstermek için 34. satırda index+1 dememiz gerekti.
*/
namespace İndexNoBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] malzemeler = { "Kablo", "Trafo", "Klemens", "Alpek", "Pano", "Hücre", "İletken", "Akü", "Redresör", "İzolatör" }; 
            Console.WriteLine("Lütfen Bir Malzeme Giriniz:");                                                            
            string girilenMalzeme = Console.ReadLine();                                                                  
            int index = Array.IndexOf(malzemeler, girilenMalzeme);                                                       
            bool varMi = false;                                                                                          
            foreach(string malzeme in malzemeler)
            {
                Console.Write(malzeme + "-");
                if (malzeme==girilenMalzeme)
                {
                    varMi = true;
                    break;
                }
            }
            Console.WriteLine();
            if (varMi)
            {
                Console.WriteLine("{0} listede vardır. Malzeme {1}. Sırdadir.",girilenMalzeme,index+1);
               
            }
            else
            {
                Console.WriteLine("{0} listede yoktur.",girilenMalzeme);
            }
            
           
            Console.ReadKey();

        }
    }
}
