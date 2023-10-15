/* 사용자로부터 한개의 값을 입력받아 1부터 그사이의 모든 숫자를 거꾸로 출력해라 */
/* e.g) 숫자 4를 입력하면 4,3,2,1 출력*/

using System;

 class renumber
 {
    static void Main()
    {
        Console.Write("숫자를 입력하세요: ");

        if (int.TryParse(Console.ReadLine(), out int number)) 
        /*
        TryParse 메서드는 변환에 성공했는지 여부를 나타내는 부울 값을 반환하며 
        변환된 숫자를 out 매개 변수로 반환합니다. 
        문자열이 유효한 형식이 아닌 경우 Parse 는 예외를 
        throw하지만 TryParse 는 false 를 반환합니다.
        */
        {
            if (number < 1)
            {
                Console.WriteLine("1 이상의 숫자를 입력하세요");
            }
            else
            {
                /*
                for (int i=1; i <= number; i++)
                {
                    int reversedNumber = ReverseNumber(i);
                    Console.WriteLine(reversedNumber);
                }
                */

                for ( int i = number; i >= 1; i-- )
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("올바른 숫자를 입력하세요");
        }
    }
 }