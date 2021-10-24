namespace Api.Commands.Step4
{
	/// <summary>
	/// Command - Without Value - Sync
	/// </summary>
	public class SyncWithoutValueCommand : object, MediatR.IRequest<Dtat.Results.Result>
	{
		public SyncWithoutValueCommand() : base()
		{
		}

		public string Message { get; set; }
	}
}
