namespace Api.Commands.Step2
{
	/// <summary>
	/// Command - With Value - Async
	/// </summary>
	public class AsyncWithValueCommand : object, MediatR.IRequest<FluentResults.Result<string>>
	{
		public AsyncWithValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
