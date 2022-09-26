using AIFrameWork.BehaviourTree;
using NUnit.Framework;
using Tests.TestClasses;

namespace Tests
{
    public class NodeTest
    {
        [Test]
        public void ConditionFalse()
        {
            var node = new Node(new ConditionFalse(), null, null, null);
            Assert.IsFalse(node.Condition().Assert());
        }

        [Test]
        public void ConditionTrue()
        {
            var node = new Node(new ConditionTrue(), null, null, null);
            Assert.IsTrue(node.Condition().Assert());
        }
        
        [Test]
        public void TaskFalse()
        {
            var node = new Node(null, new TaskFalse(), null, null);
            Assert.IsFalse(node.Task().Execute());
        }
        
        [Test]
        public void TaskTrue()
        {
            var node = new Node(null, new TaskTrue(), null, null);
            Assert.IsTrue(node.Task().Execute());
        }
    }
}