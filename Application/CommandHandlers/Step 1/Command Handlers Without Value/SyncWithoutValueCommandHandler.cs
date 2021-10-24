namespace Api.CommandHandlers.Step1
{
	/// <summary>
	/// Command Handler - Without Value - Sync
	/// </summary>
	public class SyncWithoutValueCommandHandler :
		MediatR.RequestHandler<Commands.Step1.SyncWithoutValueCommand>
	{
		public SyncWithoutValueCommandHandler() : base()
		{
		}

		protected override
			void Handle
			(Commands.Step1.SyncWithoutValueCommand request)
		{
			string message = request.Message;

			if (string.IsNullOrWhiteSpace(value: message) is false)
			{
				message = message.ToUpper();
			}

			System.Console.WriteLine(value: message);

			System.Diagnostics.Debug.WriteLine(value: message);
		}
	}
}
