using AutoMapper;
using keyboards_api.Keyboards.Dtos;
using keyboards_api.Keyboards.Repostiory;

namespace keyboards_api.Keyboards.service
{
    public class KeyboardQueryService :IKeyboardQueryService
    {
        private IKeyboardRepo _keyboardRepo;
        private IMapper _mapper;

        public KeyboardQueryService(IKeyboardRepo keyboardRepo,IMapper mapper)        
        {
            this._keyboardRepo = keyboardRepo;
            this._mapper = mapper;
        }
        
        public async Task<List<KeyboardResponse>> GetAllKeyboards()
        {
            var keyboards= await _keyboardRepo.GetKeyboardsAsync();

            return _mapper.Map<List<KeyboardResponse>>(keyboards);
        }

        
    }
}
