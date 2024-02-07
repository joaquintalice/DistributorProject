using Distributor.Core.DTOs.Reparto;
using Distributor.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Distributor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepartoController : ControllerBase
    {
        private readonly IRepartoService _repartoService;

        public RepartoController(IRepartoService repartoService)
        {
            _repartoService = repartoService;
        }

        [HttpGet("get")]
        public async Task<ActionResult<List<RepartoDTO>>> GetAllRepartos()
        {
            return await _repartoService.GetAllRepartosAsync();
        }

        [HttpPost("create")]
        public async Task<ActionResult<RepartoDTO>> CreateReparto(CreateRepartoDTO repartoDTO)
        {
            return await _repartoService.CreateRepartoAsync(repartoDTO);
        }
    }
}
