using Microsoft.AspNetCore.Mvc;
using OnlineShop.Services;

namespace OnlineShop.Controllers
{
	[ApiController]
	[Route("users")]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		public IActionResult GetAll(string id)
		{
			
			var result = _userService.GetAll();
			return Ok($"{id}:{result}");
		}

		[HttpGet("less-18-years")]
		public IActionResult GetUsersLess18Years()
		{
			return Ok("тут все пользователи младше 18");
		}
	}
}