/*
두 정수를 입력 받고
두 수중에 더 큰 수를 출력
같으면 두 수 모두 출력
*/

using System;

class jungsoo {
    static void Main() {
        //두 정수를 입력받고 두 수를 모두 출력하는 코드
        string input01;
        string input02;
        input01 = string.Format(Console.ReadLine());
        input02 = string.Format(Console.ReadLine());
        //Console.WriteLine(input01);
        //Console.WriteLine(input02);


        //더 큰수를 출력하는 코드
        if (int.Parse(input01) > int.Parse(input02)) 
        {
            Console.WriteLine("두수중에 더 큰수는 : " + input01 + "입니다");
        }
        else if (int.Parse(input01) < int.Parse(input02))
        {
            Console.WriteLine("두수중에 더 큰수는 : " + input02 + "입니다");
        }
        else if (int.Parse(input01) == int.Parse(input02)) 
            {
            Console.WriteLine("입력하신 숫자는" + input01 + "과" + input02 + "이므로 모두 같은 숫자를 입력하셨습니다");
            }
        }
    }



