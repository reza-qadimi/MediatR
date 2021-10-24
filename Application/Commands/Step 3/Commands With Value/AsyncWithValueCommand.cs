namespace Api.Commands.Step3
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
