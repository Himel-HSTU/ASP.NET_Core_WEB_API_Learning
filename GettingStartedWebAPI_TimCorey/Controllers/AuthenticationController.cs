using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GettingStartedWebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IConfiguration _config;
    public AuthenticationController(IConfiguration config)
    {
        _config = config;
    }
    public record AuthenticationData (string? Username, string? Password);
    public record UserData(int Id, string? Username, string? Gender,int employeeId);


    [HttpPost("token")] // POST api/Authentication/token
    [AllowAnonymous]
    public ActionResult<string> Authenticate([FromBody] AuthenticationData data)
    {
        var user = ValidateCredentials(data);
        if (user == null)
        {
            return Unauthorized();
        }
        return Ok(GenerateToken(user));
    }
    
    private string GenerateToken(UserData user)
    {
        // This is secret key to generate and validate incoming JWT token,
        var secretKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config.GetValue<string>("Authentication:SecretKey")));

        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        List<Claim> claims = new();
        claims.Add(new(JwtRegisteredClaimNames.Sub, user.Id.ToString()));
        claims.Add(new(JwtRegisteredClaimNames.UniqueName, user.Username));
        claims.Add(new("Gender", user.Gender));
        claims.Add(new("employeeId", user.employeeId.ToString()));   

        var token = new JwtSecurityToken(
            _config.GetValue<string>("Authentication:Issuer"),
            _config.GetValue<string>("Authentication:Audience"),
            claims,
            DateTime.UtcNow, // When the token will be valid from
            DateTime.UtcNow.AddMinutes(1), // When the token will expire
            signingCredentials
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private UserData ValidateCredentials(AuthenticationData data) {
        // This method is just for testing purposes,Never do this in a real application
        // This method will replace by a proper authentication mechanism in a real application
        // Like JWT, OAuth, or any other authentication mechanism
        if (CompareCredentials(data, "admin", "admin1234"))
        {   
            return new UserData(1, data.Username,"Hijra", 1001);
        }
        if (CompareCredentials(data, "himel", "himel1234"))
        {
            return new UserData(2, data.Username, "Male", 1002);
        }   
        return null;

    }

    private bool CompareCredentials(AuthenticationData data,string userName,string password)
    {
        return data.Username == userName && data.Password == password;
    }
} 
