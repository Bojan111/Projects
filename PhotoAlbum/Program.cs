using System;

namespace PhotoAlbumArea
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Vnesi broj na stranici");
			var a = int.Parse(Console.ReadLine());
			var page = new PhotoAlbum(a);
			var page2 = new PhotoAlbum();
			Console.WriteLine($"Vneseni se broj {page.GetNumberOfPages()} na stranici, od tip {page.GetTypeOfAlbum()}");
			Console.WriteLine($"Standarden broj  {page2.GetNumberOfPages()} na stranici, od tip {page2.GetTypeOfAlbum()}");

			var page3 = new BigPhotoAlbum();
			Console.WriteLine($"Standaredn broj {page3.GetPhotoAlbum()}, od tip {page3.TypeOfAlbum()} ");
		}
	}
}
