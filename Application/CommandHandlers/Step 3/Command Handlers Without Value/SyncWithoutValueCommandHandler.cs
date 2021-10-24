using Dtat.Results;

namespace Api.CommandHandlers.Step3
{
	/// <summary>
	/// Command Handler - Without Value - Sync
	/// </summary>
	public class SyncWithoutValueCommandHandler :
		MediatR.RequestHandler<Commands.Step3.SyncWithoutValueCommand, Dtat.Results.Result>
	{
		public SyncWithoutValueCommandHandler() : base()
		{
		}

		protected override
			Dtat.Results.Result Handle
			(Commands.Step3.SyncWithoutValueCommand request)
		{
			//throw new System.Exception();

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

			return result.ConvertToDtatResult();
		}
	}
}
