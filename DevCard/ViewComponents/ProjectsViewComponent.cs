using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			var projects = new List<Project>
			{
				new Project(1,"تاکسی" , "درخواست آنلاین تاکسی برای سفرهای درون شهری" , "Atria" , "project-1.jpg"),
				new Project(2,"زودفود" , "درخواست آنلاین غذا برای سراسر کشور" , "Zoodfood" , "project-2.jpg"),
				new Project(3,"مدارس" , "سیستم مدیریت یکپارچه مدارس"  , "MONOP" , "project-3.jpg"),
				new Project(4,"فضاپیما" , "برنامه مدیریت فضاپیماهای ناسا"  , "NASA" , "project-4.jpg")
			};
			return View("_Projects", projects);
		}
	}
}