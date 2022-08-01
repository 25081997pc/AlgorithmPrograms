namespace AlgorithmProgram
{
    class Program
    {
        //Program for Implementation of Bubble Sort
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithm Programs");
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            //Sorting an Array
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            //Sorted Array
            Console.WriteLine("Sorted : ");
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }
        }
    }
}
