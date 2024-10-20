namespace AdminiqueBeta.Client
{
    public class User
    {
        static public string After { get; set; } = "";
        static public string Before { get; set; } = "";
        static public string Location { get; set; } = "Before";
        static public string Currency { get; set; } = "$";
        static public string Name { get; set; } = "";

        static public void SetCurrency()
        {
            switch (Location)
            {
                case "After":
                    Before = "";
                    After = Currency;
                    break;
                case "Before":
                    After = "";
                    Before = Currency;
                    break;
            }
        }
    }
}
