using System;
using System.IO;
 
string dateipfad = ;  // Pfad zur CSV-Datei
try
{
    // Datei öffnen und Zeile für Zeile einlesen
    using (StreamReader sr = new StreamReader(dateipfad))
    {
        string zeile;
        while ((zeile = sr.ReadLine()) != null)
        {
            // Annahme: die Werte sind durch Komma getrennt
            string[] werte = zeile.Split(',');
 
            // Versuchen, jeden Wert in einen Integer zu konvertieren und auszugeben
            foreach (string wert in werte)
            {
                if (int.TryParse(wert, out int zahl))
                {
                    Console.WriteLine(zahl);
                }
                else
                {
                    Console.WriteLine($"Ungültiger Wert: {wert}");
                }
            }
        }
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("Die angegebene Datei wurde nicht gefunden.");
}
catch (Exception ex)
{
    Console.WriteLine($"Fehler: {ex.Message}");
}

hat Kontextmenü