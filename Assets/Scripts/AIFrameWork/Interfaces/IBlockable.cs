namespace AIFrameWork.Interfaces
{
    public interface IBlockable
    {
        public bool IsBlocked();

        public void ChangeBlockStatus(bool newStatus);
    }
}