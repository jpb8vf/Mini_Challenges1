using System;

using System.IO;

namespace DocumentApplication
{

    class Document
    {

        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Document");

                Console.WriteLine("document title:");

                string name = Console.ReadLine();

                Console.WriteLine("document content:");

                string content = Console.ReadLine();

                string filename = name + ".txt";

                string path = Environment.CurrentDirectory + "/" + filename;

                if (!File.Exists(path))

                {

                    File.WriteAllText(path, content);

                }

                Console.WriteLine(filename + " saved successfully. The document has " + content.Length + " characters");

            }

            catch (Exception e)

            {

                Console.WriteLine(e);

            }

        }

    }

}

