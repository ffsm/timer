using System;
using UIKit;

namespace Timer
{
	public class TimerTableViewSource : UITableViewSource
	{
		string[] tableItems;
		string cellIdentifier = "TableCell";
		Timer.Controllers.TimerController timer;


		public TimerTableViewSource (string[] items, Controllers.TimerController currentTimer)
		{
			this.timer = currentTimer;
			tableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			string cellTitle = tableItems [indexPath.Row];
			string textToSpeech = "{0} is at {1}.";

			switch (cellTitle) {

			case "Reps":
				textToSpeech = string.Format(textToSpeech, 
					this.tableItems[indexPath.Row],
					this.timer.Exercise.Reps);
				break;
			case "Sets":
				textToSpeech = string.Format(textToSpeech, 
					this.tableItems[indexPath.Row],
					this.timer.Exercise.Sets);
				break;
			case "Prepare":
				textToSpeech = string.Format(textToSpeech, 
					this.tableItems[indexPath.Row],
					this.timer.Exercise.Prepare);				
				break;
			case "Rest":
				textToSpeech = string.Format(textToSpeech, 
					this.tableItems[indexPath.Row],
					this.timer.Exercise.Rest);				
				break;
			}

			this.timer.Speak(textToSpeech);
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);

			string cellTitle = tableItems [indexPath.Row];

			switch (cellTitle) {

			case "Reps":
				cell.TextLabel.Text = string.Format ("{0}: {1}", cellTitle, this.timer.Exercise.Reps);
				break;
			case "Sets":
				cell.TextLabel.Text = string.Format ("{0}: {1}", cellTitle, this.timer.Exercise.Sets);
				break;
			case "Prepare":
				cell.TextLabel.Text = string.Format ("{0}: {1} (s)", cellTitle, this.timer.Exercise.Prepare);
				break;
			case "Rest":
				cell.TextLabel.Text = string.Format ("{0}: {1} (s)", cellTitle, this.timer.Exercise.Rest);	
				break;
			}


			return cell;

		}
	}
}

