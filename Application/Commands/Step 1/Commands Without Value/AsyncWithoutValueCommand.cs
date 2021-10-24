namespace Api.Commands.Step1
{
	/// <summary>
	/// Command - Without Value - Async
	/// </summary>
	public class AsyncWithoutValueCommand : object, MediatR.IRequest
	{
		public AsyncWithoutValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
