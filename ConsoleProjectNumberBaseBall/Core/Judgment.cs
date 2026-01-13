using ConsoleProjectNumberBaseBall.Control;
using ConsoleProjectNumberBaseBall.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 스트라이크와 볼을 구분해주는 클래스
// 유저 입력과 생성된 숫자의 배열 자리의 숫자 비교 후
// 자리와 숫자가 같으면 스트라이크 처리
// 유저 입력과 생성된 숫자의 배열 자리의 숫자 비교 후
// 일치하는 숫자가 다른 인덱스에 존재할 경우는 볼
// 아무것도 존재하지 않으면 아웃
namespace ConsoleProjectNumberBaseBall.Core
{
    public class Judgment
    {
        public int[] CheckingScore(int[] answer, int[] player)
        {
            int strike = 0;
            int ball = 0;

            for (int i = 0; i < answer.Length; i++)        // 
            {
                for (int j = 0; j < player.Length; j++)    // 
                {
                    if (answer[i] == player[j])            // 배열안의 숫자 비교 숫자가 같으면 아래 로직 수행
                    {
                        if (i == j)                        // 인덱스 값을 비교
                        {
                            strike++;                      // 같은 위치의 인덱스 숫자가 서로 같으면 스트라이크
                        }
                        else
                        {
                            ball++;                        // 위치는 다르지만 숫자가 있다면 볼
                        }
                    }
                }
            }
            if (strike == 0 && ball == 0)                 // 스트라이크와 볼이 0일때 다음 로직 수행
            {
                "아웃!\n".Print(ConsoleColor.Red);             // 아웃 문구 출력
                Console.WriteLine();
                Console.WriteLine("--------------------------");
            }
            else
            {
                $"{strike} 스트라이크\t".Print(ConsoleColor.DarkYellow);    // 아웃이 아니면 스트라이크와 볼의 개수 출력
                $"{ball} 볼\n".Print(ConsoleColor.DarkGreen);
                Console.WriteLine();
            }
            return new int[] { strike, ball };
        }
    }
}
