/*
for문을 사용하여 0부터 10미만의 정수 중에서 짝수만을 작은 수부터 출력하시오.
*/

using System;

class Even {
    static void Main() {
        //0부터 10미만까지의 정수 출력
        for (int num=2; num<10; num += 2)
                Console.WriteLine(num);
    }
}