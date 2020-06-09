using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AudioPlayermSample.Models
{
    public class AudioItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
