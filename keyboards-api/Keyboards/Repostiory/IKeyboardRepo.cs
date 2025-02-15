using keyboards_api.Keyboards.Models;

namespace keyboards_api.Keyboards.Repostiory
{
    public interface IKeyboardRepo
    {
        Task<List<Keyboard>> GetKeyboardsAsync();
    }
}
