/*
for문을 사용하여 0부터 10미만의 정수 중에서 짝수만을 작은 수부터 출력하시오.
*/

using System;

class Even {
    static void Main() {
        //0부터 10미만까지의 정수 출력
        int startNum = 0;
        int endNum = 10;
        int intervalNum = 2;
        for (int num=1; num<=10; num++)
            if (num % intervalNum == 0)
            {
                Console.WriteLine(num); //짝수만을 출력
            }
        //출력한 짝수 중에서 작은수를 출력
    }
}



