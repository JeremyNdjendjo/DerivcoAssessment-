using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace Matches
{
    public class CsvUserDetailsMapping:CsvMapping<UserDetails>
    {
        public CsvUserDetailsMapping()
          : base()
        {
            MapProperty(0, x => x.ID);
            MapProperty(1, x => x.Name);
            MapProperty(2, x => x.Gender);
        }
    }
}
