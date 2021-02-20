using System.Collections.Generic;
using System.Linq;

namespace EnumerationApi
{
    public class EnumerationService : IEnumerationService
    {
        public List<EnumerationDto> GetCats()
        {
            return GetEnumerations<Cat>();
        }

        public List<EnumerationDto> GetColors()
        {
            return GetEnumerations<Color>();
        }

        private List<EnumerationDto> GetEnumerations<TEnumeration>() where TEnumeration : Enumeration
        {
            var enumerations = Enumeration.GetAll<TEnumeration>();
            return enumerations.Select(e => EnumerationDto<TEnumeration>.FromEnumeration(e)).ToList();
        }
    }
}
