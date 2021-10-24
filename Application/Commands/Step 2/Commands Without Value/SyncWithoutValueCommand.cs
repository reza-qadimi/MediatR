namespace Api.Commands.Step2
{
	/// <summary>
	/// Command - Without Value - Sync
	/// </summary>
	public class SyncWithoutValueCommand : object, MediatR.IRequest<FluentResults.Result>
	{
		public SyncWithoutValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
