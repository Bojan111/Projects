using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbumArea
{
	class BigPhotoAlbum
	{
		private int pagenumber;
		public BigPhotoAlbum()
		{
			pagenumber = 64;
		}
		public string TypeOfAlbum()
		{
			return "BigPhotoAlbum";
		}
		public int GetPhotoAlbum()
		{
			return pagenumber;
		}
	}
}
