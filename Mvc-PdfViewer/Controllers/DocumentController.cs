using Mvc_PdfViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_PdfViewer.Controllers
{
    public class DocumentController : Controller
    {
        // GET: Document
        public ActionResult Viewer(HttpPostedFileBase Doc)
        {
            if (Doc!=null)
            {
                var path = Get.GetFilePath("UploadFilePath") + "/Document/";
                ViewBag.DocUrl = Get.SaveDocument(Doc, path);
            }
           
            return View();
        }
    }
}