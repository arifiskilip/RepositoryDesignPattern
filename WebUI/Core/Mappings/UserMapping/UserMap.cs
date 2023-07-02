using System.Collections.Generic;
using WebUI.Core.Mappings.UserMapping;
using WebUI.Core.Models;

namespace WebUI.Core.Mappings.User
{
    public class UserMap : IUserMap
    {
        public UserModel UserToUserModel(Entities.User user)
        {
            return new UserModel
            {
                FirstName = user.FirstName,
                Id = user.Id,
                LastName = user.LastName,
            };
        }

        public List<UserModel> UserToUserModels(List<WebUI.Core.Entities.User> users)
        {
            var models = new List<UserModel>();
            foreach (var item in users)
            {
                models.Add(new UserModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                });
            }
            return models;
        }
    }
}
