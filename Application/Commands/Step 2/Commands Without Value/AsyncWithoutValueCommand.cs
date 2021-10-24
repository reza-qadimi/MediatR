namespace Api.Commands.Step2
{
	/// <summary>
	/// Command - Without Value - Async
	/// </summary>
	public class AsyncWithoutValueCommand : object, MediatR.IRequest<FluentResults.Result>
	{
		public AsyncWithoutValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
