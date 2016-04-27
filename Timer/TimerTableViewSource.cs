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

			this.timer.Speak(string.Format("{0} is at {1}.", 
				cellTitle,
				this.timer.Exercise.GetType().GetProperty(cellTitle).GetValue(this.timer.Exercise)));
		}

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);

			string cellTitle = tableItems [indexPath.Row];

			cell.TextLabel.Text = string.Format ("{0}: {1}", 
				cellTitle,
				this.timer.Exercise.GetType().GetProperty(cellTitle).GetValue(this.timer.Exercise));

			return cell;

		}
	}
}

