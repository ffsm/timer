using System;
using Timer.Controllers;
using Timer.Models;

using UIKit;

namespace Timer
{
	public partial class ViewController : UIViewController
	{
		public TimerController Timer {
			get;
			set;
		}
			
		public ViewController (IntPtr handle) : base (handle)
		{
			this.Timer = new TimerController ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			this.TimerTableView.Source = new TimerTableViewSource (
				new string[]{ "Reps", "Sets", "Prepare", "Rest" },
				this.Timer);

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void BtnSpeak_TouchUpInside (UIButton sender)
		{
			this.Timer.Speak(txtSpeech.Text);
		}
	}
}

