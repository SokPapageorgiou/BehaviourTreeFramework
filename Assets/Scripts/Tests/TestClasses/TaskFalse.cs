using AIFrameWork.Interfaces;

namespace Tests.TestClasses
{
    public class TaskFalse : ITask
    {
        public bool Execute() => false;
    }
}