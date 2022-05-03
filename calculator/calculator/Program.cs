// See https://aka.ms/new-console-template for more information
using Calculator;
Console.WriteLine("Enter a First Number");
String str = Console.ReadLine();
int num1=Convert.ToInt32(str);
Console.WriteLine("Enter a second Number");
String str1 = Console.ReadLine();
int num2=Convert.ToInt32(str1);

Addition A = new Addition();
A.add(num1,num2);    
