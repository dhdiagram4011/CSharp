/*
사용자로부터 시작숫자와 공차를 입력받아
일정한 값으로 숫자가 커지거나 작아지는 프로그램을 구현하세요.
단, 출력되는 숫자는 총 10개

공차 : 숫자들 사이에서 일정한 숫자의 차가 존재하는 것을 의미
e.g) 2,7,12,17,22 ->차가 똑같이 5

프로그램 구현 예)
시작숫자 : 4
공차: 3
결과출력 : 4,7,10,13,16,19,22,25,28,31
*/

using System;

class gongcha {
    static void Main(){

        int startNum = int.Parse(Console.ReadLine());
        int commonDiffNum = int.Parse(Console.ReadLine());

        Console.WriteLine("시작숫자를 입력하세요 :" + startNum);
        Console.WriteLine("공차를 입력하세요 :" + commonDiffNum);

        
        int result = startNum;

        for (int i=0; i<10; i++){
            
            Console.WriteLine(result);
            result += commonDiffNum; //4 ==> 4+3 = result4 = result4 + commonDiffNum3 

        }
    }
}


