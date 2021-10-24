namespace Api.CommandHandlers.Step1
{
	/// <summary>
	/// Command Handler - With Value - Async
	/// </summary>
	public class AsyncWithValueCommandHandler :
		object, MediatR.IRequestHandler<Commands.Step1.AsyncWithValueCommand, string>
	{
		public AsyncWithValueCommandHandler() : base()
		{
		}

		public async
			System.Threading.Tasks.Task<string>
			Handle
			(Commands.Step1.AsyncWithValueCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
			string message = null;

			await System.Threading.Tasks.Task.Run(() =>
			{
				message = request.Message;

				if (string.IsNullOrWhiteSpace(value: message) is false)
				{
					message = message.ToUpper();
				}

				System.Console.WriteLine(value: message);

				System.Diagnostics.Debug.WriteLine(value: message);

			}, cancellationToken: cancellationToken);

			return message;
		}
	}
}
