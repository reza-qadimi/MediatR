using Dtat.Results;

namespace Api.CommandHandlers.Step4
{
	/// <summary>
	/// Command Handler - With Value - Async
	/// </summary>
	public class AsyncWithValueCommandHandler : object, MediatR.IRequestHandler
		<Commands.Step4.AsyncWithValueCommand, Dtat.Results.Result<string>>
	{
		public AsyncWithValueCommandHandler() : base()
		{
		}

		public async
			System.Threading.Tasks.Task
			<Dtat.Results.Result<string>>
			Handle
			(Commands.Step4.AsyncWithValueCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result<string>();

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

					result.WithValue(value: message);

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
