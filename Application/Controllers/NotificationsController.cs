namespace Api.Controllers
{
	public class NotificationsController : Utilities.Base.ControllerBase
	{
		public NotificationsController(MediatR.IMediator mediator) : base(mediator: mediator)
		{
		}

		#region Notification(s)
		[Microsoft.AspNetCore.Mvc.HttpGet(template: "Notification")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<string>> Notification()
		{
			var request =
				new Notifications.Notification
				{
					Message =
						"Notification - Always Without Return Value - Async",
				};

			await Mediator.Publish(notification: request);

			return Ok(value: "OK");
		}
		#endregion /Notification(s)
	}
}
