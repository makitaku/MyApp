using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Entities
{
    /// <summary>
    /// 山岳基本情報
    /// </summary>
    public class Montain
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Prefecture Prefecture { get; set; }
        public Decimal Height { get; set; }
    }
}
