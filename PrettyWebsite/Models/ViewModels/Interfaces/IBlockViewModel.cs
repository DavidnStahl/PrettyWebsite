namespace PrettyWebsite.Models.ViewModels.Interfaces
{
    public interface IBlockViewModel<out T>
    {
        T CurrentBlock { get; }

        LayoutModel Layout { get; set; }
    }
}
