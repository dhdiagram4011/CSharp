/*
while문을 사용하여 0 부터 10 미만의 정수 중에서 홀수만을 큰수부터 출력하시오.
*/

using System;

class oddNum {

    static void Main() {
        int num = 10;
        Console.WriteLine(num);                                    //while 문법 구글 검색
        while( num <= 10) //&& , || 연산추가 가능
        {
            num -= 2;
            Console.WriteLine(num);
        }        
    }    
}