using Matches;
using System.Text;
using TinyCsvParser;



Console.WriteLine("Please Enter 1 to manually Inputer Users to Match with our enter 2 to read from the csv");

string InputType = Console.ReadLine();

if (InputType == "1")
{
    Console.WriteLine("Please Enter the First Name");
    string Name1 = Console.ReadLine();
    Console.WriteLine("Please Enter the Second Name");
    string Name2 = Console.ReadLine();
    string[] inputArray = new string[] { $"{Name1}", "matches", $"{Name2}" };
    MatchLogic.DoWOrk(inputArray);
}
else if(InputType == "2")   
{
    Console.WriteLine("Reading Data from a csv fiule");

    CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
    CsvUserDetailsMapping csvMapper = new CsvUserDetailsMapping();
    CsvParser<UserDetails> csvParser = new CsvParser<UserDetails>(csvParserOptions, csvMapper);
    List<string> Males = new List<string>();
    List<string> Females = new List<string>();

    var result = csvParser
                 .ReadFromFile(@"TestData.csv", Encoding.ASCII)
                 .ToList();
    foreach (var details in result)
    {
        if (details.Result.Gender == "F")
        {
            Males.Add(details.Result.Name);

        }
        else
        {
            Females.Add(details.Result.Name);
        }
    }

    for (int i = 0; i < Males.Count; i++)
    {
        string[] inputArray = new string[] { $"{Males[i]}", "matches", $"{Females[i]}" };
        MatchLogic.DoWOrk(inputArray);
    }
}
else
{
    Console.WriteLine("Invalid Input");
}















