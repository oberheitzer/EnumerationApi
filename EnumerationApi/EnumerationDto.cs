using System;
using System.Linq.Expressions;

namespace EnumerationApi
{
    public class EnumerationDto : EnumerationDto<Enumeration>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public abstract class EnumerationDto<TEnumeration> where TEnumeration : Enumeration
    {

        public static Expression<Func<TEnumeration, EnumerationDto>> Projection
        {
            get
            {
                return enumeration => new EnumerationDto
                {
                    Id = enumeration.Id,
                    Name = enumeration.Name
                };
            }
        }

        public static EnumerationDto FromEnumeration(TEnumeration enumeration)
        {
            return Projection.Compile().Invoke(enumeration);
        }
    }
}
