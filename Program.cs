Console.WriteLine("Hello C#");

Console.WriteLine("Name: Elif Burcu Sarsu");
Console.WriteLine("Department: Computer Engineering");
Console.WriteLine("Year: 2");

Console.WriteLine();

Console.WriteLine("Current date and time:");
Console.WriteLine(DateTime.Now);

Console.WriteLine();

Console.WriteLine("Enter temperature in Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = celsius * 9 / 5 + 32;

Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
