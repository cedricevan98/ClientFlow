namespace CrmApi.DTOs;

public record CreateContactRequest(
    string FirstName,
    string LastName,
    string Email,
    string? Phone,
    string? JobTitle,
    string? Notes,
    int? CompanyId);

public record UpdateContactRequest(
    string FirstName,
    string LastName,
    string Email,
    string? Phone,
    string? JobTitle,
    string? Notes,
    int? CompanyId);

public record ContactResponse(
    int Id,
    string FirstName,
    string LastName,
    string FullName,
    string Email,
    string? Phone,
    string? JobTitle,
    string? Notes,
    int? CompanyId,
    string? CompanyName,
    int DealCount,
    DateTime CreatedAt,
    DateTime UpdatedAt);
