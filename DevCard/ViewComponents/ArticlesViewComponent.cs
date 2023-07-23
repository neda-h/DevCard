using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
	public class ArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			var articles = new List<Article>
			{
				new Article(1,"آموزش ASP.Net Core MVC","کاملترین پکیج آموزش ASP.Net Core MVC به زبان فارسی","blog-post-thumb-card-1.jpg"),
				new Article(2,"آموزش Git & GitHub","کاملترین پکیج آموزش آموزش Git & GitHub به زبان فارسی","blog-post-thumb-card-2.jpg"),
				new Article(3,"آموزش Android Studio","کامل ترین پکیج آموزش Git & GitHub  به زبان فارسی","blog-post-thumb-card-3.jpg")
			};
			return View("_Articles" , articles);
		}
	}
}
