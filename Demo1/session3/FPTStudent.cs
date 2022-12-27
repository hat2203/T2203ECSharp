using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.session3
{
    public class FPTStudent : AbstractStudent, IHuman, IStuddent
    {
        public FPTStudent()
        {
        }

        public void Eat()
        {

        }

        public override void Learn()
        {
            throw new NotImplementedException();
        }

        public void PlayGame()
        {
            throw new NotImplementedException();
        }
    }
}
