using Dtat.Results;

namespace Api.CommandHandlers.Step3
{
	/// <summary>
	/// Command Handler - With Value - Async
	/// </summary>
	public class AsyncWithValueCommandHandler : object, MediatR.IRequestHandler
		<Commands.Step3.AsyncWithValueCommand, Dtat.Results.Result<string>>
	{
		public AsyncWithValueCommandHandler() : base()
		{
		}

		public
			async
			System.Threading.Tasks.Task
			<Dtat.Results.Result<string>>
			Handle
			(Commands.Step3.AsyncWithValueCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
			//throw new System.Exception();

			var result =
				new FluentResults.Result<string>();

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

			return result.ConvertToDtatResult();
		}
	}
}
