namespace BuildPmoList
{
    public static class Program
    {

        static async System.Threading.Tasks.Task Main(string[] args)
        {

            // EDIT FOLLOWING VARIABLES IN THIS SECTION ---------------------------------------------------------------------------

            // Paste your access ID and secret from Cinode here
            var accessId = "<Åtkomstid>";
            var accessSecret = "<Åtkomsthemlighet>";


            // Select end date for wanted availability time
            //string today = string.Format("{0:yyyy-MM-dd}", DateTime.Now); // Start date: today
            string today = "2021-03-10";
            string untilDate = "2021-04-30"; // End date: --> Edit as you prefer

            // Select where you want to save the resulting text file and name it
            // for ex. = @"/Users/your_account/OneDrive - Forefront Consulting Group/CiondeApiData.txt"
            // where CiondeApiData is the selected file name
            var placeToSaveResult = @"<Your wanted palce to save it to and its name>";

            // --------------------------------------------------------------------------------------------------------------------

            BuildList list = new BuildList();
            await list.BuildPMOList(accessId, accessSecret, placeToSaveResult, today, untilDate);
        }
    }

}

