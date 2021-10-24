namespace Api.Commands.Step1
{
	/// <summary>
	/// Command - With Value - Sync
	/// </summary>
	public class SyncWithValueCommand : object, MediatR.IRequest<string>
	{
		public SyncWithValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
