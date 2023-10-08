/*랜덤으로 1또는 7 을 7번출력한다. 7이 연속으로 3번이상이면 "당첨" 아니면 "꽝" 출력하시오.

[예시]
7 7 1 1 1 7 1 : 꽝
1 7 7 7 1 1 7 : 당첨
*/

using System;  /*include 와 동일 */

/*7이 연속으로 나오도록 하여 당첨여부 확인 --> 배열/리스트 없이 */

Random random  = new Random();
int sevenCount = 0;

for (int i=0; i<7; i++) {
    int randomValue = random.Next(2) + 6;
    //Console.WriteLine (randomValue);

    if (randomValue == 7) {
        sevenCount++;
        Console.Write("7 ");
    }
    else{
        Console.Write("1 ");  /* 1이 나오면 0으로 만들어 줘야 됨 */
    }
}

Console.WriteLine();


if (sevenCount >= 3) {
    Console.WriteLine("당첨!");
} else {
    Console.WriteLine("꽝");
}
    






