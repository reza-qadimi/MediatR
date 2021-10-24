namespace Api.CommandHandlers.Step1
{
	/// <summary>
	/// Command Handler - With Value - Sync
	/// </summary>
	public class SyncWithValueCommandHandler :
		MediatR.RequestHandler<Commands.Step1.SyncWithValueCommand, string>
	{
		public SyncWithValueCommandHandler() : base()
		{
		}

		protected override
			string Handle
			(Commands.Step1.SyncWithValueCommand request)
		{
			string message = request.Message;

			if (string.IsNullOrWhiteSpace(value: message) is false)
			{
				message = message.ToUpper();
			}

			System.Console.WriteLine(value: message);

			System.Diagnostics.Debug.WriteLine(value: message);

			return message;
		}
	}
}
