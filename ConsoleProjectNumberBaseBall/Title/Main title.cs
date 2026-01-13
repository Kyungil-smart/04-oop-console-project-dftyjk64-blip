using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProjectNumberBaseBall.Utils;

namespace ConsoleProjectNumberBaseBall.Title
{
    public class Main_title
    {
        public void Show()
        {
            "숫자 야구\n".Print(ConsoleColor.Gray);
            Console.WriteLine();
            Console.WriteLine("How to play\n");
            "1. 중복되지 않는 4자리 숫자를 입력한다.\n".Print(ConsoleColor.Gray);

            "2. 입력된 수의 자릿수와 숫자가 모두 맞은 수만 큼".Print(ConsoleColor.Gray); 
            " 스트라이크".Print(ConsoleColor.DarkYellow);
            " 처리한다.\n".Print(ConsoleColor.Gray);

            "3. 입력된 수의 숫자만 맞은 수만 큼".Print(ConsoleColor.Gray); 
            " 볼".Print(ConsoleColor.DarkGreen);
            " 처리한다.\n".Print(ConsoleColor.Gray);

            "4.".Print(ConsoleColor.Gray);
            " 스트라이크".Print(ConsoleColor.DarkYellow);
            "와".Print(ConsoleColor.Gray); 
            " 볼".Print(ConsoleColor.DarkGreen); 
            "이 0개일 때는".Print(ConsoleColor.Gray); 
            " 아웃".Print(ConsoleColor.Red);
            " 처리한다.\n".Print(ConsoleColor.Gray);

            "5. 총 9이닝으로 이닝 당 3번의 기회가 주어진다.\n".Print(ConsoleColor.Gray);

            "6. 스트라이크 4개가 나오면 승리한다.\n".Print(ConsoleColor.Gray);
            Console.WriteLine();
            "Enter을 누르면 게임이 시작됩니다.".Print(ConsoleColor.Cyan);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
