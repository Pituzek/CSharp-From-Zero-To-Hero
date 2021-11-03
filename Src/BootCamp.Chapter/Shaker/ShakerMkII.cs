using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Shaker
{
    class ShakerMkII : IShaker
    {
        public string shakerModelName { get; }

        public ShakerMkII()
        {
            shakerModelName = "Shaker for MKII model";
        }

        public override string ToString()
        {
            return string.Format(shakerModelName);
        }
    }
}
