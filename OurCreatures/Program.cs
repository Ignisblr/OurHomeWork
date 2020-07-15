using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    class Program
    {
        //List<Type> ourCreatures = new List<Type>();

        //public List<Type> GetAllCreatures(Type creature)
        //{
        //    ourCreatures.Add(creature);
        //    return ourCreatures;
        //}
        static void Main(string[] args)
        {
            //Instruction[] instructions = new Instruction[new Random().Next(2, 5)];
            //for (int i = 0; i < instructions.Length; i++)
            //{
            //    instructions[i] = new Instruction() { Description = String.Format("instruction №{0}", i+1) };
            //}

            //Auto auto = new Auto();
            //auto.SetDriver(new Human() { Name = "Ray" });
            //auto.GetInstructions(instructions.ToList<Instruction>());
            //auto.Move();

            var type = new CafeGirl().GetType();
            Activator.CreateInstance(type).ToString();
            object somePolishGirl = Activator.CreateInstance(type);
            ICollection<MemberInfo> membersOfClass = type.GetProperties();
            foreach (MemberInfo member in membersOfClass)
            {
                Console.WriteLine(member.ToString());
            }
            Console.ReadKey();
        }
    }
}
