namespace Magazine.IServices
{
    public interface ISetLinks
    {
        public TbSetting Get();
        public bool Save(TbSetting set);
    }
}
