namespace OnlineShop.Services
{
	public class UserService : IUserService
	{
		public int Counter { get; set; }
		public string GetAll()
		{
			Counter++;
			var users = "тут все пользователи" + Counter;
			return users;
		}
	}
}