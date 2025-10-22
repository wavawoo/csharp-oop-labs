using System;
using System.IO;

class FileDetails
{
    static void Main(string[] args)
    {
        try
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Specify a filename as argument");
                return;
            }
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            long length = stream.Length;
            char[] contents = new char[length];
            for (int i = 0; i < length; i++)
            {
                int charValue = reader.Read();
                if (charValue == -1) break;
                contents[i] = (char)charValue;
            }
            reader.Close();
            Summarize(contents);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void Summarize(char[] contents)
    {
        int totalChars = contents.Length;
        int vowels = 0;
        int consonants = 0;
        int lines = 1;

        string vowelChars = "АЕИОУЫЭЮЯаеиоуыэюяAEIOUaeiou";
        string consonantChars = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩбвгджзйклмнпрстфхцчшщBCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";

        foreach (char c in contents)
        {
            if (vowelChars.IndexOf(c) != -1)
            {
                vowels++;
            }
            else if (consonantChars.IndexOf(c) != -1)
            {
                consonants++;
            }
            else if (c == '\n')
            {
                lines++;
            }
        }

        Console.WriteLine("Общее количество символов в файле: " + totalChars);
        Console.WriteLine("Количество гласных букв: " + vowels);
        Console.WriteLine("Количество согласных букв: " + consonants);
        Console.WriteLine("Количество строк в файле: " + lines);
    }
}
