namespace AIFrameWork.Interfaces
{
    public interface IBlockable
    {
        public bool IsBlocked();

        public void SetBlockStatus(bool newStatus);
    }
}