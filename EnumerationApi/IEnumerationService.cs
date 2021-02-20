using System.Collections.Generic;

namespace EnumerationApi
{
    public interface IEnumerationService
    {
        List<EnumerationDto> GetColors();
        List<EnumerationDto> GetCats();
    }
}
