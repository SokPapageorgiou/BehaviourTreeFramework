using AIFrameWork.Interfaces;

namespace AIFrameWork.BehaviourTree
{
    public class Node : INode
    {
        private ICondition _condition;
        private ITask _task;
        private INode _succeeded;
        private INode _failed;

        public Node(ICondition condition, ITask task, INode succeeded, INode failed)
        {
            _condition = condition;
            _task = task;
            _succeeded = succeeded;
            _failed = failed;
        }

        public ICondition Condition() => _condition;
        public ITask Task() => _task;
        public INode Succeeded() => _succeeded;
        public INode Failed() => _failed;
        
    }
}