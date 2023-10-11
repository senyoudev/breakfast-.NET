using breakfastapp.contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace breakfast.Controllers;

    [ApiController]
    public class BreakFastController : ControllerBase
    {
        [HttpPost("/breakfasts")]
        public IActionResult CreateBreakFast(CreateBreakfastRequest request)
        {
            return Ok(request);
        }

        [HttpGet("/breakfasts/{id:guid}")]
        public IActionResult GetBreakFAst(Guid id)
        {
            return Ok(id);
        }

}

