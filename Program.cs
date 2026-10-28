namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.
        int selectedYear = 1;
        while (selectedYear > 0)
        {
            int currentYear = 2026;
            int divider1 = 400;
            int divider2 = 4;
            int divider3 = 100;
            Console.WriteLine("Veuillez choisir une année (passée ou future).");
            selectedYear =  Convert.ToInt32(Console.ReadLine());
            if (selectedYear % divider1 == 0 || (selectedYear % divider2 == 0 && selectedYear % divider3 != 0) )
            {
                if (selectedYear > currentYear)
                {
                    Console.WriteLine(+selectedYear + " sera une année bissextile.");
                }
                else
                {
                    Console.WriteLine(+selectedYear + " est une année bissextile.");
                }
            }
            else
            {
                if (selectedYear > currentYear)
                {
                    Console.WriteLine(+selectedYear + " ne sera pas une année bissextile.");
                }
                else
                {
                    Console.WriteLine(+selectedYear + " n'est pas une année bissextile.");
                }
            }
        }
    }   
}