namespace Api.Commands.Step4
{
	/// <summary>
	/// Command - With Value - Async
	/// </summary>
	public class AsyncWithValueCommand : object, MediatR.IRequest<Dtat.Results.Result<string>>
	{
		public AsyncWithValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
