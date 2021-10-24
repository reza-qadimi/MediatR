namespace Api.NotificationHandlers
{
	public class SecondNotificationHandler :
		object, MediatR.INotificationHandler<Notifications.Notification>
	{
		public SecondNotificationHandler() : base()
		{
		}

		public async
			System.Threading.Tasks.Task
			Handle
			(Notifications.Notification notification,
			System.Threading.CancellationToken cancellationToken)
		{
			await System.Threading.Tasks.Task.Run(() =>
			{
				string message = notification.Message;

				if (string.IsNullOrWhiteSpace(value: message) is false)
				{
					message = message.ToUpper();
				}

				message += $" - this is { ToString() }";

				System.Console.WriteLine(value: message);

				System.Diagnostics.Debug.WriteLine(value: message);

			}, cancellationToken: cancellationToken);
		}
	}
}
