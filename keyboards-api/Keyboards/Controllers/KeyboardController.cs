using keyboards_api.Keyboards.Dtos;
using keyboards_api.Keyboards.Models;
using keyboards_api.Keyboards.Repostiory;
using keyboards_api.Keyboards.service;
using Microsoft.AspNetCore.Mvc;

namespace keyboards_api.Keyboards.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KeyboardController : ControllerBase
    {
        private IKeyboardCommandService _keyboardCommandService;
        private IKeyboardQueryService _keyboardQueryService;

        public KeyboardController(IKeyboardCommandService keyboardCommandService, IKeyboardQueryService keyboardQueryService)
        {
            _keyboardCommandService = keyboardCommandService;
            _keyboardQueryService = keyboardQueryService;
        }

        [HttpGet("allKeyboard")]

        public async Task<ActionResult<List<Keyboard>>> GetKeyboardAsync()
        {
            var keyboard = await _keyboardQueryService.GetAllKeyboards();

            return Ok(keyboard);
        }

        [HttpPost("addKeyboard")]

        public async Task<ActionResult<KeyboardResponse>> CreateAsync ([FromBody] AddKeyboardRequest keyboardReq)
        {
            KeyboardResponse keyboardSaved = await _keyboardCommandService.AddKeyboards(keyboardReq);

            return Ok(keyboardSaved);
        }

        [HttpDelete("deleteKeyboard")]

        public async Task<ActionResult<KeyboardResponse>> DeleteKeyboardById([FromQuery] int id)
        {
            var Keyboard = await _keyboardCommandService.DeleteKeyboards(id);

            return Ok(Keyboard);
        }

        [HttpPut("UpdateKeyboard")]

        public async Task<ActionResult<KeyboardResponse>> UpdateKeyboard([FromQuery] int id, [FromBody] EditKeyboardRequest keyboardReq)
        {
            KeyboardResponse keyboard = await _keyboardCommandService.UpdateKeyboards(id, keyboardReq);

            return Ok(keyboard);
        }
    }
}
