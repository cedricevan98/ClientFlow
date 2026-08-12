namespace CrmApi.DTOs;

public record CreateCompanyRequest(
    string Name,
    string? Industry,
    string? Website,
    string? Phone,
    string? Address);

public record UpdateCompanyRequest(
    string Name,
    string? Industry,
    string? Website,
    string? Phone,
    string? Address);

public record CompanyResponse(
    int Id,
    string Name,
    string? Industry,
    string? Website,
    string? Phone,
    string? Address,
    int ContactCount,
    int DealCount,
    DateTime CreatedAt);
