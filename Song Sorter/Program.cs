namespace ArraysReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 of your favorite songs: ");

            string[] favoriteSongs = new string[5];
            string[] artists = new string[5];
            string[] ratings = new string[5];

            int i = 0;

            do
            {
                favoriteSongs[i] = Console.ReadLine();

                if (String.IsNullOrEmpty(favoriteSongs[i]))
                {
                    Console.WriteLine("Please enter a song name: ");
                    continue;
                }
                else
                {
                    i++;
                }
            }
            while (i < favoriteSongs.Length);

            Array.Sort(favoriteSongs);

            i = 0;

            do
            {
                Console.Write($"Who is the artist of {favoriteSongs[i]}: ");
                artists[i] = Console.ReadLine();

                if (String.IsNullOrEmpty(artists[i]))
                {
                    Console.Write("There was nothing entered.\n");
                    continue;
                }
                else
                {
                    i++;
                }
            }
            while (i < artists.Length);

            i = 0;

            do
            {
                Console.Write($"What would you rate the song {favoriteSongs[i]} from 1 to 5: ");
                ratings[i] = Console.ReadLine();

                if (Double.TryParse(ratings[i], out double num) && num <= 5 && num >= 0)
                {
                    i++;
                }
                else
                {
                    Console.Write("That is not a number between 1-10.\n");
                }
            }
            while (i < ratings.Length);

            Console.WriteLine("Your top ten songs are: ");

            for (i = 0; i < favoriteSongs.Length; i++)
            {
                Console.WriteLine($"{favoriteSongs[i]} by {artists[i]}. You gave this song a rating of {ratings[i]}.");
            }
        }
    }
}