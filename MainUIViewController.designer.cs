// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace NiftyAppz.Proto
{
	[Register ("MainUIViewController")]
	partial class MainUIViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField PCurrency { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField RCurrency { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (PCurrency != null) {
				PCurrency.Dispose ();
				PCurrency = null;
			}

			if (RCurrency != null) {
				RCurrency.Dispose ();
				RCurrency = null;
			}
		}
	}
}
