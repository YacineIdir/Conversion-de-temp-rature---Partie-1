
using System.Numerics;

double Celcius;
double Kelvin, Farheinet;

const double CELCIUS_TO_KELVIN = 273.15;
const double CELCIUS_TO_FARHEINET_MULTI = 9/5;
const double CELCIUS_TO_FARHEINET_ADD = 32;

Console.WriteLine("Veuillez rentrer la temperature en Celcius: ");
Celcius = Convert.ToDouble(Console.ReadLine());

Kelvin = Celcius + CELCIUS_TO_KELVIN;
Farheinet = Celcius * CELCIUS_TO_FARHEINET_MULTI + CELCIUS_TO_FARHEINET_ADD;

Console.WriteLine($"Celcius: {Celcius}°C");
Console.WriteLine("Kelvin: " + Kelvin + "°K");
Console.WriteLine("Farheinet: " + Farheinet + "°F");
