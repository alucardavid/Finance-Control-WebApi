using Control_Finance_WebAPI.Infra.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace Control_Finance_WebAPI.Endpoints.Balances
{
    [Authorize]
    public class BalanceGetAll
    {
        public static string Template => "/balances";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(DevGeniusFinanceContext context)
        {
            var balances = context.Balances.Select(b => new BalanceResponse(b.Description, b.Value, b.CreatedAt, b.UpdatedAt, b.UserCpf));
            
            return Results.Ok(balances);
        }
    }
}
