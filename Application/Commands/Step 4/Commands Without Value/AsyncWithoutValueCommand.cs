namespace Api.Commands.Step4
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
