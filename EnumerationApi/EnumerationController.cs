using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EnumerationApi
{
    [ApiController]
    [Route("api/enumerations")]
    public class EnumerationController : ControllerBase
    {
        private readonly IEnumerationService enumerationService;

        public EnumerationController(IEnumerationService enumerationService)
        {
            this.enumerationService = enumerationService;
        }

        [HttpGet("colors")]
        public List<EnumerationDto> GetColors()
        {
            return this.enumerationService.GetColors();
        }

        [HttpGet("cats")]
        public List<EnumerationDto> GetCats()
        {
            return this.enumerationService.GetCats();
        }
    }
}
