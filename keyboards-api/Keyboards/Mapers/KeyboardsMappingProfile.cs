using AutoMapper;
using keyboards_api.Keyboards.Dtos;
using keyboards_api.Keyboards.Models;

namespace keyboards_api.Keyboards.Mapers
{
    public class KeyboardsMappingProfile:Profile
    {
        public KeyboardsMappingProfile()
        {
            CreateMap<EditKeyboardRequest, Keyboard>();
            CreateMap<AddKeyboardRequest, Keyboard>();
            CreateMap<Keyboard, KeyboardResponse>();
        }
    }
}
