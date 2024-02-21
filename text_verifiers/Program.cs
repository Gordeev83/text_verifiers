namespace text_verifiers
{
    class Program
    {
        static void Main()
        {
            string text = "to be, or not to be, that is the question,\nor to take arms against a sea of troubles,\nand by opposing end them? to die: to sleep;\nno more; and by a sleep to say we end\ndevoutly to be wish'd. to die, to sleep";

            List<string> forbiddenWords = new List<string> { "die" };

            int replacementsCount = 0;

            foreach (string word in text.Split(' ', '\n'))
            {
                if (forbiddenWords.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                    replacementsCount++;
                }
            }

            Console.WriteLine(text);
            Console.WriteLine($"Статистика: {replacementsCount} замены слова die.");
        }
    }
}
