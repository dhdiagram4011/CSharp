/*
학점 출력 프로그램 작성
0~100 사이의 점수를 입력 받고
91~100은 A
81~90은 B
71~80은 C
61~70은 D
0~60은 F 를 출력하세요!
그 밖에 점수는 비정상적인 점수라서 다시 입력하라고 하세요!
*/

using System;
class Grade {
    static void Main() {
        string score = Console.ReadLine();
        Console.WriteLine("당신이 입력한 점수는" + int.Parse(score) + "점 입니다");
        int resmsg= 0;
        
        int newscore = int.Parse(score); //string을 int로 변환
        
        if (newscore >= 91)
        {
            Console.WriteLine("당신의 학점은 A 입니다"); //91 ~ 100
        }
        else if (newscore >= 81)
        {
            Console.WriteLine("당신의 학점은 B 입니다"); //81 ~ 90
        }
        else if (newscore >= 71)
        {
            Console.WriteLine("당신의 학점은 C 입니다"); //71 ~ 80
        }
        else if (newscore >= 61)
        {
            Console.WriteLine("당신의 학점은 D 입니다"); //61 ~ 70
        }
        else if (newscore >= 0) // 0 ~ 60
        {
            Console.WriteLine("당신의 학점은 F 입니다");
        }
        else if (int.TryParse(score, out resmsg)) //string으로 선언된 상태에서만 TryParse 사용 가능
        {
            Console.WriteLine("비정상 적인 숫자를 입력하였습니다, 학점을 다시 입력해 주세요");
            //Main(); >> 사용X
        }
    }
}