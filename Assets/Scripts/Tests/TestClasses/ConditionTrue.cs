using AIFrameWork.Interfaces;

namespace Tests.TestClasses
{
    public class ConditionTrue : ICondition
    {
        public bool Assert() => true;
    }
}