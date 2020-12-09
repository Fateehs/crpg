﻿using Crpg.Domain.Entities.Users;

namespace Crpg.Application.Common.Services
{
    public class UserService
    {
        private readonly Constants _constants;

        public UserService(Constants constants)
        {
            _constants = constants;
        }

        public void SetDefaultValuesForUser(User user)
        {
            user.Gold = _constants.DefaultGold;
            user.Role = _constants.DefaultRole;
            user.HeirloomPoints = _constants.DefaultHeirloomPoints;
        }
    }
}