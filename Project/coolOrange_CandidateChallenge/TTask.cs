using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public enum Priority
    {
        MIN_PRIORITY = 1,
        MED_PRIORITY = 5,
        MAX_PRIORITY = 10,
    }

    public interface IPriority
    {
        void SetPriority(Priority priority);
        Priority GetPriority();
    }

    public interface IComplexity
    { 
        void SetComplexity(int complexity);
        int GetComplexity();
    }
    /**
     * musste es TTask nennen weil sonst ein konflikt mit
     * Threading.Tasks.Task gab
     */
    public class TTask : IComplexity, IPriority, IComparable 
    {
        String name;
        int complexity;
        Priority priority;

        public TTask(String name)
        {
            this.name = name;
            ((IPriority)this).SetPriority(Priority.MED_PRIORITY);
        }

        public String GetName()
        {
            return name;
        }

        void IComplexity.SetComplexity(int complexity)
        {
            this.complexity = complexity;
        }
        int IComplexity.GetComplexity()
        {
            return this.complexity;
        }

        void IPriority.SetPriority(Priority priority)
        {
            this.priority = priority;
        }


        Priority IPriority.GetPriority()
        {
            return this.priority;
        }

        int IComparable.CompareTo(object obj)
        {
            if (obj == null || !(obj is TTask))
            {
                throw new ArgumentException("Kein object oder falsches Object");
            }
            if (this == obj) return 0;

            TTask task = obj as TTask;
            if(((IPriority)task).GetPriority() > ((IPriority)this).GetPriority()){
                return 1;
            }
            if (((IPriority)task).GetPriority() < ((IPriority)this).GetPriority())
            {
                return -1;
            }
            return 0;
        } 
    }
}
