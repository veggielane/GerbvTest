﻿using GerberWrapper;
var mainProject = Gerbv.gerbv_create_project();
Gerbv.gerbv_open_layer_from_filename(mainProject, "dvk-mx8m-bsb-F_Mask.gbr");
Gerbv.gerbv_export_svg_file_from_project_autoscaled(mainProject, "output.svg");
Gerbv.gerbv_destroy_project(mainProject);