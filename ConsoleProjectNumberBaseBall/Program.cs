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
            GameManager gm = new GameManager();
            gm.StartGame();

        }
    }
}
