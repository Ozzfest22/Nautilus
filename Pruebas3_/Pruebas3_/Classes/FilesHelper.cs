using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Pruebas3_.Classes
{
    public class FilesHelper

    {
        public static string SubirFoto(HttpPostedFileBase file, string folder)
        {
            var ruta = string.Empty;
            var img = string.Empty;

            if (file != null)
            {
                img = Path.GetFileName(file.FileName);
                ruta = Path.Combine(HttpContext.Current.Server.MapPath(folder), img);
                file.SaveAs(ruta);
            }

            return img;
        }

    }
}