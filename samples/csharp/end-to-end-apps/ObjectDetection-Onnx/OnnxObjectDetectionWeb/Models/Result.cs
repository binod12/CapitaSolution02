using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnnxObjectDetectionWeb.Models
{
    public class Result
    {
        public string imageString { get; set; }
        public List<string> maps { get; set; }
        public Result()
        {
            maps = new List<string>();
        }
    }
}
