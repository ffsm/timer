// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Timer
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSpeak { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblReps { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lxlSets { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel txtReps { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel txtSets { get; set; }

		[Action ("Clicked:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Clicked (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSpeak != null) {
				btnSpeak.Dispose ();
				btnSpeak = null;
			}
			if (lblReps != null) {
				lblReps.Dispose ();
				lblReps = null;
			}
			if (lxlSets != null) {
				lxlSets.Dispose ();
				lxlSets = null;
			}
			if (txtReps != null) {
				txtReps.Dispose ();
				txtReps = null;
			}
			if (txtSets != null) {
				txtSets.Dispose ();
				txtSets = null;
			}
		}
	}
}
