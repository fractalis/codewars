using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    int fsr = (int)Math.Floor(Math.Sqrt((int)n));
    
    return (fsr*fsr == n);
  }
}