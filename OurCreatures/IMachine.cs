using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public interface IMachine
    {
        void GetInstructions(List<Instruction> instructions);
    }
}
