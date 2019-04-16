namespace Team3_Project.Models {
	public class IndexViewModel {
		public System.Boolean HasPassword { get; set; }
		public System.Collections.Generic.IList<Microsoft.AspNet.Identity.UserLoginInfo> Logins { get; set; }
		public System.String PhoneNumber { get; set; }
		public System.Boolean TwoFactor { get; set; }
		public System.Boolean BrowserRemembered { get; set; }
	}
	public class ManageLoginsViewModel {
		public System.Collections.Generic.IList<Microsoft.AspNet.Identity.UserLoginInfo> CurrentLogins { get; set; }
		public System.Collections.Generic.IList<Microsoft.Owin.Security.AuthenticationDescription> OtherLogins { get; set; }
	}
	public class FactorViewModel {
		public System.String Purpose { get; set; }
	}
	public class SetPasswordViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.StringLength(100 , ErrorMessage = "The {0} must be at least {2} characters long." , MinimumLength = 6)]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "New password")]
		public System.String NewPassword { get; set; }
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Confirm new password")]
		[System.ComponentModel.DataAnnotations.Compare("NewPassword" , ErrorMessage = "The new password and confirmation password do not match.")]
		public System.String ConfirmPassword { get; set; }
	}
	public class ChangePasswordViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Current password")]
		public System.String OldPassword { get; set; }
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.StringLength(100 , ErrorMessage = "The {0} must be at least {2} characters long." , MinimumLength = 6)]
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "New password")]
		public System.String NewPassword { get; set; }
		[System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		[System.ComponentModel.DataAnnotations.Display(Name = "Confirm new password")]
		[System.ComponentModel.DataAnnotations.Compare("NewPassword" , ErrorMessage = "The new password and confirmation password do not match.")]
		public System.String ConfirmPassword { get; set; }
	}
	public class AddPhoneNumberViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Phone]
		[System.ComponentModel.DataAnnotations.Display(Name = "Phone Number")]
		public System.String Number { get; set; }
	}
	public class VerifyPhoneNumberViewModel {
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Display(Name = "Code")]
		public System.String Code { get; set; }
		[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Phone]
		[System.ComponentModel.DataAnnotations.Display(Name = "Phone Number")]
		public System.String PhoneNumber { get; set; }
	}
	public class ConfigureTwoFactorViewModel {
		public System.String SelectedProvider { get; set; }
		public System.Collections.Generic.ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
	}
}