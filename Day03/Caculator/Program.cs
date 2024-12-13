using System;
using System.Linq;
using System.Diagnostics;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("숫자1 입력 : ");
        var num1 = Console.ReadLine();
        Console.Write("숫자2 입력 : ");
        var num2 = Console.ReadLine();
        Console.Write("연산자 입력 : ");
        var opr = Console.ReadLine();

        var n1 = Convert.ToInt32(num1);
        var n2 = Convert.ToInt32(num2);

        switch (opr)
        {
            case "+":
                Console.WriteLine(n1 + n2);

                break;

            case "-":
                Console.WriteLine(n1 - n2);

                break;
            case "*":
                Console.WriteLine(n1 * n2);

                break;

            case "/":
                Console.WriteLine(n1 / n2);

                break;

            default:
                Console.WriteLine("유효하지 않은 입력입니다.");

                break;

        }

    }
}