using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coolOrange_CandidateChallenge;
using NUnit.Framework;

namespace coolOrange_CandidateChallengeTest
{
	[TestFixture]
	public class TTaskTest
	{
		[Test]
		public void SetGetCompexityPriority()
		{
			TTask task = new TTask("project");
			((IComplexity)task).SetComplexity(1);
			((IPriority)task).SetPriority(Priority.MAX_PRIORITY);
			Assert.AreEqual(1, ((IComplexity)task).GetComplexity());
			Assert.AreEqual(Priority.MAX_PRIORITY, ((IPriority)task).GetPriority());
		}

		[Test]
		public void compareTOssmaler() 
		{
            TTask task = new TTask("project");
            ((IComplexity)task).SetComplexity(1);
            ((IPriority)task).SetPriority(Priority.MED_PRIORITY);
            TTask task2 = new TTask("Chill");
            ((IComplexity)task2).SetComplexity(5);
            ((IPriority)task2).SetPriority(Priority.MIN_PRIORITY);

            Assert.AreEqual(-1, ((IComparable)task).CompareTo(task2));
            
        }

		[Test]
		public void compareTObigger() {
            TTask task = new TTask("project");
            ((IComplexity)task).SetComplexity(1);
            ((IPriority)task).SetPriority(Priority.MED_PRIORITY);
            TTask task2 = new TTask("Chill");
            ((IComplexity)task2).SetComplexity(5);
            ((IPriority)task2).SetPriority(Priority.MAX_PRIORITY);
            Assert.AreEqual(1, ((IComparable)task).CompareTo(task2));
        }

        [Test]
        public void compareToSame()
        {
            TTask task = new TTask("project");
            ((IComplexity)task).SetComplexity(1);
            ((IPriority)task).SetPriority(Priority.MED_PRIORITY);
            TTask task2 = new TTask("Chill");
            ((IComplexity)task2).SetComplexity(5);
            ((IPriority)task2).SetPriority(Priority.MED_PRIORITY);
            Assert.AreEqual(0, ((IComparable)task).CompareTo(task2));
        }

        [Test]
        public void compareToDifferent()
        {
            TTask task = new TTask("project");
            ((IComplexity)task).SetComplexity(1);
            ((IPriority)task).SetPriority(Priority.MED_PRIORITY);
            String c = "hey";

            Assert.Throws<ArgumentException>(() =>
            {
                ((IComparable)task).CompareTo(c);
            });
        }

        [Test]
        public void compareToNull()
        {
            TTask task = new TTask("project");
            ((IComplexity)task).SetComplexity(1);
            ((IPriority)task).SetPriority(Priority.MED_PRIORITY);

            Assert.Throws<ArgumentException>(() =>
            {
                ((IComparable)task).CompareTo(null);
            });
        }
    }
}