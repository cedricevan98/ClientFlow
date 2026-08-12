namespace CrmApi.DTOs;

public record RegisterRequest(string FullName, string Email, string Password);
public record LoginRequest(string Email, string Password);
public record AuthResponse(int Id, string FullName, string Email, string Role, string Token);
