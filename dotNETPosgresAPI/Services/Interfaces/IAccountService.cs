
using dotNETPosgresAPI.DTO.Account;

namespace dotNETPosgresAPI.Services.Interfaces
{
    public interface IAccountService
    {

        #region SignIn Section
        SigninReq? SignIn(SigninReq req);
        #endregion

        #region User Operations section

        UserAddReq? AddUser(UserAddReq req);

        UserEditReq? UpdateUser(UserEditReq req);

        #endregion


        #region User Records section
        List<UserRes> UsersList();

        UserRes? UserById(int? id);


        UserRes? CurrentUser();

        #endregion



    }
}
