/*
사용자에게 숫자를 입력받고 2의 배수인지 아닌지를 출력하는 프로그램을 만드시오
단, 사용자에게 입력받은 것이 숫자가 아닐경우 "숫자가 아닙니다"를 출력하시오.
*/

using System;
using System.Security.Principal;

class Baesu {
    static void Main() {
        int intervalNum = 2;
        int resmsg = 0;
        string number = Console.ReadLine();
        Console.WriteLine("입력하신 숫자는" + int.Parse(number) + "입니다");
        if (int.Parse(number) % intervalNum == 0)
            {
                Console.WriteLine("당신이 입력한 숫자는 2의 배수입니다");
            } else if (int.Parse(number) % intervalNum != 0)
            {
                Console.WriteLine("당신이 입력한 숫자는 2의 배수가 아닙니다");
            } else if (int.TryParse(number, out resmsg))
            {
                Console.WriteLine("당신이 입력한 것은 숫자가 아닙니다");
            }
       }
}


