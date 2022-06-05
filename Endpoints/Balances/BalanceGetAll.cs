namespace Control_Finance_WebAPI.Endpoints.Balances
{
    public class BalanceGetAll
    {
        public static string Template => "/balances";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action()
        {
            

            return Results.Ok("Ok");
        }
    }
}
