using CodeKata6;

Console.WriteLine("Bitte das zu suchende Wort eingeben: ");
ConsoleKeyInfo keyInfo;
var searchWord = "";

do
{
  keyInfo = Console.ReadKey(true);
  if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
  {
    searchWord += keyInfo.KeyChar;
  }
  else
  {
    if (keyInfo.Key == ConsoleKey.Backspace && searchWord.Length > 0)
    {
      searchWord = searchWord.Substring(0, (searchWord.Length - 1));
    }
  }
}
while (keyInfo.Key != ConsoleKey.Enter);

var maxTries = 9;
var tries = 0;

var hangman = new Galgenmännchen(searchWord);
var result = string.Join("", hangman.ErstelleInitialesLoesungswort(searchWord));

while (result != searchWord && tries <= maxTries)
{
  Console.WriteLine("Buchstabe raten: ");
  var guess = Console.ReadLine();
  if (!string.IsNullOrWhiteSpace(guess))
  {
    var newResult = hangman.RateBuchstabe(guess[0]);
    if (result == newResult)
    {
      tries++;
    }
    result = newResult;
    Console.WriteLine(result);
    Console.WriteLine("\n Fehlversuche: " + tries);
  }
}

if (tries <= maxTries)
{
  Console.WriteLine("Super! Du hast gewonnen! :)");
}
else
{
  Console.WriteLine("Schade! Das war leider nichts... :(");
  Console.WriteLine(searchWord);
  Console.WriteLine(Galgenmännchen.DeadMan);
}
