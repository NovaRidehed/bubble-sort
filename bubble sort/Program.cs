namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BubbleSort
            int[] bubbleSortTestData = { 8, 3, 4, 7, 1, 4, 6, 3 };
            Console.WriteLine("Demonstration av BubbleSort:");
            Console.WriteLine("Före: " + string.Join(",", bubbleSortTestData));
            BubbleSort(bubbleSortTestData);
            Console.WriteLine("Efter: " + string.Join(",", bubbleSortTestData));
        }
        public static void BubbleSort(int[] numbers)
        {           
            while (true)
            {
                int timesswitch = 0;
                for(int i = 0;i < numbers.Length - 1; i++)
                {
                    if(numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        timesswitch++;
                    }
                }
                if(timesswitch == 0)
                {
                    return;
                }
                
            }
        }
    }
}