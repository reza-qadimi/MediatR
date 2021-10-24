namespace Api.CommandHandlers.Step2
{
	/// <summary>
	/// Command Handler - Without Value - Sync
	/// </summary>
	public class SyncWithoutValueCommandHandler :
		MediatR.RequestHandler<Commands.Step2.SyncWithoutValueCommand, FluentResults.Result>
	{
		public SyncWithoutValueCommandHandler() : base()
		{
		}

		protected override
			FluentResults.Result Handle
			(Commands.Step2.SyncWithoutValueCommand request)
		{
			var result =
				new FluentResults.Result();

			string message = request.Message;

			if (string.IsNullOrWhiteSpace(value: message) is false)
			{
				message = message.ToUpper();
			}

			string successMessage =
				 "Your Command Handled Correctly!";

			result.WithSuccess
				(successMessage: successMessage);

			System.Console.WriteLine(value: message);

			System.Diagnostics.Debug.WriteLine(value: message);

			return result;
		}
	}
}
