namespace Api.Commands.Step3
{
	/// <summary>
	/// Command - Without Value - Async
	/// </summary>
	public class AsyncWithoutValueCommand : object, MediatR.IRequest<Dtat.Results.Result>
	{
		public AsyncWithoutValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
