using ConsoleProjectNumberBaseBall.Core;
using ConsoleProjectNumberBaseBall.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 모든 클래스를 집결(조립) 및 진행을 위한 클래스
// 9이닝 동안 진행하며 이닝 당 총 3회의 기회를 부여
// 이닝을 내에 모두 끝내지 못하면 게임 오버
namespace ConsoleProjectNumberBaseBall.Control
{
    public class GameManager
    {
        public void StartGame()
        {
            GenerateNumber gn = new GenerateNumber();
            InputNumber IN = new InputNumber();
            Judgment j = new Judgment();

            int[] answer = gn.GetAnswerNumber();


            for (int inning = 1; inning <= 9; inning++)
            {
                Console.WriteLine("--------------------------\n");
                $"{inning} 이닝 시작\n".Print(ConsoleColor.Green);
                Console.WriteLine();

                for (int outCount = 0; outCount <= 2; outCount++)
                {
                    $"{inning}이닝 남은 타자 {3 - outCount}명\n".Print(ConsoleColor.Yellow);
                    Console.WriteLine();

                    int[] palyer = IN.GetUserNum();
                    int[] result = j.CheckingScore(answer, palyer);
                    Console.WriteLine();

                    if (result[0] == 4)
                    {

                        "축하합니다. 승리했습니다.\n".Print(ConsoleColor.Green);
                        Console.WriteLine();
                        "정답은 ".Print(ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (int i in answer) Console.Write(i);
                        "입니다.\n".Print(ConsoleColor.Green);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------\n");

                        return;
                    }

                    if (outCount < 2)
                    {
                        "타자 아웃!\n".Print(ConsoleColor.Red);
                        Console.WriteLine();
                    }

                    else if (inning != 9 && outCount == 2)
                    {
                        "3 아웃! 이닝 체인지!!\t".Print(ConsoleColor.DarkRed);
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    
                    else
                    {
                        "경기 종료!\t".Print(ConsoleColor.DarkRed);
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                }
            }

            "패배하셨습니다.\n".Print(ConsoleColor.Red);
            Console.WriteLine();

            "정답은 ".Print(ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (int i in answer) Console.Write(i);
            Console.ResetColor();
            "입니다.\n".Print(ConsoleColor.Red);
            Console.WriteLine();
            Console.WriteLine("--------------------------\n");
        }
    }
}

