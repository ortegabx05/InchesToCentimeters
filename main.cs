using System;

class Program {
  public static void Main (string[] args) {
    const double CentimetersToInches = 2.54;
    double inches = -15;
    double cent = inches * CentimetersToInches;
    
    Console.WriteLine ("{0} inches is {1} centimeters", inches, cent);
  }
}