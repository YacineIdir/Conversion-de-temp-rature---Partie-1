
string Celcius;
double Kelvin, Farheinet;

Console.WriteLine("Veuillez rentrer la temperature en Celcius: ");

Celcius = Console.ReadLine();

Kelvin = (Convert.ToInt64(Celcius) + 273.15);
Farheinet = (Convert.ToInt64(Celcius) * 9/5 + 32);

Console.WriteLine("Celcius: " + Celcius + "°C");
Console.WriteLine("Kelvin: " + Kelvin + "°K");
Console.WriteLine("Farheinet: " + Farheinet + "°F");
