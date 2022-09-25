namespace AIFrameWork.Interfaces
{
    public interface INode
    {
        public ICondition Condition();
        
        /// <summary>
        /// Execute a task. If the task takes more than one frame to execute, the three execution has to be blocked.
        /// </summary>
        /// <param name="blockable">Block the execution of a Tree if the task takes more than one frame to execute</param>
        /// <returns></returns>
        public ITask Task(IBlockable blockable);

        public INode Succeeded();
        public INode Failed();
    }
}
