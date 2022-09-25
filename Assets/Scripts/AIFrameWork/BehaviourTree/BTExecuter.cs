using AIFrameWork.Interfaces;

namespace AIFrameWork.BehaviourTree
{
    public class BTExecuter : IBlockable
    { 
        private bool _isBlocked;
       
        public bool IsBlocked() => _isBlocked;
        public void IOBlockStatus() => _isBlocked = !_isBlocked;

    }
}