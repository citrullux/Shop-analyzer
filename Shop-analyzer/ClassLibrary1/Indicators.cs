using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indicators
{
    public class Indicators
    {
        [System.ComponentModel.DisplayName("Годовая экономия (Прибыль)")]
        public double YearSave { get; set; }
        [System.ComponentModel.DisplayName("Годовой экономический эффект")]
        public double YearEffect { get; set; }
    }
}
