using HW5ADD.Shapes;

namespace HW5ADD
{
    internal class PhotoBookTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
            Create a default photo book and show the number of pages
            Create a photo book with 24 pages and show the number of pages
            Create a large photo book and show the number of pages
            */
            PhotoBook photoBook1 = new PhotoBook();
            Console.WriteLine($"photoBook1 numbers of pages = {photoBook1.GetNumberPages()}");
            PhotoBook photoBook2 = new PhotoBook(24);
            Console.WriteLine($"photoBook2 numbers of pages = {photoBook2.GetNumberPages()}");
            BigPhotoBook bigPhotoBook1 = new BigPhotoBook();
            Console.WriteLine($"bigPhotoBook1 numbers of pages = {bigPhotoBook1.GetNumberPages()}");
            
        }
    }
}