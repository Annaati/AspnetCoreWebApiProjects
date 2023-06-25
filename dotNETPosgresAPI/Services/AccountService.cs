using dotNETPosgresAPI.Data;
using dotNETPosgresAPI.DTO.Account;
using dotNETPosgresAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dotNETPosgresAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly dotNetPostgresDbContext _context;

        public AccountService(dotNetPostgresDbContext context)
        {
            _context = context;
        }



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


        public UserEditReq? UpdateUser(UserEditReq req)
        {
            throw new NotImplementedException();
        }

        #endregion



        #region User Records section

        public IEnumerable<UserRes> UsersList()
        {
            return _context.Users;
        }
        

        public UserRes? UserById(int? id)
        {
            throw new NotImplementedException();
        }


        public UserRes? CurrentUser()
        {
            throw new NotImplementedException();
        }

        #endregion



        #region Resusbalen Methods section


        #endregion





    }
}
