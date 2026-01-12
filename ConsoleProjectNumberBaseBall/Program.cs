using ConsoleProjectNumberBaseBall.Control;
using ConsoleProjectNumberBaseBall.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectNumberBaseBall
{
    public class Program
    {
        static void Main(string[] args)
        {
          //  GenerateNumber GN = new GenerateNumber();
          //  GN.GetAnswerNumber();

           // InputNumber IN = new InputNumber();
          //  IN.GetUserNum();

            Judgment J = new Judgment();
            int[] fakeAnswer = {1, 2, 3, 4};
            int[] fakePlayer = {4, 3, 2, 1};
            int[] result = J.CheckingScore(fakeAnswer, fakePlayer);

        }
    }
}
