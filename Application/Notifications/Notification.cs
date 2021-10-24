namespace Api.Notifications
{
	public class Notification : object, MediatR.INotification
	{
		public Notification() : base()
		{
		}

		public string Message { get; set; }
	}
}
