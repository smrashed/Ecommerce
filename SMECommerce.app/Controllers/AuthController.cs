using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SMECommerce.app.Models.Auth;
using SMECommerce.Models.EntityModels.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMECommerce.app.Controllers
{
    public class AuthController : Controller
    {
        SignInManager<AppUser> _signInManager;
        UserManager<AppUser> _userManager;
        IPasswordHasher<AppUser> _passwordHasher;
        IConfiguration _config;

        public AuthController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager,
            IPasswordHasher<AppUser> passwordHasher, IConfiguration config)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if(user!=null)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser()
                {
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }

        
        public async Task<IActionResult> Token([FromBody] LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result =  _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, model.Password);
                
                if(result == PasswordVerificationResult.Success)
                {
                    var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                    var signingCredentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

                    var claims = await _userManager.GetClaimsAsync(user);

                    var token = new JwtSecurityToken(
                        issuer: _config["Jwt:Issuer"],
                        audience: _config["Jwt:Issuer"],
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(120),
                        signingCredentials: signingCredentials
                    );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(new { token = tokenString, expires = token.ValidTo });

                }
            }
            return BadRequest("User or Password could not match, please check");
        }


    }
}
