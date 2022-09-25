namespace AIFrameWork.Interfaces
{
    public interface INode
    {
        public ICondition Condition();
        public ITask Task(IBlockable blockable);

        public INode Succeeded();
        public INode Failed();
    }
}
