/*
1~1000까지 10의 배수만 출력하는 프로그램을 작성해보세요~!
*/

using System;
using System.Diagnostics.Contracts;

class baesu {
    static void Main(){
        for (int i=10; i<1000; i++){ //시작값, 조건, 증감
            int start = 10;
            int end = 1000;
            int multi = 10;
            //10의 배수만 출력하여라
            //10,20,30,40,50,60,70,80,90....
            if ( i  % multi == 0) 
                Console.WriteLine(i);
            //이중에서 10의 배수만          
        }
    }
}  


