namespace AIFrameWork.Interfaces
{
    public interface INode
    {
        public ICondition Condition();
        public ITask Task();
    }
}
