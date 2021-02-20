using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace EnumerationApi
{
    public class Enumeration
    {
        public string Name { get; private set; }

        public int Id { get; private set; }

        protected Enumeration(int id, string name) => (Id, Name) = (id, name);

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                     .Select(f => f.GetValue(null))
                     .Cast<T>();

        public static List<TResult> GetAllList<TEnumeration, TResult>(Expression<Func<TEnumeration, TResult>> selector) 
            where TEnumeration : Enumeration 
            where TResult : EnumerationDto
        {
            var query = GetAll<TEnumeration>().AsQueryable();
            return query.Select(selector).ToList();
        }
    }
}
