namespace Api.Commands.Step1
{
	/// <summary>
	/// Command - With Value - Async
	/// </summary>
	public class AsyncWithValueCommand : object, MediatR.IRequest<string>
	{
		public AsyncWithValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
