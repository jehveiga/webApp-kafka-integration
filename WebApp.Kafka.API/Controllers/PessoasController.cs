using Microsoft.AspNetCore.Mvc;
using WebApp.Kafka.Producer.Application.Dtos.InputModels;
using WebApp.Kafka.Producer.Application.Services;

namespace WebApp.Kafka.Producer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IProducerMessageService _producerMessageService;

        public PessoasController(IProducerMessageService producerMessageService)
        {
            _producerMessageService = producerMessageService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PessoaInputModel pessoaInput) 
        {
            try
            {
                var result = await _producerMessageService.SendMessage(pessoaInput);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}
