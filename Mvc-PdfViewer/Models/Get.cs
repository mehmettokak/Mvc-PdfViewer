using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Mvc_PdfViewer.Models
{
    public static class Get
    {
        public static string GetFilePath(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public static string SaveDocument(HttpPostedFileBase files, string folderPath)
        {
            try
            {
                if (!Directory.Exists(HttpContext.Current.Server.MapPath("~" + folderPath)))
                    Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~" + folderPath));

                var filePath = folderPath + files.FileName;
                if (File.Exists(HttpContext.Current.Server.MapPath("~" + filePath)))
                    File.Delete(HttpContext.Current.Server.MapPath("~" + filePath));

                files.SaveAs(HttpContext.Current.Server.MapPath("~" + filePath));
               
                return filePath;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}