using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Listy
    {
        public List<int> StworzListe()
        {
            List<int> lista = new List<int>();
            string decyzja = "";
            while(decyzja == "t")
            {
                Console.WriteLine("Czy chcesz dodać element do listy?");
                decyzja = Console.ReadLine();
                if(decyzja == "t")
                {
                    Console.Write("Podaj element: ");
                    int element = int.Parse(Console.ReadLine());
                    lista.Add(element);
                }
                else
                {
                    Console.WriteLine("Podano wszystkie elementy"); 
                }
            }
            return lista;
        }
    }
}
