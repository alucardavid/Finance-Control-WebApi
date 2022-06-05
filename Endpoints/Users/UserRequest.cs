namespace Control_Finance_WebAPI.Endpoints.Users;

public record UserRequest(string Name, string Password, string Email, string Gender, string PhoneNumber);