using AIFrameWork.Interfaces;

namespace AIFrameWork.BehaviourTree
{
    public class BTExecuter : IBlockable
    { 
        private bool _isBlocked;
        private INode _node;

        public bool IsBlocked() => _isBlocked;
        public void SetBlockStatus(bool newStatus) => _isBlocked = newStatus;
        

        public INode Node => _node;

        public bool Run(INode firstNode)
        {
            if (_isBlocked) return false;

            _node = firstNode;
            while (_node != null) _node = ProcessNode(_node);

            return true;
        }

        private INode ProcessNode(INode nodeToProcess)
        {
            if (nodeToProcess.Condition().Assert())
            {
                nodeToProcess.Task().Execute();
                return nodeToProcess.Succeeded();
            }

            return nodeToProcess.Failed();
        }
    }
}