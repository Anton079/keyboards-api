using AutoMapper;
using keyboards_api.Data.Migrations;
using keyboards_api.Keyboards.Dtos;
using keyboards_api.Keyboards.Models;
using Microsoft.EntityFrameworkCore;

namespace keyboards_api.Keyboards.Repostiory
{
    public class KeyboardRepo : IKeyboardRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public KeyboardRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<Keyboard>> GetKeyboardsAsync()
        {
            return await _appDbContext.Keyboards.ToListAsync();
        }

        public async Task<KeyboardResponse> CreateKeyboardAsync(AddKeyboardRequest keyboardReq)
        {
            Keyboard keyboard = _mapper.Map<Keyboard>(keyboardReq);

            _appDbContext.Keyboards.Add(keyboard);

            await _appDbContext.SaveChangesAsync();

            KeyboardResponse response = _mapper.Map<KeyboardResponse>(keyboard);

            return response;
        }

        public async Task<List<Keyboard>> GetMinPrice(int min)
        {
            return await _appDbContext.Keyboards.Where(keyboard => keyboard.Price > min).ToListAsync();
        }

        public async Task<List<Keyboard>> GetMinMaxPrice(int min, int max)
        {
            return await _appDbContext.Keyboards.Where(keyboard => keyboard.Price > min && keyboard.Price < max).ToListAsync();
        }

        public async Task<KeyboardResponse> DeleteKeyboardById(int id)
        {
            var keyboard = await _appDbContext.Keyboards.FindAsync(id);

            KeyboardResponse keyboardResponse = _mapper.Map<KeyboardResponse>(keyboard);

            _appDbContext.Keyboards.Remove(keyboard);

            await _appDbContext.SaveChangesAsync();

            return keyboardResponse;
        }

        public async Task<KeyboardResponse> UpdateKeyboard(int id, EditKeyboardRequest keyboardRequest)
        {
            var keyboard = await _appDbContext.Keyboards.FindAsync(id);


            keyboard.Type = keyboardRequest.Type ?? keyboard.Type;
            keyboard.model = keyboardRequest.Model ?? keyboard.model;
            keyboard.Price = keyboardRequest.Price ?? keyboard.Price;

            _appDbContext.Keyboards.Update(keyboard);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<KeyboardResponse>(keyboard);


        }

        public async Task<KeyboardResponse> FindKeyboardById(int id)
        {
            var keyboard = await _appDbContext.Keyboards.FindAsync(id);

            if(keyboard == null) { return null; }

            return _mapper.Map<KeyboardResponse>(keyboard);
        }

        public async Task<bool> IsKeyboardExist(AddKeyboardRequest reqKeyboard)
        {
            return await _appDbContext.Keyboards.AnyAsync(c => c.model == reqKeyboard.Model &&
                                                               c.Type == reqKeyboard.Type);
    
        }

    }
}
