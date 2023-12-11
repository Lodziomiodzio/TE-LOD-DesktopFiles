/*   
 *      Dokumentacja pomocna do naszej dzisiejszej lekcji:
 *      https://learn.microsoft.com/pl-pl/dotnet/api/system.io?view=net-7.0
 */

using System;
using System.IO;    

namespace TE_LOD_DesktopFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string path = @Console.ReadLine();
                if (File.Exists(path))
                {
                    Console.WriteLine(File.ReadAllText(path));
                }
                else
                {
                    File.Create(path).Close();
                    StreamWriter sw = new StreamWriter(path);
                    Console.WriteLine("Co ma być napisanew pliku ?");
                    napisz();
                    void napisz()
                    {
                        string data = Console.ReadLine();

                        if (data.EndsWith("END;;")) sw.Close();
                        else
                        {
                            sw.WriteLine(data);
                            napisz();
                        }

                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

/* Pomoc do zajęć:
 *      - Klasa File, Directory, Path
 *      - Operacje na plikach (czy istnieje, odczyt, zapis, przenieś, usuń)
 *      - Operacje na katalogach (czy istnieje, stwórz, usuń, lista wszystkich plików oraz katalogów)
 *      - Operacje na strumieniach (StreamReader, StreamWriter)
 */