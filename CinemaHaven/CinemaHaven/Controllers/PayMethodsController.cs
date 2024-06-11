using CinemaHaven.DAL;
using CinemaHaven.DAL.Entities;
using CinemaHaven.Domain.Interfaces;
using CinemaHaven.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace CinemaHaven.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayMethodsController : Controller
    {
        private readonly IPayMethodService _payMethodService;

        public PayMethodsController(IPayMethodService payMethodService)
        {
            _payMethodService = payMethodService;
        }


        [HttpGet, ActionName("Get")]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<PaymentMethod>>> GetPayMethodsAsync()
        {
            var paysMethod = await _payMethodService.GetPayMethodsAsync();

            if (paysMethod == null || !paysMethod.Any())
            {
                return NotFound();
            }

            return Ok(paysMethod);
        }

        [HttpGet, ActionName("Get")]
        [Route("GetById/{id}")]
        public async Task<ActionResult<PaymentMethod>> GetPayMethodByIdAsync(Guid id)
        {
            var payMethod = await _payMethodService.GetPayMethodByIdAsync(id);

            if (payMethod == null)
            {
                return NotFound();
            }

            return Ok(payMethod);
        }

        [HttpPost, ActionName("Create")]
        [Route("Create")]
        public async Task<ActionResult<PaymentMethod>> CreatePayMethodAsync(PaymentMethod payMeth)
        {
            var newPayMethod = await _payMethodService.CreatePayMethodAsync(payMeth);

            if (newPayMethod == null) return NotFound();

            return Ok(newPayMethod);
        }

        [HttpPut, ActionName("Edit")]
        [Route("Edit")]
        public async Task<ActionResult<PaymentMethod>> EditPayMethodAsync(PaymentMethod payMeth)
        {
            var editedPayMeth = await _payMethodService.EditPayMethodAsync(payMeth);

            if (editedPayMeth == null) return NotFound();

            return Ok(editedPayMeth);
        }

        [HttpDelete, ActionName("Delete")]
        [Route("Delete")]
        public async Task<ActionResult<PaymentMethod>> DeletePayMethodAsync(Guid id)
        {
            if (id == null) return BadRequest();

            var deletedPayMeth = await _payMethodService.DeletePayMethodAsync(id);

            if (deletedPayMeth == null) return NotFound();

            return Ok(deletedPayMeth);
        }
    }
}
