namespace AdminiqueBeta.Client
{
    public class UX
    {
        static public string PageTitle { get; set; } = "Welcome";
        static public string UserDisplay { get; set; } = "";
        static public string DayPart { get; set; } = "DayPart";
        static public bool ToMenu { get; set; } = true;
        static public bool UserIni { get; set; } = false;

        static public void SetDisplayName()
        {
            if (User.Name is not null)
            {
                UserDisplay = ", " + User.Name + ".";
            }
        }

        static public void SetDayPart()
        {
            var x = DateTime.Now.ToString("HH");
            switch (x)
            {
                case "06" or "07" or "08" or "09" or "10" or "11":
                    DayPart = "morning";
                    break;
                case "12" or "13" or "14" or "15" or "16" or "17":
                    DayPart = "afternoon";
                    break;
                default:
                    DayPart = "evening";
                    break;
            }
        }

        static public void Clear()
        {
            // Asset Management
            // Monthly Budget
            Pages.documents.Payments.Paying.Clear();
            Pages.documents.Notability.Noteworthy.Clear();
            Pages.documents.AdministrationOfHours.AOH.Clear();
            User.Name = "";
            User.Currency = "";
            User.After = "";
            User.Before = "";
            UserDisplay = "";
            UserIni = false;
        }
    }
}
