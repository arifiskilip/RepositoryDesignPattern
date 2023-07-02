using System.Collections.Generic;
using WebUI.Core.Models;



namespace WebUI.Core.Mappings.UserMapping
{
    public interface IUserMap
    {
        List<UserModel> UserToUserModels(List<WebUI.Core.Entities.User> users);
        UserModel UserToUserModel(WebUI.Core.Entities.User user);
    }
}
