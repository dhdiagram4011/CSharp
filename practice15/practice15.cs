/*
배열에 5개의 수를 입력받아 저장하고 그 중에 홀수를 찾아 2를 곱한 값으로 변경하세요!
*/

using System;
using System.Collections;

class Ary {
    static void Main() {
        //배열에 5개의 수를 입력
        string num1 = Console.ReadLine();
        Console.WriteLine("당신이 입력한 첫번쨰 숫자는" + num1 + "입니다");
        string num2 = Console.ReadLine();
        Console.WriteLine("당신이 입력한 두번쨰 숫자는" + num2 + "입니다");
        string num3 = Console.ReadLine();
        Console.WriteLine("당신이 입력한 세번쨰 숫자는" + num3 + "입니다");
        string num4 = Console.ReadLine();
        Console.WriteLine("당신이 입력한 네번쨰 숫자는" + num4 + "입니다");
        string num5 = Console.ReadLine();
        Console.WriteLine("당신이 입력한 다섯번쨰 숫자는" + num5 + "입니다");
        

        //자료형[] 배열명 = new 자료형[크기];
        string[] numbers = new int[5] {num1,num2,num3,num4,num5};
    }
}
