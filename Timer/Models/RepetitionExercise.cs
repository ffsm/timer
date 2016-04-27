using System;

namespace Timer.Models
{
	public class RepetitionExercise
	{
		public RepetitionExercise ()
		{
		}

		#region Properties

		public string Name{
			get;
			set;
		}

		public int Reps {
			get;
			set;
		}

		public int Sets {
			get;
			set;
		}

		public int RPM {
			get;
			set;
		}

		public int Rest {
			get;
			set;
		}

		public int Prepare {
			get;
			set;
		}

		#endregion
	}
}

