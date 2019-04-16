namespace Team3_Project.Models {
	public class ExternalLoginConfirmationViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Display(Name = "Email")]
		public System.String Email { get; set; }
	}
	public class ExternalLoginListViewModel {
		public System.String ReturnUrl { get; set; }
	}
	public class SendCodeViewModel {
		public System.String SelectedProvider { get; set; }
		public System.Collections.Generic.ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
		public System.String ReturnUrl { get; set; }
		public System.Boolean RememberMe { get; set; }
	}
	public class VerifyCodeViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		public System.String Provider { get; set; }
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Display(Name = "Code")]
		public System.String Code { get; set; }
		public System.String ReturnUrl { get; set; }
		[System.ComponentModel.DataAnnotations.Display(Name = "Remember this browser?")]
		public System.Boolean RememberBrowser { get; set; }
		public System.Boolean RememberMe { get; set; }
	}
	public class ForgotViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Display(Name = "Email")]
		public System.String Email { get; set; }
	}
	public class LoginViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Display(Name = "Email")]
		[System.ComponentModel.DataAnnotations.EmailAddress]
		public System.String Email { get; set; }
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Password")]
		public System.String Password { get; set; }
		[System.ComponentModel.DataAnnotations.Display(Name = "Remember me?")]
		public System.Boolean RememberMe { get; set; }
	}
	public class RegisterViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.EmailAddress]
		[System.ComponentModel.DataAnnotations.Display(Name = "Email")]
		public System.String Email { get; set; }
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Text)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Username")]
		public System.String UserName { get; set; }
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.StringLength(100 , ErrorMessage = "The {0} must be at least {2} characters long." , MinimumLength = 6)]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Password")]
		public System.String Password { get; set; }
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Confirm password")]
		[System.ComponentModel.DataAnnotations.Compare("Password" , ErrorMessage = "The password and confirmation password do not match.")]
		public System.String ConfirmPassword { get; set; }
	}
	public class ResetPasswordViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.EmailAddress]
		[System.ComponentModel.DataAnnotations.Display(Name = "Email")]
		public System.String Email { get; set; }
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.StringLength(100 , ErrorMessage = "The {0} must be at least {2} characters long." , MinimumLength = 6)]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Password")]
		public System.String Password { get; set; }
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Confirm password")]
		[System.ComponentModel.DataAnnotations.Compare("Password" , ErrorMessage = "The password and confirmation password do not match.")]
		public System.String ConfirmPassword { get; set; }
		public System.String Code { get; set; }
	}
	public class ForgotPasswordViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.EmailAddress]
		[System.ComponentModel.DataAnnotations.Display(Name = "Email")]
		public System.String Email { get; set; }
	}
}