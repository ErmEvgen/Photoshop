using System;

namespace MyPhotoshop
{
	public class GrayscaleFilter : IFilter
	{
		public ParameterInfo[] GetParameters()
		{
			return new ParameterInfo[0];
	
		}
		
		public override string ToString ()
		{
			return "Оттенки серого";
		}
		
		public Photo Process(Photo original, double[] parameters)
		{
			var result = new Photo(original.width, original.height);
			
			for (int x=0;x<result.width;x++)
				for (int y=0;y<result.height;y++)
				{

					result[x, y] = ProcessPixel(original[x, y], parameters);
				}
					
			return result;
		}
		public Pixel ProcessPixel(Pixel original, double[] parameters)
		{
			var lithness = original.R + original.G + original.B;
			lithness /= 3;
			return new Pixel (lithness, lithness, lithness);
		}
	}
}

