/*
문자 하나를 입력받고 영문 소문자인지 확인하는 프로그램 작성
*/
using System;

class daeso {
    static void Main() {
        //문자 입력받고 입력받은 문자 출력하기
        String input = Console.ReadLine();
        Console.Write(input); //값 출력 부분

        //string을 char로 변경
        char conv = char.Parse(input);

        // 대소문자 구분하고 메시지 출력하기
        if (char.IsUpper(conv)) {  
            Console.WriteLine("입력하신 문자는 대문자 입니다");
        } else if (char.IsLower(conv)) {
           Console.WriteLine("입력하신 문자는 소문자 입니다");
        }
    }
}
