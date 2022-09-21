
using System; 
 
namespace Task1 
{ 
     class Program 
    { 
        static void Main(string[] args) 
        { 
            int a, b; 
            Console.WriteLine(" Введите данные прямоугольника "); 
            Console.Write(" Введите сторону a: "); 
            a = int.Parse(Console.ReadLine()); 
            Console.Write(" Введите сторону b: "); 
            b = int.Parse(Console.ReadLine()); 
 
            if (a > 0 && b > 0) 
            { 
                Console.Write($" Площадь прямоугольника =  { a * b } " ); 
            } 
            else 
            { 
                Console.WriteLine(" Введите корректные значения "); 
            }
            Console.ReadKey();
        } 
    } 
}