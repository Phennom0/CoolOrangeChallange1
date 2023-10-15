using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace coolOrange_CandidateChallenge
{
    internal class TaskDriver
    {
        static void Main(string[] args)
        {
            TTask[] tasks = new TTask[3];

            tasks[0] = new TTask("Doing Homework");
            ((IComplexity)tasks[0]).SetComplexity(1);
            ((IPriority)tasks[0]).SetPriority(Priority.MAX_PRIORITY);

            tasks[1] = new TTask("Eating Lunch");
            ((IComplexity)tasks[1]).SetComplexity(1);
            ((IPriority)tasks[1]).SetPriority(Priority.MIN_PRIORITY);

            tasks[2] = new TTask("Priority");
            ((IComplexity)tasks[2]).SetComplexity(1);
            ((IPriority)tasks[2]).SetPriority(Priority.MED_PRIORITY);
            Console.WriteLine("TO-DO\n-----------------");
            Console.WriteLine(tasks[0].GetName() + " priority: " + ((IPriority)tasks[0]).GetPriority() + " complexity: " + ((IComplexity)tasks[0]).GetComplexity());
            Console.WriteLine(tasks[1].GetName() + " priority: " + ((IPriority)tasks[1]).GetPriority() + " complexity: " + ((IComplexity)tasks[1]).GetComplexity());
            Console.WriteLine(tasks[2].GetName() + " priority: " + ((IPriority)tasks[2]).GetPriority() + " complexity: " + ((IComplexity)tasks[2]).GetComplexity());

            Console.WriteLine("\n" + tasks[TaskArray(tasks)].GetName() + " is one of the most important tasks");
            Console.WriteLine("Press a key to leave...");
            Console.ReadKey();
        }

        public static int TaskArray(TTask[] t)
        {
            int save = 0;
            for(int i = 1; i < t.Length; i++)
            {
                if (((IPriority)t[save]).GetPriority() < ((IPriority)t[i]).GetPriority())
                {
                    save = i;
                }
            }
            return save;
        }
    }
}
