using System;
using codewars.Find_Maximum_and_Minimum_Values_of_a_List;

namespace codewars
{
  public class Program
  {
    public static void Main(string[] args)
    {
      MAX_MIN s1 = new MAX_MIN();
      var x = s1.Min(new[] { -52, 56, 30, 29, -54, 0, -110 });
      Console.WriteLine(x);
      
    }
  }
}