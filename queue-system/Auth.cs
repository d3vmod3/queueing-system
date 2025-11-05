using queue_system.Data;
using queue_system.Helpers;
using queue_system.Queueing;
using System;
using System.Linq;
using System.Windows.Forms;

namespace queue_system
{
    public static class Auth
    {
        // ✅ Session-like properties
        public static int CurrentUserId { get; private set; }
        public static string CurrentUsername { get; private set; } = string.Empty;
        public static int CurrentUserRoleId { get; private set; }
        public static string CurrentUserRoleName { get; private set; } = string.Empty;
        public static string FirstName { get; private set; } = string.Empty;
        public static string LastName { get; private set; } = string.Empty;
        public static string FullName => $"{FirstName} {LastName}".Trim();

        // ✅ Login method
        public static void Login(string txtUsername, string txtPassword, Form currentForm)
        {
            if (string.IsNullOrWhiteSpace(txtUsername) || string.IsNullOrWhiteSpace(txtPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
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

                if (!PasswordHelper.VerifyPassword(txtPassword, user.password))
                {
                    MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ Store session info
                CurrentUserId = user.id;
                CurrentUsername = user.username;
                CurrentUserRoleId = user.user_role_id;
                CurrentUserRoleName = userWithRole.Role.role_name;
                FirstName = user.first_name;
                LastName = user.last_name;

                // ✅ Login success
                MessageBox.Show($"Welcome, {FullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hide login form
                currentForm.Hide();

                // ✅ Open dashboard based on role
                switch (CurrentUserRoleName)
                {
                    case "Super Admin":
                        new Admin.Dashboard().Show();
                        break;
                    case "Admin":
                        new Admin.Dashboard().Show();
                        break;
                    case "Counter": // optional alias
                        new CounterForm().Show();
                        break;
                    case "Kiosk": // optional alias
                        new GenerateQueueNumber().Show();
                        break;

                    default:
                        MessageBox.Show("Unknown role. Access denied.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        // ✅ Logout
        public static void Logout(Form currentForm)
        {
            // Clear session info
            CurrentUserId = 0;
            CurrentUsername = string.Empty;
            CurrentUserRoleId = 0;
            CurrentUserRoleName = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;

            // Close current form and return to login
            currentForm.Close();

            var loginForm = new Login();
            loginForm.Show();
        }
    }
}
