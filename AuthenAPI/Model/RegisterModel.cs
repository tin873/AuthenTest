using System.ComponentModel.DataAnnotations;

namespace AuthenAPI.Model
{
    public class RegisterModel
    {
        [Required (ErrorMessage ="Tên không được để trống.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email không được để trống.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        public string Password { get; set; }
    }
}
