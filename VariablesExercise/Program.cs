namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string friendName = "Ben";
            int newAge = 11;
            char firstLetter = 'B';
            bool confirmation = true;
            double cake = 19.99;
            decimal candles = 4.99m;

            Console.WriteLine($"I have a friend named {friendName}. At 8:00 PM, I asked him via text if it was his birthday today. He texted, \"That Is {confirmation}\". Apparently, he turned {newAge} today. According to his family, the cake cost ${cake} and the candles cost ${candles}. For the writing, they decided to put a big {firstLetter} on it.");
        }
    }
}
