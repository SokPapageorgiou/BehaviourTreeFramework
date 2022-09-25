using AIFrameWork.Interfaces;

namespace AIFrameWork.BehaviourTree
{
    public class BTExecuter : IBlockable
    {
        private INode _firstNode;
        private bool _isBlocked;

        public BTExecuter(INode firstNode) => _firstNode = firstNode;
        
        public bool IsBlocked() => _isBlocked;
        public void ChangeBlockStatus(bool newStatus) => _isBlocked = newStatus;

    }
}