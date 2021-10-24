namespace Api.Commands.Step2
{
	/// <summary>
	/// Command - With Value - Sync
	/// </summary>
	public class SyncWithValueCommand : object, MediatR.IRequest<FluentResults.Result<string>>
	{
		public SyncWithValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
