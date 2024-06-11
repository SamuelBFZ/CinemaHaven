using CinemaHaven.DAL.Entities;
using CinemaHaven.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaHaven.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaysController : Controller
    {
        private readonly IPayService _payService;

        public PaysController(IPayService payService)
        {
            _payService = payService;
        }

        [HttpGet, ActionName("Get")]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Pay>>> GetPaysAsync()
        {
            var pays = await _payService.GetPaysAsync();

            if (pays == null || !pays.Any())
            {
                return NotFound();
            }

            return Ok(pays);
        }

        [HttpGet, ActionName("Get")]
        [Route("GetById/{id}")]
        public async Task<ActionResult<Pay>> GetPayByIdAsync(Guid id)
        {
            var pay = await _payService.GetPayByIdAsync(id);

            if (pay == null)
            {
                return NotFound();
            }

            return Ok(pay);
        }

        [HttpPost, ActionName("Create")]
        [Route("Create")]
        public async Task<ActionResult<Pay>> CreatePayAsync(Pay pay)
        {
            var newPay = await _payService.CreatePayAsync(pay);

            if (newPay == null) return NotFound();

            return Ok(newPay);
        }

        [HttpPut, ActionName("Edit")]
        [Route("Edit")]
        public async Task<ActionResult<Pay>> EditPayAsync(Pay pay)
        {
            var editedPay = await _payService.EditPayAsync(pay);

            if (editedPay == null) return NotFound();

            return Ok(editedPay);
        }

        [HttpDelete, ActionName("Delete")]
        [Route("Delete")]
        public async Task<ActionResult<Pay>> DeletePayAsync(Guid id)
        {
            if (id == null) return BadRequest();

            var deletedPay = await _payService.DeletePayAsync(id);

            if (deletedPay == null) return NotFound();

            return Ok(deletedPay);
        }
    }
}
