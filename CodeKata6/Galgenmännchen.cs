namespace Galgenmännchen
{
    public class Galgenmännchen
    {
        private readonly string gesuchtesWort;
        private string currentWort = "";


        public Galgenmännchen(string gesuchtesWort)
        {
            if (String.IsNullOrEmpty(gesuchtesWort))
            {
                throw new Exception("Der String darf nicht leer sein");
            }
            this.gesuchtesWort = gesuchtesWort;
            foreach (char c in gesuchtesWort)
            {
                currentWort += "-";
            }
        }

        public string RateBuchstabe(char buchstabe)
        {
            for(int i = 0; i < gesuchtesWort.Length; i++)
            {
               if(String.Equals(buchstabe.ToString(), gesuchtesWort[i].ToString(), StringComparison.OrdinalIgnoreCase))
               {
                  currentWort = currentWort.Remove(i, 1).Insert(i, gesuchtesWort[i].ToString());
               }
            }
            return currentWort;
        }

    }
}