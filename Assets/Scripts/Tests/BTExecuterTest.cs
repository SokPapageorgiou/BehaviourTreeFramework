using AIFrameWork.BehaviourTree;
using NUnit.Framework;

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
    }
}
