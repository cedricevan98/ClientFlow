using CrmApi.Models;

namespace CrmApi.DTOs;

public record CreateDealRequest(
    string Title,
    decimal Value,
    DealStage Stage,
    DateTime? CloseDate,
    string? Notes,
    int? ContactId,
    int? CompanyId);

public record UpdateDealRequest(
    string Title,
    decimal Value,
    DealStage Stage,
    DateTime? CloseDate,
    string? Notes,
    int? ContactId,
    int? CompanyId);

public record UpdateDealStageRequest(DealStage Stage);

public record DealResponse(
    int Id,
    string Title,
    decimal Value,
    string Stage,
    DateTime? CloseDate,
    string? Notes,
    int? ContactId,
    string? ContactName,
    int? CompanyId,
    string? CompanyName,
    DateTime CreatedAt,
    DateTime UpdatedAt);
