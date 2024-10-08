namespace Registration.Client
{
    public class Generator
    {
        static public string? AccessToken { get; set; }
        static public string? TokenNumbers { get; set; }

        static public void GAT()
        {
            var rnd = new Random();
            for (int gen = 0; gen <= 21; gen++)
            {
                TokenNumbers += rnd.Next(10);
            }

        }
        static public void GenerateAccessToken()
        {
            GAT();
            AccessToken = User.Country + "X" + User.Gender + TokenNumbers;
        }


    }
}
