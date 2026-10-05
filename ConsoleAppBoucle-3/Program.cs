namespace ConsoleAppBoucle_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capital = 1200;
            double taux = 1.3;

            Console.Write("Quelle somme voulez-vous atteindre (en euros) ? ");
            double objectif = double.Parse(Console.ReadLine());

            int annees = 0;

            while (capital < objectif)
            {
                capital = capital + capital * taux / 100;
                annees = annees + 1;
            }

            Console.WriteLine("Il faut " + annees + " annee(s) pour atteindre " + objectif + " euros.");
            Console.WriteLine("Capital final : " + Math.Round(capital, 2) + " euros.");
        }
    }
}
