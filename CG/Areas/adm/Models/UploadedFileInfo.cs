namespace CG.Areas.adm.Models
{
    public class UploadedFileInfo
    {
        public IFormFile File { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FileContentType { get; set; }
        public long FileContentLength { get; set; }
        public byte[] FileContent { get; set; }
    }
}
