using dotNETPosgresAPI.DTO.Account;
using dotNETPosgresAPI.Services.Interfaces;

namespace dotNETPosgresAPI.Services
{
    public class AccountService : IAccountService
    {



        #region SignIn Section

        public SigninReq? SignIn(SigninReq req)
        {
            throw new NotImplementedException();
        }

        #endregion



        #region User Operations section

        public UserAddReq? AddUser(UserAddReq req)
        {
            throw new NotImplementedException();
        }


        public UserEditReq? EditUser(UserEditReq req)
        {
            throw new NotImplementedException();
        }

        #endregion



        #region User Records section

        public List<UserRes> UsersList()
        {
            throw new NotImplementedException();
        }

        public UserRes? UserById(int? id)
        {
            throw new NotImplementedException();
        }

        #endregion



        #region Resusbalen Methods section


        #endregion





    }
}
