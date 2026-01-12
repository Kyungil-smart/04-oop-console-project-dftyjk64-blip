using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 화면을 그려주는 클래스
namespace ConsoleProjectNumberBaseBall.UI
{
    public abstract class Scene
    {
        public abstract void Enter();
        public abstract void Update();
        public abstract void Render();
        public abstract void Exit();
    }
}
