using keyboards_api.Keyboards.Dtos;

namespace keyboards_api.Keyboards.service
{
    public interface IKeyboardQueryService
    {
        Task<List<KeyboardResponse>> GetAllKeyboards();
    }
}
