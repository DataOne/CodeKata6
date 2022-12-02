namespace CodeKata6;

using System;

public class Galgenmännchen
{
  public static string DeadMan =
@"
  ____
  |  |
  |  O
  | /|\
  | / \
 _|______
/        \
";

  private char[] gesuchtesWort;
  private char[] loesungswort;

  public Galgenmännchen(string gesuchtesWort)
  {
    this.gesuchtesWort = gesuchtesWort.ToCharArray();
    this.loesungswort = ErstelleInitialesLoesungswort(gesuchtesWort);
  }

  public char[] ErstelleInitialesLoesungswort(string gesuchtesWort)
  {
    char[] initialCharacters = new char[gesuchtesWort.Length];
    for (int i = 0; i < gesuchtesWort.Length; i++)
    {
      initialCharacters[i] = '-';
    }
    return initialCharacters;
  }

  public string RateBuchstabe(char buchstabe)
  {
    var characterGuess = Char.ToLower(buchstabe);

    for (int i = 0; i < gesuchtesWort.Length; i++)
    {
      var wortChar = gesuchtesWort[i];
      if (Char.ToLower(wortChar) == characterGuess)
      {
        loesungswort[i] = wortChar;
      }
    }

    return string.Join(string.Empty, loesungswort);
  }
}
