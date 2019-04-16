namespace Team3_Project.Models {
	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
	public class ApplicationUser : Microsoft.AspNet.Identity.EntityFramework.IdentityUser {
		public async System.Threading.Tasks.Task<System.Security.Claims.ClaimsIdentity> GenerateUserIdentityAsync(Microsoft.AspNet.Identity.UserManager<ApplicationUser> manager) {
			// Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
			System.Security.Claims.ClaimsIdentity userIdentity = await manager.CreateIdentityAsync(this , Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ApplicationCookie);
			// Add custom user claims here
			return userIdentity;
		}
	}
	public class ApplicationDbContext : Microsoft.AspNet.Identity.EntityFramework.IdentityDbContext<ApplicationUser> {
		public ApplicationDbContext()
			: base("DefaultConnection" , throwIfV1Schema: false) {
		}
		public static ApplicationDbContext Create() {
			return new ApplicationDbContext();
		}
	}
}