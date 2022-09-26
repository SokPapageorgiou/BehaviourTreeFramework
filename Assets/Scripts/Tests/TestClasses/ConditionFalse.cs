using AIFrameWork.Interfaces;

namespace Tests.TestClasses
{
    public class ConditionFalse : ICondition
    {
        public bool Assert() => false;
    }
}