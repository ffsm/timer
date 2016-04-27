using System;
using Timer.Models;
using AVFoundation;

namespace Timer.Controllers
{
	public class TimerController
	{
		public TimerController ()
		{
			this.speechSynthesizer = new AVSpeechSynthesizer ();
			//this.speechVoice = AVSpeechSynthesisVoice.FromLanguage ("pt-BR");

			this.Exercise = new RepetitionExercise () {
				Reps = 10,
				Sets = 3,
				RPM = 30,
				Rest = 60,
				Prepare = 10
			};
		}

		//private AVSpeechSynthesisVoice speechVoice { get; set; }
		private AVSpeechSynthesizer speechSynthesizer { get; set; }
		//private AVSpeechUtterance speechUtterance { get; set; }

		public RepetitionExercise Exercise { get; private set; }

		public void Speak(string text)
		{
			this.speechSynthesizer.SpeakUtterance (
				new AVSpeechUtterance (text)
				{
					Rate = AVSpeechUtterance.MaximumSpeechRate / 3
				});
		}
	}
}

