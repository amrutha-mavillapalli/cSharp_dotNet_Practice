namespace MyPractise
{
    public class ClsListVsDictionary
    {
        public class Country
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public string Capital { get; set; }
        }

        public static void ListVsDictionaryExample()
        {
            Country country1 = new Country() { Code = "AUS", Name = "Australia", Capital = "canberra" };
            Country country2 = new Country() { Code = "IND", Name = "India", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "United States", Capital = "Washington D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "United Kingdon", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

            List<Country> countriesList = new List<Country>();
            countriesList.Add(country1);
            countriesList.Add(country2);
            countriesList.Add(country3);
            countriesList.Add(country4);
            countriesList.Add(country5);
            string strUserChoice = string.Empty;

            //using dictionary which gives better performance than lists
            Dictionary<string, Country> countryDict = new Dictionary<string, Country>();
            countryDict.Add(country1.Code, country1);
            countryDict.Add(country2.Code, country2);
            countryDict.Add(country3.Code, country3);
            countryDict.Add(country4.Code, country4);
            countryDict.Add(country5.Code, country5);

            do
            {
                Console.WriteLine("Please enter country code:");
                string strCountryCode = Console.ReadLine().ToUpper();

                // Country resultCountry = countriesList.Find(c => c.Code == strCountryCode);
                Country resultCountry = countryDict.ContainsKey(strCountryCode) ? countryDict[strCountryCode] : null;
                if (resultCountry == null)
                {
                    Console.WriteLine("country code not valid;");
                }
                else
                {
                    Console.WriteLine("Name={0},Capital={1}", resultCountry.Name, resultCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to contine- YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();

                } while (strUserChoice != "YES" && strUserChoice != "NO");


            } while (strUserChoice == "YES");

         



        }
    }
}