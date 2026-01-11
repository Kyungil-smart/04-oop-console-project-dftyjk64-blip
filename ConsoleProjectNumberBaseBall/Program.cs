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
            GenerateNumber GN = new GenerateNumber();
            GN.GetAnswerNumber();

            InputNumber IN = new InputNumber();
            IN.GetUserNum();
        }
    }
}
