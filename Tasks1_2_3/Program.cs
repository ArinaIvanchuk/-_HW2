// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число N");
// double N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// double num = 1;
// while (num <= N)
// {
//     double result = Math.Pow(num, 3);
//     Console.WriteLine(result);
//     num++;
         
// }
// if (N <= 0)
// {
//     Console.WriteLine("incorrect number");
// }
 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.Write("input coordinate X1 ");
// double X1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("input coordinate Y1 ");
// double Y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write ("input coordinate Z1 ");
// double Z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("input coordinate X2 ");
// double X2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("input coordinate Y2 ");
// double Y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write ("input coordinate Z2 ");
// double Z2 = Convert.ToDouble(Console.ReadLine());


// double AB = Math.Sqrt(Math.Pow(X1-X2, 2)+ Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2));

// Console.WriteLine($"AB = {AB:f2}");


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//  Console.Write("input number ");
//  int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//  if (num / 10000 == num % 10 && (num/1000)%10 == (num%100)/10)
//  {
//      Console.WriteLine(num + " palindrome");
//  }
//  else if (num < 10000 || num > 99999)
//  {
//     Console.WriteLine("incorrect number");
    
//  }
//  else
//  {
//      Console.WriteLine(num + " it is not palindrome");
//  }

