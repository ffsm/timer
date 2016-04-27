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
		UINavigationBar MainNavBar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIStepper RepsStepper { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableViewCell RepsViewCell { get; set; }

		[Action ("Clicked:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Clicked (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSpeak != null) {
				btnSpeak.Dispose ();
				btnSpeak = null;
			}
			if (MainNavBar != null) {
				MainNavBar.Dispose ();
				MainNavBar = null;
			}
			if (RepsStepper != null) {
				RepsStepper.Dispose ();
				RepsStepper = null;
			}
			if (RepsViewCell != null) {
				RepsViewCell.Dispose ();
				RepsViewCell = null;
			}
		}
	}
}
