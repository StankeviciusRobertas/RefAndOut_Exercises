namespace RefAndOut_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 5;
            //Swap(ref number);
            //Console.WriteLine(number);

            string word = Console.ReadLine();
            TrimAndCapitalize(ref word);
            Console.WriteLine(word);
        }

        public static void Swap(ref int number)
        {
            number = 99;            
        }

        public static void IncrementByN(ref int number)
        {
            number = number * number;            
        }

        public static void TrimAndCapitalize(ref string word)
        {
            word = word.Trim();
            word = char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}