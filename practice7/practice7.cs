/*
문자 하나를 입력받고 영문 소문자인지 확인하는 프로그램 작성
*/

using System;

class daeso {
    static void Main() {
        //문자 입력받고 입력받은 문자 출력하기
        string input = Console.ReadLine();
        Console.Write(input);

        // 대소문자 구분하고 메시지 출력하기
        if (char.IsUpper(input)) {    //input이 왜 null? 
            Console.WriteLine("입력하신 문자는 대문자 입니다");
        } else if (char.IsLower(input)) {
            Console.WriteLine("입력하신 문자는 소문자 입니다");
        }
    }
}