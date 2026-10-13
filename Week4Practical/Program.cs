string[] carManufacturers = {"Ford", "Toyota", "BMW","Honda"};
Array.Sort(carManufacturers);
/* for (int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
{
    Console.WriteLine(carManufacturers[carIndex]);
}
List<string> months = new List<string>();
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");
months.Remove("September");
months.Remove("November");
Console.WriteLine(months.Count);
Console.WriteLine(months.IndexOf("December"));
string[] monthNamesArray = months.ToArray(); */

Dictionary<string,int> inventory = new Dictionary<string,int>();
inventory.Add("Health Potion",5);
inventory.Add("Mana Potion", 3);
inventory.Add("Gold Coin", 100);
inventory["Health Potion"] = 20;
//Console.WriteLine(inventory["Iron Sword"]);