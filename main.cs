using System;

class Program {
  public static void Main (string[] args) {
    const double CentimetersToInches = 2.54;
    double inches = 15994;
    double cent = inches * CentimetersToInches;
    
    Console.WriteLine ($"{inches} inches is {cent} centimeters");
  }
}