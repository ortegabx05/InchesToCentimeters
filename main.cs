using System;

class Program {
  public static void Main (string[] args) {
    const double InchesToCentimeters = 2.54;
    double inches1 = 5;
    double cent1 = inches1 * InchesToCentimeters;
    Console.WriteLine ("{0} inches is {1} centimeters", inches1, cent1);
    Console.WriteLine();

    double inches2 = -15;
    double cent2 = inches2 * InchesToCentimeters;
    Console.WriteLine ("{0} inches is {1} centimeters", inches2, cent2);
    Console.WriteLine();

    double inches3 = 15994;
    double cent3 = inches3 * InchesToCentimeters;
    
    Console.WriteLine ("{0} inches is {1} centimeters", inches3, cent3);
    Console.WriteLine();
  }
}