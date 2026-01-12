using ConsoleProjectNumberBaseBall.Core;
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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{inning} 이닝 시작");
                Console.ResetColor();
                for (int outCount = 0; outCount <= 2; outCount++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{inning}이닝 남은 타자 {3 - outCount}명\n");
                    Console.ResetColor();

                    int[] palyer = IN.GetUserNum();
                    int[] result = j.CheckingScore(answer, palyer);
                    Console.WriteLine();

                    if (result[0] == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("축하합니다. 승리했습니다.\n");
                        Console.Write("정답은 ");
                        foreach (int i in answer) Console.Write(i);
                        Console.WriteLine("입니다.\n");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------\n");
                        
                        return;
                    }

                    if (outCount < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("타자 아웃!");
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("3 아웃! 이닝 체인지!!");
                        Console.WriteLine();
                        Console.ResetColor();
                    }
                    
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("패배하셨습니다.\n");
            Console.Write("정답은 ");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (int i in answer) Console.Write(i);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("입니다.\n");
            Console.WriteLine("--------------------------\n");
            Console.ResetColor();
        }
    }
}

