namespace Api.CommandHandlers.Step2
{
	/// <summary>
	/// Command Handler - Without Value - Async
	/// </summary>
	public class AsyncWithoutValueCommandHandler : object,
		MediatR.IRequestHandler<Commands.Step2.AsyncWithoutValueCommand, FluentResults.Result>
	{
		public AsyncWithoutValueCommandHandler() : base()
		{
		}

		public async
			System.Threading.Tasks.Task<FluentResults.Result>
			Handle
			(Commands.Step2.AsyncWithoutValueCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
			var result = new FluentResults.Result();

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

			return result;
		}
	}
}
