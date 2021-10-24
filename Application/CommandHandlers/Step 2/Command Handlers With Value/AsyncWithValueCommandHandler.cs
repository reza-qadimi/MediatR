namespace Api.CommandHandlers.Step2
{
	/// <summary>
	/// Command Handler - With Value - Async
	/// </summary>
	public class AsyncWithValueCommandHandler : object, MediatR.IRequestHandler
		<Commands.Step2.AsyncWithValueCommand, FluentResults.Result<string>>
	{
		public AsyncWithValueCommandHandler() : base()
		{
		}

		public async
			System.Threading.Tasks.Task
			<FluentResults.Result<string>>
			Handle
			(Commands.Step2.AsyncWithValueCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
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

			return result;
		}
	}
}
