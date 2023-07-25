using System.ComponentModel.DataAnnotations;

namespace DevCard.Models
{
	public class Contact
	{
		[Required(ErrorMessage = "این فیلد اجباری است")]
		[MaxLength(100, ErrorMessage = "حداکثر طول نام، 100 کارکتر می باشد")]
		[MinLength(3, ErrorMessage = "حداقل طول نام، 3 کارکتر می باشد")]
		public String Name { get; set; }

		[EmailAddress(ErrorMessage = "فرمت ایمیل وارد شده صحیح نمی باشد")]
		[Required(ErrorMessage = "این فیلد اجباری است")]
		public String Email { get; set; }

		public String Message { get; set; }

		public String Service { get; set; }
	}
}