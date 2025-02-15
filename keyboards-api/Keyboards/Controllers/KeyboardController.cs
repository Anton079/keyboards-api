using keyboards_api.Keyboards.Models;
using keyboards_api.Keyboards.Repostiory;
using Microsoft.AspNetCore.Mvc;

namespace keyboards_api.Keyboards.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KeyboardController : ControllerBase
    {
        private IKeyboardRepo _keyboardRepo;

        public KeyboardController(IKeyboardRepo keyboardRepo)
        {
            _keyboardRepo = keyboardRepo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Keyboard>>> GetKeyboardAsync()
        {
            var keyboard = await _keyboardRepo.GetKeyboardsAsync();

            return Ok(keyboard);
        }
    }
}
