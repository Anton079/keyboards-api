using keyboards_api.Keyboards.Dtos;
using keyboards_api.Keyboards.Exceptions;

namespace keyboards_api.Keyboards.service
{
    public interface IKeyboardCommandService
    {
        Task<KeyboardResponse> AddKeyboards(AddKeyboardRequest keyboardReq);

        Task<KeyboardResponse> UpdateKeyboards(int id, EditKeyboardRequest keyboardReq);

        Task<KeyboardResponse> DeleteKeyboards(int id);
    }
}
