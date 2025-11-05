using queue_system.Data;
using queue_system.Helpers;
using queue_system.Queueing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_system
{
    public class Auth
    {
        public static string CurrentUser { get; set; } = "";
        public static int CurrentUserTypeId { get; set; }
        public static string FirstName { get; set; } = "";
        public static string LastName { get; set; } = "";
        public static string FullName => $"{FirstName} {LastName}".Trim();

        public static void Logout(Form currentForm)
        {
            CurrentUser = "";
            CurrentUserTypeId = 0;
            currentForm.Close();
            var loginForm = new Login(); // Replace with your login form
            loginForm.Show();



        }

        public static void Login(string txtUsername, string txtPassword)
        {
            if (string.IsNullOrWhiteSpace(txtUsername) || string.IsNullOrWhiteSpace(txtPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                // Get user with role in one query
                var userWithRole = db.Users
                    .Join(db.UserRoles,
                          u => u.user_role_id,
                          r => r.id,
                          (u, r) => new { User = u, Role = r })
                    .FirstOrDefault(x => x.User.username == txtUsername);

                if (userWithRole == null)
                {
                    MessageBox.Show("Username not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var user = userWithRole.User;

                if (!user.is_active)
                {
                    MessageBox.Show("This account is inactive. Contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Verify hashed password
                bool isValid = PasswordHelper.VerifyPassword(txtPassword, user.password);

                if (!isValid)
                {
                    MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ Login success
                MessageBox.Show($"Welcome, {user.first_name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide login form
                //this.Hide();

                // Open form based on role
                switch (userWithRole.Role.role_name)
                {
                    case "Admin":
                        new Admin.Dashboard().Show();
                        break;
                    case "User":
                        new CounterForm().Show();
                        break;

                    default:
                        MessageBox.Show("Unknown role. Access denied.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

    }


}
