namespace AlgorithmProgram
{
    class Program
    {
        //this is Driver method
        public static void Main(string[] args)
        {
            int[] ints = new int[] { 45, 75, 20, 92, 35, 1, 40, 0, 55 };
            MergeSort mergeSort = new MergeSort();

            Console.WriteLine("Before Merge Sort : ");
            mergeSort.printArray(ints);
            int[] sortedints = mergeSort.mergeSort(ints);
            Console.WriteLine("After Merge Sort : ");
            mergeSort.printArray(sortedints);
        }
    }
}
