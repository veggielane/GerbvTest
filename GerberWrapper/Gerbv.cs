using System.Runtime.InteropServices;

namespace GerberWrapper
{
    public static class Gerbv
    {
        private const string LIBRARY_PATH = "libgerbv-1.dll"; // Change this to the path of the Gerbv library on your system

        [DllImport(LIBRARY_PATH, EntryPoint = "gerbv_create_project")]
        public static extern IntPtr gerbv_create_project();

        [DllImport(LIBRARY_PATH, EntryPoint = "gerbv_destroy_project")]
        public static extern int gerbv_destroy_project(IntPtr project);

        [DllImport(LIBRARY_PATH, EntryPoint = "gerbv_open_layer_from_filename")]
        public static extern IntPtr gerbv_open_layer_from_filename(IntPtr project, string filename);


        [DllImport(LIBRARY_PATH, EntryPoint = "gerbv_export_png_file_from_project_autoscaled")]
        public static extern int gerbv_export_png_file_from_project_autoscaled(IntPtr project, int width, int height, string filename);


        [DllImport(LIBRARY_PATH, EntryPoint = "gerbv_export_svg_file_from_project_autoscaled")]
        public static extern int gerbv_export_svg_file_from_project_autoscaled(IntPtr project, string filename);

        [DllImport(LIBRARY_PATH, EntryPoint = "gerbv_export_autoscale_project")]
        public static extern IntPtr gerbv_export_autoscale_project(IntPtr project);

        [DllImport(LIBRARY_PATH, EntryPoint = "gerbv_export_svg_file_from_project")]
        public static extern int gerbv_export_svg_file_from_project(IntPtr project, IntPtr renderInfo, string filename);


    }
}
