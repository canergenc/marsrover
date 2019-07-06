using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Core.Models
{
    public class BaseOutputModel
    {
        public string Error { get; set; }
        public bool Success { get; set; }
        public string Result { get; set; }
    }
}
