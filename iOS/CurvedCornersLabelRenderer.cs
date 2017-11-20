using System;
using Todo;
using Todo.iOS;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(CurvedCornersLabel), typeof(CurvedCornersLabelRenderer))]


namespace Todo.iOS
{
	public class CurvedCornersLabelRenderer:LabelRenderer
	{

			protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
				{
					base.OnElementChanged(e);

					if (e.NewElement != null)
					{
						var _xfViewReference = (CurvedCornersLabel)Element;
						this.Layer.CornerRadius = (float)_xfViewReference.CurvedCornerRadius;
						this.Layer.BackgroundColor = _xfViewReference.CurvedBackgroundColor.ToCGColor();   
					}
				}
	}
}
