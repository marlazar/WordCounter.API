using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Core.Models
{
    public class ReadingInstance
    {
        public int InstanceId { get; set; }
        public string InstanceText { get; set; } = string.Empty;
    }
}
