/*
1부터 20 미만의 정수 중에서 2 또는 3의 배수가 아닌 수의 총합을 구하시오.
*/


using System;
using System.Net.Mail;
using System.Xml.Serialization;
class mul {
    static void Main() {
        int intervalNumTwo = 2;
        int intervalNumThree = 3;
        //1부터 20미만의 정수 출력
        for (int i=1; i<20; i++) {
            if ( i % intervalNumTwo != 0 && i % intervalNumThree != 0)
            {
                //Console.WriteLine(i);
                int sum = 0;
                sum += i;
                Console.WriteLine(sum);
            }
        }
    }
}


