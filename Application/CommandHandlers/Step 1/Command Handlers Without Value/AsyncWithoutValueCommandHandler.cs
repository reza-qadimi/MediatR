namespace Api.CommandHandlers.Step1
{
	/// <summary>
	/// Command Handler - Without Value - Async
	/// </summary>
	public class AsyncWithoutValueCommandHandler :
		object, MediatR.IRequestHandler<Commands.Step1.AsyncWithoutValueCommand>
	{
		public AsyncWithoutValueCommandHandler() : base()
		{
		}

		public async
			System.Threading.Tasks.Task<MediatR.Unit>
			Handle
			(Commands.Step1.AsyncWithoutValueCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
			await System.Threading.Tasks.Task.Run(() =>
			{
				string message = request.Message;

				if (string.IsNullOrWhiteSpace(value: message) is false)
				{
					message = message.ToUpper();
				}

				System.Console.WriteLine(value: message);

				System.Diagnostics.Debug.WriteLine(value: message);

			}, cancellationToken: cancellationToken);

			// When you do not have any output, you should use MediatR.Unit!
			return new MediatR.Unit();
		}
	}
}
