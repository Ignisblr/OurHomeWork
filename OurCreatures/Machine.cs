using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public class Machine : Creature, IMachine
    {
        int MadingYear { get; set; }

        string Color { get; set; }

        string Purpose { get; set; }

        public void GetInstructions(List<Instruction> instructions)
        {
            foreach (Instruction instruction in instructions)
            {
                Console.WriteLine($"starting to execute next {instruction}");
            }
        }
    }
}
