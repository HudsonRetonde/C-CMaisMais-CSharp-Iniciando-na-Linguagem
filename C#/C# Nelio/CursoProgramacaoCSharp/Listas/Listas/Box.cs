using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
	class Box
	{
		public int length;
		public int heigth;
		public int width;
		public int volume;

		public void DisplauInfo()
		{
			Console.WriteLine($"O cumprimento é {heigth}, a largura é {width}, a altura é {heigth} e o volume é {volume}");
		}
	}
}
