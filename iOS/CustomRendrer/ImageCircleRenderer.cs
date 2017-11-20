using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Todo;
using Todo.iOS;
[assembly: ExportRenderer(typeof(Todo.ImageCircle), typeof(ImageCircleRenderer))]
namespace Todo.iOS
{
	public class ImageCircleRenderer : ImageRenderer
	{
		public ImageCircleRenderer()
		{

		}
		private void CreateCircle()
			{
				try
				{
					double min = Math.Min(Element.Width, Element.Height);
					Control.Layer.CornerRadius = (float)(min / 2.0);
					Control.Layer.MasksToBounds = false;
					Control.Layer.BorderColor = Color.White.ToCGColor();
					Control.Layer.BorderWidth = 3;
					Control.ClipsToBounds = true;
				}
				catch (Exception ex)
				{
				Debug.WriteLine("Unable to create circle image: " + ex);
			    }
			}



	
	}
}

