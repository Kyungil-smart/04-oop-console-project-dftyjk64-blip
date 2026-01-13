using ConsoleProjectNumberBaseBall.Control;
using ConsoleProjectNumberBaseBall.Core;
using ConsoleProjectNumberBaseBall.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 부족한 기능
// 타이틀 화면에서 Enter키만 입력되는 구현
// 이닝의 결과만 출력
// 로그를 볼 수 있는 기능 구현
namespace ConsoleProjectNumberBaseBall
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameManager gm = new GameManager();
            gm.StartGame();

        }
    }
}
