using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPlayground.Core.Controls
{
    public interface IFastCellCache
    {
        /// <summary>
        /// Flushs all caches.
        /// </summary>
        void FlushAllCaches();
    }
}
