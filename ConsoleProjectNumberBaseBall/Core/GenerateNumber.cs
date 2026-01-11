using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// 랜덤으로 각자리수가 중복되지 않은 4자리 숫자를 만들기
// 배열의 크기를 선언
// Random으로 참조 변수 선언
// 숫자와 배열을 만드는 반환하는 메서드 만들기
namespace ConsoleProjectNumberBaseBall.Core
{
    public class GenerateNumber
    {
        int[] AnswerNumber = new int[4];    // 배열의 크기를 4로 선언
        Random RandomNumber = new Random(); // Random 변수

        public int[] GetAnswerNumber() // 숫자와 배열을 만들어서 반환하는 메서드
        {
            int count = 0;
            while (count < AnswerNumber.Length) // 배열의 크기만큼 반복
            {
                int RanNumRange = RandomNumber.Next(0, 10); // 각 자리 숫자마다 0~9로 범위 정하기
                bool sameNum = false;
                Console.WriteLine($"{count + 1}번 숫자, 뽑힌 숫자{RanNumRange}"); // 디버깅 나중에 각주처리
                for (int i = 0; i < count; i++)         // 배열을 차례로 숫자 넣기
                {
                    if (AnswerNumber[i] == RanNumRange) // 디버깅 결과 1번 숫자까지만 나옴 무한 반복
                    {                                   // 2번째 숫자를 뽑으려면 break가 작동해야하고 
                        sameNum = true;                 // break가 작동하려면 if 안이 true가 되어야한다.
                        break;
                    }
                }
                if (sameNum == false)                   // 중복이 아니면 값 확정 후 count 올려서 while 반복
                {
                    AnswerNumber[count] = RanNumRange;
                    count++;
                }
            }

            Console.Write("정답: ");                      // 디버깅 나중에 각주처리
            foreach (int num in AnswerNumber) 
            {
                Console.Write(num);
                
            }
            Console.WriteLine();
            return AnswerNumber;

        }

    }
}
