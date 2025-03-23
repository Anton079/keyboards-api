using keyboards_api.Keyboards.Dtos;
using keyboards_api.Keyboards.Models;

namespace keyboards_api.Keyboards.Repostiory
{
    public interface IKeyboardRepo
    {
        Task<List<Keyboard>> GetKeyboardsAsync();

        Task<KeyboardResponse> CreateKeyboardAsync(AddKeyboardRequest keyboardReq);

        Task<List<Keyboard>> GetMinPrice(int min);

        Task<List<Keyboard>> GetMinMaxPrice(int min, int max);

        Task<KeyboardResponse> UpdateKeyboard(int id, EditKeyboardRequest keyboardRequest);

        Task<KeyboardResponse> DeleteKeyboardById(int id);

        Task<KeyboardResponse> FindKeyboardById(int id);

        Task<bool> IsKeyboardExist(AddKeyboardRequest reqKeyboard);
    }
}
