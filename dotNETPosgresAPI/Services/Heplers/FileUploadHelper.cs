namespace dotNETPosgresAPI.Services.Heplers
{
    public class FileUploadHelper
    {

        private readonly IWebHostEnvironment _env;

        public FileUploadHelper(IWebHostEnvironment env)
        {
            _env = env;
        }



        public bool ValidateFileExtention(IFormFile file)
        {
            string[] permittedExtensions = { ".png", ".jpg", ".jpeg" };
            if (file == null)
                return false;

            var ext = Path.GetExtension(file.FileName);
            if (String.IsNullOrEmpty(ext) || permittedExtensions.Contains(ext))
            {
                return true;
            }
            return false;
        }


        public bool ValidateFileSize(IFormFile file, int maxSize)
        {
            if (file == null)
                return false;

            int fileSize = Convert.ToInt32(Path.GetExtension(file.FileName.Length.ToString()));

            if (fileSize <= maxSize)
                return true;

            return false;
        }


        public string Processuploadedfile(IFormFile? file, string imgPath)
        {
            String? uniqueFileName = null;


            if (file == null)
            {
                return uniqueFileName = "default_profile_avatar.png";
            }

            string uploadeProfImg = Path.Combine(_env.WebRootPath, imgPath);
            uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            string FilePath = Path.Combine(uploadeProfImg, uniqueFileName);

            using (var stream = new FileStream(FilePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return uniqueFileName;
        }





    }
}
