using DataAccess.Models;
using DataAccess.SqlServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;
using UserService.ViewModel;

namespace UserService.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
                _userServices = userServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetUser(int PageSize, int PageNum) 
        { 
            return Ok(await _userServices.GetUserPage(PageSize, PageNum));    
        }

        [HttpPost]
        public async Task<IActionResult> PostUser(AddUserVM addUserVM)
        {
            if (addUserVM != null)
            {
                UserModel userModel = new UserModel();
                userModel.FullName = addUserVM.FullName;
                userModel.Email = addUserVM.Email;
                userModel.Phone = addUserVM.Phone;
                return Ok(await _userServices.AddUser(userModel));
            }
            else
            {
                return Ok(new { });
            }
            
        }
    }
}
