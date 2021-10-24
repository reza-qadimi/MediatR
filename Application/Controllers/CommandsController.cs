namespace Api.Controllers
{
	public class CommandsController : Utilities.Base.ControllerBase
	{
		public CommandsController(MediatR.IMediator mediator) : base(mediator: mediator)
		{
		}

		#region Command(s)

		#region Step 1
		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step1/SyncWithoutValueCommand")]
		public
			Microsoft.AspNetCore.Mvc.ActionResult
			<string> SyncWithoutValueCommandStep1()
		{
			var request =
				new Commands.Step1.SyncWithoutValueCommand
				{
					Message =
						"Command - Without Value - Sync",
				};

			Mediator.Send(request: request);

			return Ok(value: "OK");
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step1/AsyncWithoutValueCommand")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult
			<string>> AsyncWithoutValueCommandStep1()
		{
			var request =
				new Commands.Step1.AsyncWithoutValueCommand
				{
					Message =
						"Command - Without Value - Async",
				};

			await Mediator.Send(request: request);

			return Ok(value: "OK");
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step1/SyncWithValueCommand")]
		public
			Microsoft.AspNetCore.Mvc.ActionResult
			<string> SyncWithValueCommandStep1()
		{
			var request =
				new Commands.Step1.SyncWithValueCommand
				{
					Message =
						"Command - With Value - Sync",
				};

			string result =
				Mediator.Send(request: request).Result;

			//var result =
			//	Mediator.Send<string>(request: request).Result;

			return Ok(value: result);
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step1/AsyncWithValueCommand")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult
			<string>> AsyncWithValueCommandStep1()
		{
			var request =
				new Commands.Step1.AsyncWithValueCommand
				{
					Message =
						"Command - With Value - Async",
				};

			string result =
				await Mediator.Send(request: request);

			//string result =
			//	await Mediator.Send<string>(request: request);

			return Ok(value: result);
		}
		#endregion /Step 1

		#region Step 2
		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step2/SyncWithoutValueCommand")]
		public
			Microsoft.AspNetCore.Mvc.ActionResult<string>
			SyncWithoutValueCommandStep2()
		{
			var request =
				new Commands.Step2.SyncWithoutValueCommand
				{
					Message =
						"Command - Without Value - Sync",
				};

			Mediator.Send(request: request);

			return Ok(value: "OK");
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step2/AsyncWithoutValueCommand")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<string>>
			AsyncWithoutValueCommandStep2()
		{
			var request =
				new Commands.Step2.AsyncWithoutValueCommand
				{
					Message =
						"Command - Without Value - Async",
				};

			await Mediator.Send(request: request);

			return Ok(value: "OK");
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step2/SyncWithValueCommand")]
		public
			Microsoft.AspNetCore.Mvc.ActionResult
			<FluentResults.Result<string>> SyncWithValueCommandStep2()
		{
			var request =
				new Commands.Step2.SyncWithValueCommand
				{
					Message =
						"Command - With Value - Sync",
				};

			var result =
				Mediator.Send(request: request).Result;

			//var result =
			//	Mediator.Send<string>(request: request).Result;

			return Ok(value: result);
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step2/AsyncWithValueCommand")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult
			<FluentResults.Result<string>>> AsyncWithValueCommandStep2()
		{
			var request =
				new Commands.Step2.AsyncWithValueCommand
				{
					Message =
						"Command - With Value - Async",
				};

			var result =
				await Mediator.Send(request: request);

			//string result =
			//	await Mediator.Send<string>(request: request);

			return Ok(value: result);
		}
		#endregion /Step 2

		#region Step 3
		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step3/SyncWithoutValueCommand")]
		public
			Microsoft.AspNetCore.Mvc.ActionResult<string>
			SyncWithoutValueCommandStep3()
		{
			var request =
				new Commands.Step3.SyncWithoutValueCommand
				{
					Message =
						"Command - Without Value - Sync",
				};

			Mediator.Send(request: request);

			return Ok(value: "OK");
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step3/AsyncWithoutValueCommand")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<string>>
			AsyncWithoutValueCommandStep3()
		{
			var request =
				new Commands.Step3.AsyncWithoutValueCommand
				{
					Message =
						"Command - Without Value - Async",
				};

			await Mediator.Send(request: request);

			return Ok(value: "OK");
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step3/SyncWithValueCommand")]
		public
			Microsoft.AspNetCore.Mvc.ActionResult
			<Dtat.Results.Result<string>> SyncWithValueCommandStep3()
		{
			var request =
				new Commands.Step3.SyncWithValueCommand
				{
					Message =
						"Command - With Value - Sync",
				};

			var result =
				Mediator.Send(request: request).Result;

			//var result =
			//	Mediator.Send<string>(request: request).Result;

			return Ok(value: result);
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step3/AsyncWithValueCommand")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult
			<Dtat.Results.Result<string>>> AsyncWithValueCommandStep3()
		{
			var request =
				new Commands.Step3.AsyncWithValueCommand
				{
					Message =
						"Command - With Value - Async",
				};

			var result =
				await Mediator.Send(request: request);

			//string result =
			//	await Mediator.Send<string>(request: request);

			return Ok(value: result);
		}
		#endregion /Step 3

		#region Step 4
		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step4/SyncWithoutValueCommand")]
		public
			Microsoft.AspNetCore.Mvc.ActionResult<string>
			SyncWithoutValueCommandStep4()
		{
			var request =
				new Commands.Step4.SyncWithoutValueCommand
				{
					Message =
						"Command - Without Value - Sync",
				};

			var result =
				Mediator.Send(request: request);

			return Ok(value: "OK");
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step4/AsyncWithoutValueCommand")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult<string>>
			AsyncWithoutValueCommandStep4()
		{
			var request =
				new Commands.Step4.AsyncWithoutValueCommand
				{
					Message =
						"Command - Without Value - Async",
				};

			await Mediator.Send(request: request);

			return Ok(value: "OK");
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step4/SyncWithValueCommand")]
		public
			Microsoft.AspNetCore.Mvc.ActionResult
			<Dtat.Results.Result<string>> SyncWithValueCommandStep4()
		{
			var request =
				new Commands.Step4.SyncWithValueCommand
				{
					Message =
						"Command - With Value - Sync",
				};

			var result =
				Mediator.Send(request: request).Result;

			//var result =
			//	Mediator.Send<string>(request: request).Result;

			return Ok(value: result);
		}

		[Microsoft.AspNetCore.Mvc.HttpGet
			(template: "Step4/AsyncWithValueCommand")]
		public
			async
			System.Threading.Tasks.Task
			<Microsoft.AspNetCore.Mvc.ActionResult
			<Dtat.Results.Result<string>>> AsyncWithValueCommandStep4()
		{
			var request =
				new Commands.Step4.AsyncWithValueCommand
				{
					Message =
						"Command - With Value - Async",
				};

			var result =
				await Mediator.Send(request: request);

			//string result =
			//	await Mediator.Send<string>(request: request);

			return Ok(value: result);
		}
		#endregion /Step 4

		#endregion /Command(s)
	}
}
