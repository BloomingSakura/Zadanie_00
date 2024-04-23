using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //wywołujemy obiekt 'tablica'
        Tablice tablice = new Tablice();

        tablice.Powitanie();

       int[] tab = tablice.Stworz_Tablice();
    }
}