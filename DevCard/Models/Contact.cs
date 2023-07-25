using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public string Email { get; set; }

        public int Service { get; set; }
        public string Message { get; set; }

        [ValidateNever]
        public SelectList Services { get; set; }
    }
}