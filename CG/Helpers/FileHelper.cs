using FFMpegCore.Pipes;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using SkiaSharp;
using System.Text.Encodings.Web;
using CG.Areas.adm.Models;

namespace CG.Helpers
{
    public class FileHelper
    {
        public static HtmlString FileInlineLink(IHtmlHelper html, string filename, string action, string controller, object routeValues, object htmlAttributes, bool publicAccess = false)
        {
            var routeValueDictionary = new RouteValueDictionary(routeValues);
            routeValueDictionary["filename"] = filename;
            var htmlAttributesDictionary = Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            htmlAttributesDictionary["target"] = "_blank";
            var res = html.ActionLink(filename.Replace("_", " "), action, controller, routeValueDictionary, htmlAttributesDictionary);
            return new HtmlString(GetString(res));            
        }
        public static IEnumerable<UploadedFileInfo> GetFilesFromRequest(HttpRequest httpRequest)
        {
            if (httpRequest?.Form.Files.Count > 0)
            {
                List<IFormFile> fileCollection = httpRequest.Form.Files.ToList();
                for (int j = 0; j < fileCollection.Count; j++)
                {
                    IFormFile uploadedFile = fileCollection[j];
                    string fileName;

                    //if (httpRequest.Browser.Browser.ToUpper() == "IE" || httpRequest.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                    //{
                    //    string[] testfiles = uploadedFile.FileName.Split(new char[] { '\\' });
                    //    fileName = testfiles[testfiles.Length - 1];
                    //}
                    //else
                    //{
                    fileName = uploadedFile.FileName;
                    //}


                    byte[] fileContent = new byte[uploadedFile.Length];
                    Stream stream = uploadedFile.OpenReadStream();
                    stream.Position = 0;
                    stream.Read(fileContent, 0, fileContent.Length);

                    stream.Position = 0;

                    UploadedFileInfo uploadedFileInfo = new UploadedFileInfo();
                    uploadedFileInfo.File = uploadedFile;
                    uploadedFileInfo.FilePath = fileName;
                    uploadedFileInfo.FileName = Path.GetFileName(fileName);
                    uploadedFileInfo.FileExtension = Path.GetExtension(fileName);
                    uploadedFileInfo.FileContentType = uploadedFile.ContentType;
                    uploadedFileInfo.FileContentLength = uploadedFile.Length;
                    uploadedFileInfo.FileContent = fileContent;

                    yield return uploadedFileInfo;
                }
            }
        }
        public static string GetString(IHtmlContent content)
        {
            using (var writer = new System.IO.StringWriter())
            {
                content.WriteTo(writer, HtmlEncoder.Default);
                return writer.ToString();
            }
        }
        public static IEnumerable<IVideoFrame> CreateFrames(int count, int width, int height, byte[] FileContent = null)
        {
            using SKFont textFont = new(SKTypeface.FromFamilyName("consolas"), size: 32);
            using SKPaint textPaint = new(textFont) { Color = SKColors.Yellow, TextAlign = SKTextAlign.Center };
            using SKPaint rectanglePaint = new() { Color = SKColors.Green, Style = SKPaintStyle.Fill };
            SKColor backgroundColor = SKColors.Navy;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\rRendering frame {i + 1} of {count}");
                using SKBitmap bmp = new(width, height);
                using SKCanvas canvas = new(bmp);
                canvas.Clear(backgroundColor);
                
                canvas.DrawRect(i, i, i * 2, i * 2, rectanglePaint);
                canvas.DrawText("SkiaSharp", bmp.Width / 2, bmp.Height * .4f, textPaint);
                canvas.DrawText($"Frame {i}", bmp.Width / 2, bmp.Height * .6f, textPaint);

                using SKBitmapFrame frame = new(bmp);
                yield return frame;
            }
        }
    }
}
