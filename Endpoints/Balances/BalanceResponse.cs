namespace Control_Finance_WebAPI.Endpoints.Balances;

public record BalanceResponse(string Description, double Value, DateTime CreatedAt, DateTime? UpdateAt, string UserCpf);

