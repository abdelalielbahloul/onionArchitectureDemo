using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(int id);
    }
}
