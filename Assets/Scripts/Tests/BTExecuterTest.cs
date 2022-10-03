using AIFrameWork.BehaviourTree;
using NUnit.Framework;
using Tests.TestClasses;

namespace Tests
{
    public class BtExecuterTest
    {
        private BTExecuter _btExecuter = new();
        
        [Test]
        public void BTExecuter_IsBlocked() => Assert.IsFalse(_btExecuter.IsBlocked());

        [Test]
        public void BTExecuter_IOBlockStatus()
        {
            _btExecuter.IOBlockStatus();
            Assert.IsTrue(_btExecuter.IsBlocked());
            
            _btExecuter.IOBlockStatus();
            Assert.IsFalse(_btExecuter.IsBlocked());
        }

        private Node _start = new( new ConditionTrue(), new TaskTrue(),
            new Node(new ConditionTrue(), new TaskFalse(), null, null),
            new Node(new ConditionTrue(), new TaskFalse(), null, null)
            );

        [Test]
        public void BTExecuter_Run()
        {
            Assert.IsTrue(_btExecuter.Run(_start));
        }
    }
}
