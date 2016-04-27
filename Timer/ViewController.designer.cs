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
		UIView MainView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView TimerTableView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView txtSpeech { get; set; }

		[Action ("BtnSpeak_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void BtnSpeak_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnSpeak != null) {
				btnSpeak.Dispose ();
				btnSpeak = null;
			}
			if (MainView != null) {
				MainView.Dispose ();
				MainView = null;
			}
			if (TimerTableView != null) {
				TimerTableView.Dispose ();
				TimerTableView = null;
			}
			if (txtSpeech != null) {
				txtSpeech.Dispose ();
				txtSpeech = null;
			}
		}
	}
}
