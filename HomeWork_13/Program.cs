namespace HomeWork_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Out value positive and negative numbers Array
            int[] numbers = new int[5] { -20, 1, 51, -85, -9 };

            //2) Creating Array Fibonachi
            int[] FibonachiNumber = GanerateFibonachiNumbers(10);


            //3) I need Sort the array in escending order
            int[] value = new int[5] { 6, 31, 1, 45, 54 };


            //Out Console 

            WorkingNegativeAndPositive(numbers , out int positive , out int negative );

           

            ReturnArrayOrder(value);

            Console.WriteLine($"Out value positive {positive} and negative {negative}");
            Console.WriteLine($"Fibo{FibonachiNumber}");
            Console.WriteLine($"Sort order array {value}");
           


        }

        static void Print<T>(T[] array)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }

           
        }
        static void ReturnArrayOrder(int[] Array)
        {
            for(int i = 0; i < Array.Length; i ++)
            {
                for(int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        int ElementCached = Array[i];
                        Array[i] = Array[j];
                        Array[j] = Array[i];
                    }
                }
            }
        }

        static int[] GanerateFibonachiNumbers(int lenght)
        {
            int[] Fibo = new int[lenght];
            Fibo[0] = Fibo[1] = 1;

            for(int i = 2; i < lenght; i++)
            {
                Fibo[i] = Fibo[i - 1] + Fibo[i - 2];

                
            }
            return Fibo;
        }
        static void WorkingNegativeAndPositive(int[] array , out int positive, out int negative)
        {
            positive = negative = 0;
            foreach(int item in array)
            {
                if (item > 0)
                {
                    positive++;
                }
                    
                if(item < 0)
                {
                    negative++;
                }
            }
        }
    }
}
