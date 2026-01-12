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
                bool userNum = true;
                string input = Console.ReadLine();      // ReadLine으로 입력받고
                if (input.Length != 4)                  // 4자리 string인지 입력인지 확인 
                {
                    Console.WriteLine("다시 입력해주세요"); // 입력한 값이 4자리 string 입력이 아닐 시 안내문
                    continue;
                }

                for (int i = 0; i < 4; i++)
                {
                    if (int.TryParse(input[i].ToString(), out playerNum[i]) == false) // TryParse로 char를 int로 변경
                    {
                        Console.WriteLine("숫자만 입력하세요.");              // 숫자 외 입력시 안내문
                        userNum = false;                                      // 입력한 값이 숫자가 아닐 시 false반환
                        break;                                                // false 일시 반복문 탈출 다시 숫자 입력부터
                    }
                }
                if (userNum == true)                                          // 중복이 아니면 아래 로직 수행
                {
                    return playerNum;                                         // 중복되지 않고 int로 변경된 숫자 반환
                }

            }

         
        }
    }
}
