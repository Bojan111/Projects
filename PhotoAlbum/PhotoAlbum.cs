using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbumArea
{
	class PhotoAlbum
	{
		private int numberOfPages;

		public PhotoAlbum()
		{
			numberOfPages = 16;
		}
		public PhotoAlbum(int numberofpages)
		{
			numberOfPages = numberofpages;
		}

		public string GetTypeOfAlbum()
		{
			return "PhotoAlbum";
		}
		public int GetNumberOfPages()
		{
			return numberOfPages;
		}
	}
}
