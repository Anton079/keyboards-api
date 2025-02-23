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

        public async Task<KeyboardResponse> CreateKeyboardAsync(KeyboardRequest keyboardReq)
        {
            Keyboard keyboard = _mapper.Map<Keyboard>(keyboardReq);

            _appDbContext.Keyboards.Add(keyboard);

            await _appDbContext.SaveChangesAsync();

            KeyboardResponse response = _mapper.Map<KeyboardResponse>(keyboard);

            return response;
        }
    }
}
