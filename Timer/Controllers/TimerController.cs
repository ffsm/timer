using System;
using Timer.Models;

namespace Timer.Controllers
{
	public class TimerController
	{
		public TimerController ()
		{
			this.Exercise = new RepetitionExercise () {
				Reps = 10,
				Sets = 3,
				RPM = 30,
				Rest = 60,
				Prepare = 10
			};
		}

		public RepetitionExercise Exercise { get; private set; }
	}
}

