/*
while문을 사용하여 0 부터 10 미만의 정수 중에서 홀수만을 큰수부터 출력하시오.
*/

using System;

class oddNum {
    static void Main() {
        int num=10;     //while 문법 구글 검색
        while(num <= 10)
        {
            int intervalNum = 2;
            num--;
            if (num % intervalNum == 1)
            {
                Console.WriteLine(num);
            }
        }        
    }    
}