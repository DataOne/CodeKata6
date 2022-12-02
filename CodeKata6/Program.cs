namespace Galgenmännchen;

class Program
{
    static string[] words = new string[] { "stronzo", "Raumfahrtgesellschaft", "Hosenträger", "Doppelsteckdose", "Birkenbaum", "Weihnachtstee", "Schaf", "Regen", "Zugspitze", "Kalbsblut", "Dönerspieß", "Subway Donnerstag", "Baumwipfelpfad", "X Æ A-XII", "Hüttenzauber", "ModernWorkplaye&ProcessesAndDevelopement" };


    static void Main(string[] args)
    {
        Random random = new Random();
        string quizword = words[random.Next(0, words.Length)];
        Galgenmännchen galge = new Galgenmännchen(quizword);

        Console.WriteLine("Welcome to the Galgenmännchen");

        string currentGuess = "";
        do
        {
            Console.WriteLine("Los, rate!");
            char input = Console.ReadKey().KeyChar;
            currentGuess = galge.RateBuchstabe(input);

            Console.WriteLine("\n" + currentGuess);
        } while (!currentGuess.Equals(quizword));

        Console.WriteLine("Very Nice!");
    }
}