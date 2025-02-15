using AutoMapper;
using keyboards_api.Data.Migrations;
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
    }
}
