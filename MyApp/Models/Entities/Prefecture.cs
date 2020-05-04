using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Entities
{
    /// <summary>
    /// 都道府県
    /// </summary>
    public class Prefecture
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Order { get; set; }
    }
}
