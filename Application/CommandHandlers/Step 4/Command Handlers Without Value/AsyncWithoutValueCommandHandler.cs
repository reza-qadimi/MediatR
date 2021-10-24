using Dtat.Results;

namespace Api.CommandHandlers.Step4
{
	/// <summary>
	/// Command Handler - Without Value - Async
	/// </summary>
	public class AsyncWithoutValueCommandHandler : object,
		MediatR.IRequestHandler<Commands.Step4.AsyncWithoutValueCommand, Dtat.Results.Result>
	{
		public AsyncWithoutValueCommandHandler() : base()
		{
		}

		public async
			System.Threading.Tasks.Task<Dtat.Results.Result>
			Handle
			(Commands.Step4.AsyncWithoutValueCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
			var result = new FluentResults.Result();

			try
			{
				//throw new System.Exception();

				await System.Threading.Tasks.Task.Run(() =>
				{
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

				}, cancellationToken: cancellationToken);
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
