﻿
namespace ProjectManager.Model
{
    public class UserModel
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
