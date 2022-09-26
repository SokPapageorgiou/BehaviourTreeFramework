using AIFrameWork.Interfaces;

namespace AIFrameWork.BehaviourTree
{
    public class BTExecuter : IBlockable
    { 
        private bool _isBlocked;
        private INode _node;
       
        public bool IsBlocked() => _isBlocked;
        public void IOBlockStatus() => _isBlocked = !_isBlocked;

        public void RunBT(INode firstNode)
        {
            if (_isBlocked) return;

            _node = firstNode;
            while (_node != null) _node = ProcessNode(_node);
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