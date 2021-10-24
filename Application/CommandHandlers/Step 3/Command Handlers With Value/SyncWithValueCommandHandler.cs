using Dtat.Results;

namespace Api.CommandHandlers.Step3
{
	/// <summary>
	/// Command Handler - With Value - Sync
	/// </summary>
	public class SyncWithValueCommandHandler : MediatR.RequestHandler
		<Commands.Step3.SyncWithValueCommand, Dtat.Results.Result<string>>
	{
		public SyncWithValueCommandHandler() : base()
		{
		}

		protected override
			Dtat.Results.Result<string>
			Handle
			(Commands.Step3.SyncWithValueCommand request)
		{
			//throw new System.Exception();

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

			return result.ConvertToDtatResult();
		}
	}
}
