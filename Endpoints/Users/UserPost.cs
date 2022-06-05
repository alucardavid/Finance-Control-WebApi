using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Control_Finance_WebAPI.Endpoints.Users
{
    public class UserPost
    {
        public static string Template => "/users";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;

        public static async Task<IResult> Action(UserRequest userRequest, UserManager<IdentityUser> userManager)
        {
            var user = new IdentityUser { UserName = userRequest.Email, Email = userRequest.Email, PhoneNumber = userRequest.PhoneNumber };
            var result = await userManager.CreateAsync(user, userRequest.Password);

            if (!result.Succeeded)
                return Results.ValidationProblem(result.Errors.ConvertToProblemDetails());

            var userClaims = new List<Claim> {
                new Claim("Name", userRequest.Name),
                new Claim("Gender", userRequest.Gender),
            };

            var claimResult = await userManager.AddClaimsAsync(user, userClaims);

            if(!claimResult.Succeeded)
                return Results.BadRequest(result.Errors.First());

            return Results.Created($"/users/{user.Id}", user.Id);

        }

    }
}
