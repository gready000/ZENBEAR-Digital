namespace ZENBEAR.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "ZENBEAR";

        public const string AdministratorRoleName = "Admin";
        public const string DefaultRole = "User";
        public const string ITRole = "ITSupport";
        public const string InfoSecRole = "InfoSec";
        public const string ITorInfoSec = ITRole + "," + InfoSecRole;

        // Projects
        public const string ITProject = "IT Service Desk";
        public const string InfoSecProject = "InfoSec";

        // Ticket
        public const int SummaryMinLength = 5;
        public const int DescriptionMaxLength = 15;

        // Password
        public const int PasswordMinLength = 6;
        public const int PasswordMaxLength = 50;

        // User
        public const int UserNameMinLength = 3;
        public const int UserNameMaxLength = 25;
        public const int FirstNameMinLength = 3;
        public const int FirstNameMaxLength = 25;
        public const int LastNameMinLength = 5;
        public const int LastNameMaxLength = 30;

        // Department
        public const int DepartmentMinLength = 5;

        // BaseName
        public const int BaseNameMinLength = 5;
        public const int BaseNameMaxLength = 30;

        // CommentContent
        public const int CommentMinLength = 2;

        // Project
        public const int ProjectMinLength = 5;

        // Issue
        public const int IssueMinLength = 5;

        // Role
        public const int RoleNameMinLength = 3;
        public const int RoleNameMaxLength = 15;

        // JobTitle
        public const int JobNameMinLength = 5;
        public const int JobNameMaxLength = 30;

        public const int ItemsPerPage = 12;
    }
}
