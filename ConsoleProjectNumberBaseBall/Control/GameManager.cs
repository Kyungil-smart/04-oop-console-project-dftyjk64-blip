using ConsoleProjectNumberBaseBall.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 모든 클래스를 집결(조립) 및 진행을 위한 클래스
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

            while (true) 
            {
                int[] palyer = IN.GetUserNum();
                int[] result = j.CheckingScore(answer, palyer);

                if (result[0] == 4)
                {
                    Console.WriteLine("축하합니다. 승리했습니다.");
                    break;
                }
                
            }

        }
    }
}
