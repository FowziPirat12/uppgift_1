using System;
class Program
{
   static void Main()
    {
      
      string ord = Console.ReadLine();
      int antal = int.Parse(Console.ReadLine());
      
      if (ord.Length < 9 || antal < 9)
      {
         Console.WriteLine("Får ej överstiva 9");
      }
      
      else
      {
         for (int i = 0; i < antal; i++)
         {
            Console.WriteLine(ord + " ");
         }
      }
    }
}

