using Dtat.Results;

namespace Api.CommandHandlers.Step4
{
	/// <summary>
	/// Command Handler - With Value - Sync
	/// </summary>
	public class SyncWithValueCommandHandler : MediatR.RequestHandler
		<Commands.Step4.SyncWithValueCommand, Dtat.Results.Result<string>>
	{
		public SyncWithValueCommandHandler() : base()
		{
		}

		protected override
			Dtat.Results.Result<string>
			Handle
			(Commands.Step4.SyncWithValueCommand request)
		{
			var result =
				new FluentResults.Result<string>();

			try
			{
				//throw new System.Exception();

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
			}
			catch (System.Exception ex)
			{
				//Log Error...

				System.Console.WriteLine(value: ex.Message);

				System.Diagnostics.Debug.WriteLine(value: ex.Message);

				string errorMessage =
					"Unexpected error has occurred, please contact administrator...";

				result.WithError(errorMessage: errorMessage);
			}

			return result.ConvertToDtatResult();
		}
	}
}
