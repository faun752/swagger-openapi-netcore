using Microsoft.AspNetCore.Mvc;
using swagger_openapi_netcore.Models;
using swagger_openapi_netcore.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace swagger_openapi_netcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColorController : ControllerBase
    {
        private readonly IColorService _service;
        public ColorController(IColorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ColorResponseModel>> GetById(int id)
        {
            var response = await _service.GetColorResponse(id);
            return Ok(response);
        }

        [HttpGet("/all")]
        public async Task<ActionResult<IEnumerable<ColorResponseModel>>> GetAll()
        {
            var response = await _service.GetAllColorResponse();
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ColorResponseModel>> Create([FromBody] ColorRequestModel model)
        {
            var response = await _service.Create(model);
            return CreatedAtAction(nameof(GetById), new { id = model.ColorID }, response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ColorRequestModel model)
        {
            await _service.Update(model);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}
