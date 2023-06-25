using dotNETPosgresAPI.DTO.Account;
using dotNETPosgresAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace dotNETPosgresAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpPost]
        public IActionResult SignIn(SigninReq req)
        {
            var sign = _accountService.SignIn(req);
            if (sign == null)
            {
                return NotFound("No User records that matched provided credentials was found");
            }

            return Ok(sign);
        }


        [HttpPost]
        public IActionResult AddUser(UserAddReq req)
        {
            var newUser = _accountService.AddUser(req);

            if (newUser == null)
            {
                return BadRequest("Could not Register User details");
            }

            return Ok(newUser);
        }

        [HttpPost]
        public IActionResult UpdateUser(UserEditReq req)
        {
            var updateUser = _accountService.UpdateUser(req);

            if (updateUser == null)
            {
                return BadRequest("Could not Update User details");
            }

            return Ok(updateUser);
        }


        [HttpGet]
        public IActionResult UsersList()
        {
            var updateUser = _accountService.UsersList();

            if (updateUser == null)
            {
                return NotFound("No User Records was found");
            }

            return Ok(updateUser);
        }
        

        [HttpGet]
        public IActionResult UserById(int? id)
        {
            var user = _accountService.UserById(id);

            if (user == null)
            {
                return NotFound("No User Records thta matches provided User Id was found");
            }

            return Ok(user);
        }


        [HttpGet]
        public IActionResult CurrentUser()
        {
            var currentUser = _accountService.CurrentUser();

            if (currentUser == null)
            {
                return NotFound("No User Records was found");
            }

            return Ok(currentUser);
        }



    };
}