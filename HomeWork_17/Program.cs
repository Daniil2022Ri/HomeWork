

namespace HomeWork_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string patch = @"C:\Users\karal\Desktop\Директория";

            if(Directory.Exists(patch))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("File");

                string[] directoy = Directory.GetDirectories(patch);

                foreach (string directoyPath in directoy)
                {
                    Console.WriteLine(directoyPath);
                }
                
            }
        }
    }
}
