// See https://aka.ms/new-console-template for more information
using GerberWrapper;



var mainProject = Gerbv.gerbv_create_project();
Gerbv.gerbv_open_layer_from_filename(mainProject, "dvk-mx8m-bsb-F_Mask.gbr");
Gerbv.gerbv_export_svg_file_from_project_autoscaled(mainProject, "output.svg");
Gerbv.gerbv_destroy_project(mainProject);


//Gerbv.gerbv_export_png_file_from_project_autoscaled(mainProject, 640, 480, "example3-output.png");
//Gerbv.gerbv_export_svg_file_from_project_autoscaled(mainProject, "example3-output.svg");


//var renderInfo = Gerbv.gerbv_export_autoscale_project(mainProject);

//Gerbv.gerbv_export_svg_file_from_project(mainProject, renderInfo, "test.svg");

/*
 *  void gerbv_export_svg_file_from_project_autoscaled (gerbv_project_t *gerbvProject, gchar const* filename) {
        gerbv_render_info_t renderInfo = gerbv_export_autoscale_project(gerbvProject);
        gerbv_export_svg_file_from_project (gerbvProject, &renderInfo, filename);
 }
 */

//Console.WriteLine("Hello, World!");
//gerbv_project_t* mainProject = gerbv_create_project();

///* parse a Gerber file and store it in the gerbv_project_t struct, and
//   then immediately parse a second copy */
//gerbv_open_layer_from_filename(mainProject, "example3-input.gbx");
//gerbv_open_layer_from_filename(mainProject, "example3-input.gbx");

///* make sure we parsed the files */
//if ((mainProject->file[0] == NULL) || (mainProject->file[1] == NULL))
//    g_error("There was an error parsing the files.");

///* translate the second image (file[1]) up and right by 0.02 inches */
//mainProject->file[1]->transform.translateY = 0.02;
//mainProject->file[1]->transform.translateX = 0.02;

///* change the color of the first image (file[0]) to green */
//GdkColor greenishColor = { 0, 10000, 65000, 10000 };
//mainProject->file[0]->color = greenishColor;

///* export a rendered PNG image of the project, using the autoscale version
//   to automatically center the image */
//gerbv_export_png_file_from_project_autoscaled(mainProject, 640, 480,
//                            "example3-output.png");

///* destroy the project, which will in turn destroy all child images */
//gerbv_destroy_project(mainProject)