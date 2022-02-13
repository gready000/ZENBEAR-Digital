namespace ZENBEAR.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "ZENBEAR";

        public const string AdministratorRoleName = "Administrator";

        // User
        public const int UserNameMinLength = 3;
        public const int UserNameMaxLength = 25;

        // JobTitle
        public const int JobNameMinLength = 5;
        public const int JobNameMaxLength = 30;

        // Department
        public const int DepartmentMinLength = 5;

        public const string ErrorLength = "The {0} must be at least {2} and at max {1} characters long.";
        public const string PassNotMatch = "The password and confirmation password do not match.";
        public const string InvalidLogin = "Invalid Username or Password";
        public const string SuccessLogin = "User logged in successfully";

        public const string AdminRole = "Admin";
        public const string DefaultRole = "User";
    }
}
