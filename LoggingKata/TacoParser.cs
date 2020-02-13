namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');


            if (cells.Length < 3)
            {
                //log that and return null
            }
            Point range = new Point() { Latitude = double.Parse(cells[0]), Longitude = double.Parse(cells[1]) };

            string name = cells[2];
            double.Parse("string");
            
           

            // Do not fail if one record parsing fails, return null
            return null; // TODO Implement
        }

    }

}