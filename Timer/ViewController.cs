using System;
using Timer.Controllers;
using Timer.Models;

using UIKit;
using AVFoundation;

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

			this.txtReps.Text = this.Timer.Exercise.Reps.ToString ();
			this.txtSets.Text = this.Timer.Exercise.Sets.ToString ();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void Clicked (UIButton sender)
		{
			
			var speechSynthesizer = new AVSpeechSynthesizer ();

			var speechUtterance = new AVSpeechUtterance ("O pipo era legal?"){
				Voice = AVSpeechSynthesisVoice.FromLanguage ("pt-BR"),
			};

			speechSynthesizer.SpeakUtterance (speechUtterance);
		}
	}
}

