using Dtat.Results;

namespace Api.CommandHandlers.Step4
{
	/// <summary>
	/// Command Handler - Without Value - Sync
	/// </summary>
	public class SyncWithoutValueCommandHandler :
		MediatR.RequestHandler<Commands.Step4.SyncWithoutValueCommand, Dtat.Results.Result>
	{
		public SyncWithoutValueCommandHandler() : base()
		{
		}

		protected override
			Dtat.Results.Result Handle
			(Commands.Step4.SyncWithoutValueCommand request)
		{
			var result =
				new FluentResults.Result();

			try
			{
				//throw new System.Exception();

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
