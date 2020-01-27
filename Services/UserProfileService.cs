using Data;
using Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public UserProfile GetUserProfile(int id)
        {
            return userProfileRepository.Get(id);
        }
    }
}
