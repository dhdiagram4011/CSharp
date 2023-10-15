/*
컴퓨터랑 가위바위보해서 결과 출력
내가 이기면 승리
지면 패배
비기면 무승부
*/

using System;
using System.Data;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

enum Choice { //열거형
    Rock,
    Paper,
    Scissors
}

class Games
{
    static void Main()
    {
        // 사용자 입력 부분
        /*
        Console.WriteLine("1.가위");
        Console.WriteLine("2.바위");
        Console.WriteLine("3.보");
        Console.Write("1,2,3 중 선택 : ");
        */
        Console.WriteLine("1 : (바위) " + Choice.Rock);
        Console.WriteLine("2 : (보) " + Choice.Paper);
        Console.WriteLine("3 : (가위) " + Choice.Scissors);
        Console.Write("1,2,3 중 선택 : ");

        int userChoice = int.Parse(Console.ReadLine()) -1;
        Choice userEnumChoice = (Choice)userChoice;

        //컴퓨터 입력부분
        Random random = new Random();
        int computerChoice = random.Next(0,3);
        Choice computerEnumChoice = (Choice)computerChoice;


        //사용자와 컴퓨터 비교하여 승자 결정

        Console.WriteLine("사용자 선택 : " + userEnumChoice);
        Console.WriteLine("컴퓨터 선택 : " + computerEnumChoice);


        if (userEnumChoice == computerEnumChoice)
        {
            Console.WriteLine("무승부!");
        } 
        else if ((userEnumChoice == Choice.Rock && computerEnumChoice == Choice.Scissors) ||
                (userEnumChoice == Choice.Scissors && computerEnumChoice == Choice.Paper) ||
                (userEnumChoice == Choice.Paper && computerEnumChoice == Choice.Rock))
            {
                Console.WriteLine("사용자 승리!");
            }
            else 
            {
                Console.WriteLine("컴퓨터 승리!");
            }

            Console.Write("게임을 다시 하시겠습니까?");
            string playAgain = Console.ReadLine();


            if (playAgain.ToLower() == "y")
            {
                Console.WriteLine("게임 다시 시작");
                Main();
            }
            else
            {
                Console.WriteLine("게임종료!");
                Environment.Exit(0);
            }
        }
    }

