﻿using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //wywołujemy obiekt 'tablica'
        Tablice tablice = new Tablice();

        tablice.Powitanie();

        int[] tab = tablice.Stworz_Tablice();

        Console.Clear();
        tablice.Wyswietl_Tablice(tab);
        tablice.SortujBabelkowo(tab);
        tablice.Wyswietl_Tablice(tab);
        tablice.Przeszukiwanie_Tablicy(5, tab);
    }
}