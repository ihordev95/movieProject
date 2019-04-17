using Microsoft.AspNet.Identity.Owin;
namespace Team3_Project {
	public class EmailService : Microsoft.AspNet.Identity.IIdentityMessageService {
		public System.Threading.Tasks.Task SendAsync(Microsoft.AspNet.Identity.IdentityMessage message) {
			// Plug in your email service here to send an email.
			return System.Threading.Tasks.Task.FromResult(0);
		}
	}
	public class SmsService : Microsoft.AspNet.Identity.IIdentityMessageService {
		public System.Threading.Tasks.Task SendAsync(Microsoft.AspNet.Identity.IdentityMessage message) {
			// Plug in your SMS service here to send a text message.
			return System.Threading.Tasks.Task.FromResult(0);
		}
	}
	// Configure the application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.
	public class ApplicationUserManager : Microsoft.AspNet.Identity.UserManager<Team3_Project.Models.ApplicationUser> {
		public ApplicationUserManager(Microsoft.AspNet.Identity.IUserStore<Team3_Project.Models.ApplicationUser> store)
			: base(store) {
		}
		public static ApplicationUserManager Create(Microsoft.AspNet.Identity.Owin.IdentityFactoryOptions<ApplicationUserManager> options , Microsoft.Owin.IOwinContext context) {
			ApplicationUserManager manager = new ApplicationUserManager(new Microsoft.AspNet.Identity.EntityFramework.UserStore<Team3_Project.Models.ApplicationUser>(context.Get<Team3_Project.Models.ApplicationDbContext>()));
			// Configure validation logic for usernames
			manager.UserValidator = new Microsoft.AspNet.Identity.UserValidator<Team3_Project.Models.ApplicationUser>(manager) {
				AllowOnlyAlphanumericUserNames = false ,
				RequireUniqueEmail = true
			};
			// Configure validation logic for passwords
			manager.PasswordValidator = new Microsoft.AspNet.Identity.PasswordValidator {
				RequiredLength = 6 ,
				RequireNonLetterOrDigit = true ,
				RequireDigit = true ,
				RequireLowercase = true ,
				RequireUppercase = true ,
			};
			// Configure user lockout defaults
			manager.UserLockoutEnabledByDefault = true;
			manager.DefaultAccountLockoutTimeSpan = System.TimeSpan.FromMinutes(5);
			manager.MaxFailedAccessAttemptsBeforeLockout = 5;
			// Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
			// You can write your own provider and plug it in here.
			manager.RegisterTwoFactorProvider("Phone Code" , new Microsoft.AspNet.Identity.PhoneNumberTokenProvider<Models.ApplicationUser> {
				MessageFormat = "Your security code is {0}"
			});
			manager.RegisterTwoFactorProvider("Email Code" , new Microsoft.AspNet.Identity.EmailTokenProvider<Models.ApplicationUser> {
				Subject = "Security Code" ,
				BodyFormat = "Your security code is {0}"
			});
			manager.EmailService = new EmailService();
			manager.SmsService = new SmsService();
			Microsoft.Owin.Security.DataProtection.IDataProtectionProvider dataProtectionProvider = options.DataProtectionProvider;
			if (dataProtectionProvider != null) {
				manager.UserTokenProvider =
					new Microsoft.AspNet.Identity.Owin.DataProtectorTokenProvider<Models.ApplicationUser>(dataProtectionProvider.Create("ASP.NET Identity"));
			}
			return manager;
		}
	}
	// Configure the application sign-in manager which is used in this application.
	public class ApplicationSignInManager : Microsoft.AspNet.Identity.Owin.SignInManager<Models.ApplicationUser , System.String> {
		public ApplicationSignInManager(ApplicationUserManager userManager , Microsoft.Owin.Security.IAuthenticationManager authenticationManager)
			: base(userManager , authenticationManager) {
		}
		public override System.Threading.Tasks.Task<System.Security.Claims.ClaimsIdentity> CreateUserIdentityAsync(Models.ApplicationUser user) {
			return user.GenerateUserIdentityAsync((ApplicationUserManager) this.UserManager);
		}
		public static ApplicationSignInManager Create(Microsoft.AspNet.Identity.Owin.IdentityFactoryOptions<ApplicationSignInManager> options , Microsoft.Owin.IOwinContext context) {
			return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>() , context.Authentication);
		}
	}
}