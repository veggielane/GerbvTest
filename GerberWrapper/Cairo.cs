using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GerberWrapper
{
    public static class Cairo
    {
        private const string LIBRARY_PATH = "libcairo-2.dll"; // Change this to the path of the Gerbv library on your system
        [DllImport(LIBRARY_PATH, EntryPoint = "cairo_surface_write_to_png_stream")]
        public static extern int cairo_surface_write_to_png_stream(IntPtr surface, IntPtr write_func, IntPtr closure);
    }
}
