using Microsoft.AspNetCore.Mvc;
using System;


namespace Turma3API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DataHoraController : ControllerBase {

        static DateTime dataHora = DateTime.Now;
        static DateTime diaAula = new DateTime(2021, 7, 24, 8, 0, 0);

        TimeSpan proxAula = diaAula.Subtract(dataHora);

        [HttpGet]
        public IActionResult Get() {
            
            return BadRequest("Agora: " + dataHora + " e Faltam " + proxAula.ToString("") + " para proxima aula" );
        }

    }
}
