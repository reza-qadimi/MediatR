namespace Api.CommandHandlers.Step2
{
	/// <summary>
	/// Command Handler - With Value - Sync
	/// </summary>
	public class SyncWithValueCommandHandler :
		MediatR.RequestHandler<Commands.Step2.SyncWithValueCommand, FluentResults.Result<string>>
	{
		public SyncWithValueCommandHandler() : base()
		{
		}

		protected
			override
			FluentResults.Result<string> Handle
			(Commands.Step2.SyncWithValueCommand request)
		{
			var result =
				new FluentResults.Result<string>();

			string message = request.Message;

			if (string.IsNullOrWhiteSpace(value: message) is false)
			{
				message = message.ToUpper();
			}

			result.WithValue(value: message);

			string successMessage =
				 "Your Command Handled Correctly!";

			result.WithSuccess
				(successMessage: successMessage);

			System.Console.WriteLine(value: message);

			System.Diagnostics.Debug.WriteLine(value: message);

			result.WithValue(value: message);

			return result;
		}
	}
}
