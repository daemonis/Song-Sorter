namespace ArraysReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = new string[5];
            string[] artists = new string[5];
            string[] ratings = new string[5];

            int numberOfSongs = songs.Length;
            int numberOfArtists = artists.Length;
            int numberOfRatings = ratings.Length;

            Console.WriteLine($"Please enter {numberOfSongs} of your favorite songs.");

            int i = 0;

            do
            {
                Console.Write($"{i + 1}) ");

                songs[i] = Console.ReadLine();

                if (String.IsNullOrEmpty(songs[i]))
                {
                    Console.WriteLine("Please enter a song name.");
                    continue;
                }
                else
                {
                    i++;
                }
            }
            while (i < numberOfSongs);

            Array.Sort(songs);

            i = 0;

            do
            {
                Console.Write($"Who is the artist of {songs[i]}: ");
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
            while (i < numberOfArtists);

            i = 0;

            do
            {
                Console.Write($"What would you rate the song {songs[i]} from 1 to 5: ");
                ratings[i] = Console.ReadLine();

                if (Double.TryParse(ratings[i], out double num) && num <= 5 && num >= 0)
                {
                    i++;
                }
                else
                {
                    Console.Write("That is not a number between 1-10.\n");
                    continue;
                }
            }
            while (i < numberOfRatings);

            Console.WriteLine($"Your top {numberOfSongs} songs are: ");

            for (i = 0; i < numberOfSongs; i++)
            {
                Console.WriteLine($"{i + 1}) {songs[i]} by {artists[i]}. From 1-5, you gave this song a rating of {ratings[i]}.");
            }
        }
    }
}