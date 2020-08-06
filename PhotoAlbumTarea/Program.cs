using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstAlbum = new PhotoAlbum();
            var secoundAlbum = new PhotoAlbum(24);
            var thirdAlbum = new BigPhotoAlbum();

            Console.WriteLine(firstAlbum.GetNumberOfPages().ToString());
            Console.WriteLine(secoundAlbum.GetNumberOfPages().ToString());
            Console.WriteLine(thirdAlbum.GetNumberOfPages().ToString());

            Console.ReadLine();
        }
    }
}
