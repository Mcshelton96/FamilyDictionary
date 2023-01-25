Console.WriteLine("Let's learn about Dictionaries!");

//JS objects are similar to C# Dictionaries
//const myFamily = {
//    'sister': {
//    'name': 'Krista', 
//		'age': 42

//    }, 
//	'mother': {
//    'name': 'Cathie', 
//		'age': 70

//    }
//}

//string string
Dictionary<string, Dictionary<string,string>> family = new Dictionary<string, Dictionary<string, string>>();

//better readability options below
//var family2 = new Dictionary<string, Dictionary<string, string>>();

//Dictionary<string, Dictionary<string, string>> family3 = new();

Dictionary<string, string> family4 = new Dictionary<string, string>();

family.Add("wife", new Dictionary<string, string> { { "name", "Christina" }, { "age", "26" } });
string text = family["mother"]["name"];
Console.WriteLine(text);

foreach (var familyMember in family)
{
    //var value = familyMember.Value;
    //var key = familyMember.Key;
    string sentence = $"{familyMember.Value["name"]} is my {familyMember.Key} and she is {familyMember.Value["age"]}";

    Console.WriteLine(familyMember.Key);
}

family4.Add("son", "Foster");
family4.Add("sister", "Jeanie");
family4.Add("brother", "Andrew");

Console.WriteLine(family["wife"]);


//string int
Dictionary<string, int> groceries = new Dictionary<string, int>();

groceries.Add("Cheetos", 3);
//how to add more cheetos.
//1. check if Cheetos already exists.
//2. if not, add it. if so, increment it

int extraCheetos = 2;
if (groceries.ContainsKey("Cheetos"))
{
    groceries["Cheetos"] += extraCheetos;
}
else
{
    groceries.Add("Cheetos", 2);
}

Console.WriteLine(groceries["Cheetos"]);


//int string
Dictionary<int, string> players = new Dictionary<int, string>();

players.Add(14, "Mitchell Shelton");

Console.WriteLine(players[14]);


