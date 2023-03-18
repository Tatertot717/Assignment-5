namespace Assignment_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i < 10; i++)
            {
                string fold_string = paperfold(i);
                Console.WriteLine("For " + i + " folds we get: " + fold_string + "\n");
            }
        }

        private static string paperfold(int i)
        {
            if (i == 1) return ("v");

            return (reverse(convert(paperfold(i - 1))) + "v" + paperfold(i - 1));
        }

        private static string reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string convert(string text)
        {
            text = text.Replace("^", "temp");
            text = text.Replace("v", "^");
            text = text.Replace("temp", "v");
            return text;
        }
    }
}