/*사용자로부터 두개의 값을 입력받아 그 사이의 숫자를 모두 출력 */

using System;

class BetweenNum
{
    static void Main()
    {
        Console.WriteLine("두개의 정수를 입력하세요 :");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        //두 숫자에서 작은숫자와 큰 숫자를 결정함
        int minNum = Math.Min(num1, num2); //두개의 숫자중 더 작은숫자를 반환
        int maxNum = Math.Max(num1, num2); //두개의 숫자중 더 큰 숫자를 반환

        Console.WriteLine($"사이의 숫자 :");

        for (int i = minNum; i <= maxNum; i++)
        {
            Console.WriteLine(i);
        }
    }
}




