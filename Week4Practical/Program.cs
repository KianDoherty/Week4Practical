using System.ComponentModel.DataAnnotations;

string[] carManufacturers = {"Ford", "Toyota", "BMW","Honda"};
Array.Sort(carManufacturers);
try
{
    for (int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
    {
        Console.WriteLine(carManufacturers[carIndex]);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: Attempted to access an array index that does not exist");
}
finally
{
    Console.WriteLine("Array processing complete");
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
//Console.WriteLine(months.Count);
//Console.WriteLine(months.IndexOf("December"));
string[] monthNamesArray = months.ToArray(); 

Dictionary<string,int> inventory = new Dictionary<string,int>();
inventory.Add("Health Potion",5);
inventory.Add("Mana Potion", 3);
inventory.Add("Gold Coin", 100);
inventory["Health Potion"] = 20;
try
{
    Console.WriteLine(inventory["Iron Sword"]);
}
catch (Exception)
{
    Console.WriteLine("Error: Item not found in inventory.");
}
Student student1 = new Student(1, "Alice Smith", 20);
List<Student> students = new List<Student>();
students.Add(student1);
Student student2 = student1;
student2.Age = 99;
student1.DisplayInfo();