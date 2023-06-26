using System;

namespace MyApplication
{
  class Program
  {

    public static void Main(String[] args)
    {
     
     Fighter obj = new Fighter();

     obj.kick();
     obj.duck();
     obj.punch();
     obj.slip();
     obj.connects();
     obj.combo();
     obj.knockOut();

     int[] numberOfPunches = {1,2,3,4};
  int num = 0;
     try
     {
       num = numberOfPunches[9];
     }
     catch (System.Exception)
     {
      
       num = numberOfPunches[0];
     }

      finally
      {
        System.Console.WriteLine("The number of punches thrown in this match is " + num);
      }
    }
  }
}