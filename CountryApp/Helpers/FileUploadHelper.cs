namespace CountryApp.Helpers
{
    public static class FileUploadHelper
    {
        public static async Task<string> UploadAsync(IFormFile formFile)
        {
            if (formFile != null)
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(formFile.FileName)}";
                using FileStream fs = new(@$"wwwroot/upload/{fileName}", FileMode.Create);
                await formFile.CopyToAsync(fs);

                return @$"/upload/{fileName}";
            }

            throw new InvalidOperationException("File not uploaded");
        }
    }
}
