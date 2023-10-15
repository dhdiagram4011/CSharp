/*랜덤으로 1또는 7 을 7번출력한다. 7이 연속으로 3번이상이면 "당첨" 아니면 "꽝" 출력하시오. */

using System;

/*7이 연속으로 나오도록 하여 당첨여부 확인 --> 배열/리스트 없이 */

class Seven
{
    static void Main()
    {
        Random random = new Random();  
        int consecutiveSevens = 0; //연속된 7
        int maxConsecutiveSevens = 0; // 연속된 7의 최대 갯수

        for (int i=0; i < 7; i++) //7개의연속된 7이 나올때까지
        {
            int randomValue = random.Next(2) + 6; //1또는 7출력

            if (randomValue == 7) {
                consecutiveSevens++;
                Console.Write("7 ");
            }
            else{
                consecutiveSevens = 0; // 7이외의 값이 나오면 0으로 재설정
                Console.Write("1 ");  /* 1이 나오면 0으로 만들어 줘야 됨 */
            }
            /*
            consecutiveSevens : 연속된 7의 갯수
            maxConsecutiveSevens : 연속된 7의 최대 갯수
            maxConsecutiveSevens : 가장 컷던 값을 기억
            */  
            if (consecutiveSevens > maxConsecutiveSevens) //연속된 7의갯수가 연속된 7의 최대 갯수보다 크면
            {
                maxConsecutiveSevens = consecutiveSevens;
            }

        }
        Console.WriteLine();

        if (maxConsecutiveSevens >= 3) {
            Console.WriteLine("당첨!");
        } else {
            Console.WriteLine("꽝");    
        }
    }   
}

    






