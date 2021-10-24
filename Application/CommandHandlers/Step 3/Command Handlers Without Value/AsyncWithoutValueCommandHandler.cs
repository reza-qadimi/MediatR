using Dtat.Results;

namespace Api.CommandHandlers.Step3
{
	/// <summary>
	/// Command Handler - Without Value - Async
	/// </summary>
	public class AsyncWithoutValueCommandHandler : object,
		MediatR.IRequestHandler<Commands.Step3.AsyncWithoutValueCommand, Dtat.Results.Result>
	{
		public AsyncWithoutValueCommandHandler() : base()
		{
		}

		public async
			System.Threading.Tasks.Task<Dtat.Results.Result>
			Handle
			(Commands.Step3.AsyncWithoutValueCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
			//throw new System.Exception();

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

			return result.ConvertToDtatResult();
		}
	}
}
