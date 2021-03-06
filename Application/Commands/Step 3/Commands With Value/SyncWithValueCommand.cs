namespace Api.Commands.Step3
{
	/// <summary>
	/// Command - With Value - Sync
	/// </summary>
	public class SyncWithValueCommand : object, MediatR.IRequest<Dtat.Results.Result<string>>
	{
		public SyncWithValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
