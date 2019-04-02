using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team3_Project.Models {
	public class ExternalLoginConfirmationViewModel {
		[Required]
		[Display(Name = "Email")]
		public System.String Email { get; set; }
	}

	public class ExternalLoginListViewModel {
		public System.String ReturnUrl { get; set; }
	}

	public class SendCodeViewModel {
		public System.String SelectedProvider { get; set; }
		public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
		public System.String ReturnUrl { get; set; }
		public System.Boolean RememberMe { get; set; }
	}

	public class VerifyCodeViewModel {
		[Required]
		public System.String Provider { get; set; }

		[Required]
		[Display(Name = "Code")]
		public System.String Code { get; set; }
		public System.String ReturnUrl { get; set; }

		[Display(Name = "Remember this browser?")]
		public System.Boolean RememberBrowser { get; set; }

		public System.Boolean RememberMe { get; set; }
	}

	public class ForgotViewModel {
		[Required]
		[Display(Name = "Email")]
		public System.String Email { get; set; }
	}

	public class LoginViewModel {
		[Required]
		[Display(Name = "Email")]
		[EmailAddress]
		public System.String Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public System.String Password { get; set; }

		[Display(Name = "Remember me?")]
		public System.Boolean RememberMe { get; set; }
	}

	public class RegisterViewModel {
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public System.String Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public System.String UserName { get; set; }

		[Required]
		[StringLength(100 , ErrorMessage = "The {0} must be at least {2} characters long." , MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public System.String Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password" , ErrorMessage = "The password and confirmation password do not match.")]
		public System.String ConfirmPassword { get; set; }
	}

	public class ResetPasswordViewModel {
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public System.String Email { get; set; }

		[Required]
		[StringLength(100 , ErrorMessage = "The {0} must be at least {2} characters long." , MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public System.String Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password" , ErrorMessage = "The password and confirmation password do not match.")]
		public System.String ConfirmPassword { get; set; }

		public System.String Code { get; set; }
	}

	public class ForgotPasswordViewModel {
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public System.String Email { get; set; }
	}
}
