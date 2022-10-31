using System;

namespace Bin2Dec
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a binary number: ");
      string? binary = Console.ReadLine();

      if (IsVerified(binary))
      {
        int dec = Convert.ToInt32(binary, 2);
        Console.WriteLine("The decimal value is: " + dec);
      }
      return;
    }

    static Boolean IsVerified(string? binary)
    {
      if (binary == null)
      {
        Console.WriteLine("Invalid input - null value ");
        return false;
      }

      if (!IsBinary(binary))
      {
        Console.WriteLine("Invalid input - not binary number");
        return false;
      }

      if (binary.Length > 8)
      {
        Console.WriteLine("Invalid input - too long (max 8 digits)");
        return false;
      }

      return true;
    }

    static Boolean IsBinary(string binary)
    {
      foreach (char c in binary)
      {
        if (c != '0' && c != '1')
        {
          return false;
        }
      }
      return true;
    }
  }
}