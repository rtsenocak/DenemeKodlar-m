using DenemeKodlarım;

internal class Program
{
    private static void Main(string[] args)
    {

        //string[] isimler = { "Enes", "Yasin", "Mehmet", "Ercan", "Kasım" };

        //double[] ondalikliSayilar = {1.44, 7.66, 8.34, 10.5 };
        char[] karakter = {'E','N','E', 'S' };

        for (int i = 0; i < karakter.Length; i++)
        {
            Console.WriteLine("Karakterler" +
                ": "+karakter[i]);
        }

 

    }
}