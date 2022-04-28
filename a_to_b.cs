using System;

class Program
{
  static void Main()
  { 
 
    Console.WriteLine("Cümleyi Giriniz: ");
    String str = Console.ReadLine();
  
    Console.WriteLine("OldSentence : " + str);
    Console.WriteLine("NewSentence: " + str.Replace('a', 'b'));
  }
}