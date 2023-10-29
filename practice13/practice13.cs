/*
두 개의 주사위를 던졌을 때, 눈의 합이 6이 되는 모든 경우의 수를 출력하시오.
*/

/*
주사위의 Max 숫자는 6 - 두개를 던졌을때 6이 되는 경우
1/5
2/4
3/3
4/2
5/1
*/

using System;
 
class dice {
    static void Main(int num1, int num2) {
        for (num1=1; num1<=6; num1++) {
            Console.WriteLine(num1);
        }
        for (num2=1; num2<=6; num2++) {
            Console.WriteLine(num2);
        }
        if (num1 + num2 == 6) {
            Console.WriteLine(num1 + "/" + num2);
        }
    }
}






