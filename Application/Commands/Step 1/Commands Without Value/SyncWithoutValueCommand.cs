namespace Api.Commands.Step1
{
	/// <summary>
	/// Command - Without Value - Sync
	/// </summary>
	public class SyncWithoutValueCommand : object, MediatR.IRequest
	{
		public SyncWithoutValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
