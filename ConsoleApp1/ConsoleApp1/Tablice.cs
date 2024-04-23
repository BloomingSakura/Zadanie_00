﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tablice
    {
        public int liczba = 20;
        public void Powitanie()
        {
            Console.WriteLine("Witaj w pliku tablice!");
        }

        public int[] Stworz_Tablice()
        {
            Console.Write("Ile elementów ma mieć tablica? ");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];

            for(int i = 0; i < ints.Length; i++)
            {
                Console.Write("Podaj kolejny element tablicy:");
                ints[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return ints;
        }

        public void Wyswietl_Tablice(int[] tab)
        {
            Console.WriteLine("Elementy tablicy: ");
            foreach (int i in tab)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
        public void SortujBabelkowo(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length - i; j++)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        int temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }
    }
}
