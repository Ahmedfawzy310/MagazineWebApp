namespace Magazine.IServices
{
    public interface ISlider
    {
         IEnumerable<TbHomeSlider> Main();
         IEnumerable<TbHomeSlider> Second();
         
    }
}
