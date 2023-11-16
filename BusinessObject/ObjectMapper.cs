using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ObjectMapper
    {
        public T Map<T>(object objfrom, T objto)
        {
            if (objfrom == null)
            {
                return default;
            }

            var ToProperties = objto.GetType().GetProperties();
        
            var FromProperties = objfrom.GetType().GetProperties();

            ToProperties.ToList().ForEach(o =>
            {
                var fromp = FromProperties.FirstOrDefault(x => string.Equals(x.Name, o.Name, StringComparison.OrdinalIgnoreCase) && x.PropertyType.Equals(o.PropertyType));
                if (fromp != null)
                {
                    o.SetValue(objto, fromp.GetValue(objfrom));
                }
            });

            return objto;
        }
    }
}
