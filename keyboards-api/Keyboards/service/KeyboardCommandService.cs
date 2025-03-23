using AutoMapper;
using keyboards_api.Keyboards.Dtos;
using keyboards_api.Keyboards.Exceptions;
using keyboards_api.Keyboards.Repostiory;

namespace keyboards_api.Keyboards.service
{
    public class KeyboardCommandService : IKeyboardCommandService
    {
        private IKeyboardRepo _keyboardRepo;
        private IMapper _mapper;

        public KeyboardCommandService(IKeyboardRepo keyboardRepo, IMapper _mapper)
        {
            this._keyboardRepo = keyboardRepo;
            this._mapper = _mapper;
        }

        public async Task<KeyboardResponse> AddKeyboards(AddKeyboardRequest keyboardReq)
        {
            if (keyboardReq == null) { throw new NullKeyboardException(); }

            if(await _keyboardRepo.IsKeyboardExist(keyboardReq)) { throw new KeyboardExistException(); }

            KeyboardResponse resp = await _keyboardRepo.CreateKeyboardAsync(keyboardReq);

            return resp;
        }

        public async Task<KeyboardResponse> UpdateKeyboards(int id, EditKeyboardRequest keyboardReq)
        {
            if (keyboardReq == null) { throw new NullKeyboardException(); }

            if (keyboardReq.Model == null) { throw new NullModelException(); }
            if (keyboardReq.Price == null) { throw new NullPriceException(); }
            if (keyboardReq.Type == null) { throw new NullTypeException(); }

            KeyboardResponse resp = await _keyboardRepo.UpdateKeyboard(id, keyboardReq);

            return resp;
        }

        public async Task<KeyboardResponse> DeleteKeyboards(int id)
        {        
            var key = _keyboardRepo.FindKeyboardById(id);

            if(key.Id != id) { throw new IdNotFound(); }

            var keyboard = _keyboardRepo.DeleteKeyboardById(id);

            return _mapper.Map<KeyboardResponse>(keyboard);
        }

       
    }
}
