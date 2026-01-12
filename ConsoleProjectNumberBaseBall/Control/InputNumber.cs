using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 숫자를 입력하는 메서드를 가지고 있는 클래스
// 4자리 숫자인지 확인 V
// 숫자만 입력되는 조건 부여 
// 자리수가 중복되지 않은 조건 부여 
namespace ConsoleProjectNumberBaseBall.Control
{
    public class InputNumber
    {
        public int[] GetUserNum()
        {
            int[] playerNum = new int[4]; // 4자리 배열 선언

            while (true)                  // while 안이 true 면 반복
            {
                Console.WriteLine("4자리 숫자를 입력 해주세요");
                string input = Console.ReadLine();      // ReadLine으로 입력받고
                if (input.Length != 4)                  // 4자리수 인지 확인 
                {
                    Console.WriteLine("다시 입력해주세요");
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    int.TryParse(input, out playerNum[i]); //TryParse로 정수로 변경 어케함?
                                                           // 각자리 마다 바꿔줘야 함
                }

            }

            return playerNum;
        }
    }
}
