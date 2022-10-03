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
            _btExecuter.SetBlockStatus(true);
            Assert.IsTrue(_btExecuter.IsBlocked());
            
            _btExecuter.SetBlockStatus(false);;
            Assert.IsFalse(_btExecuter.IsBlocked());
        }

        private Node _start_True = new( new ConditionTrue(), new TaskTrue(),
            new Node(new ConditionTrue(), new TaskTrue(), null, null),
            new Node(new ConditionFalse(), new TaskFalse(), null, null)
            );

        [Test]
        public void BTExecuter_Run_True()
        {
            Assert.IsTrue(_btExecuter.Run(_start_True));
        }
        
        [Test]
        public void BTExecuter_Run_False()
        {
            _btExecuter.SetBlockStatus(false);
            Assert.IsTrue(_btExecuter.Run(_start_True));
            _btExecuter.SetBlockStatus(true);
        }

        [Test]
        public void BTExecuter_Run_LastNode_StartTrue()
        {
            _btExecuter.Run(_start_True);
            Assert.IsTrue(_btExecuter.LastNode.Condition().Assert());
            Assert.IsTrue(_btExecuter.LastNode.Task().Execute());
        }
        
        private Node _start_False = new( new ConditionFalse(), new TaskTrue(),
            new Node(new ConditionTrue(), new TaskTrue(), null, null),
            new Node(new ConditionFalse(), new TaskFalse(), null, null)
        );

        [Test]
        public void BTExecuter_Run_LastNode_StartFalse()
        {
            _btExecuter.Run(_start_False);
            Assert.IsFalse(_btExecuter.LastNode.Condition().Assert());
            Assert.IsFalse(_btExecuter.LastNode.Task().Execute());
        }
    }
}
