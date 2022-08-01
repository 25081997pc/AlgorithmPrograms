namespace AlgorithmProgram
{
    class Program
    {
        //Program to check whether two strings are anagrams for each other
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithm Programs");
            string str1 = "abcd";
            string str2 = "dcba";
            //convert the strings into character array with lowercase
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            //Sort the arrays
            Array.Sort(ch1);
            Array.Sort(ch2);
            //Convert the character arrays to strings
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine(val1);
                Console.WriteLine(val2);
                Console.WriteLine("Both the strings are Anagram");
            }
            else
            {
                Console.WriteLine(val1);
                Console.WriteLine(val2);
                Console.WriteLine("Both the strings are Not Anagram");
            }
        }
    }
}
