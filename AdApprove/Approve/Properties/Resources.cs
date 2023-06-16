using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Approve.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;
		private static CultureInfo resourceCulture;
		
		internal Resources()
		{
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Approve.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}
		internal static Bitmap _checked
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("checked", Resources.resourceCulture);
			}
		}
		internal static Bitmap countdown
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("countdown", Resources.resourceCulture);
			}
		}
		internal static Bitmap dia
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("dia", Resources.resourceCulture);
			}
		}
		internal static Bitmap finish
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("finish", Resources.resourceCulture);
			}
		}
		internal static Bitmap i_cant_see_ad
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("i-cant-see-ad", Resources.resourceCulture);
			}
		}
		internal static Bitmap loading
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("loading", Resources.resourceCulture);
			}
		}
		internal static Bitmap now
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("now", Resources.resourceCulture);
			}
		}
		internal static Bitmap opening
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("opening", Resources.resourceCulture);
			}
		}
		internal static Bitmap opening_owl
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("opening_owl", Resources.resourceCulture);
			}
		}
		internal static Bitmap translate_16
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("translate-16", Resources.resourceCulture);
			}
		}
		internal static Bitmap waiting
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("waiting", Resources.resourceCulture);
			}
		}
		internal static Bitmap yt_mini
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("yt_mini", Resources.resourceCulture);
			}
		}
	}
}
