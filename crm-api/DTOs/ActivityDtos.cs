using CrmApi.Models;

namespace CrmApi.DTOs;

public record CreateActivityRequest(
    ActivityType Type,
    string Description,
    int? ContactId,
    int? DealId);

public record ActivityResponse(
    int Id,
    string Type,
    string Description,
    int? ContactId,
    string? ContactName,
    int? DealId,
    string? DealTitle,
    int UserId,
    string UserName,
    DateTime CreatedAt);

public record DashboardResponse(
    int TotalContacts,
    int TotalCompanies,
    int TotalDeals,
    decimal TotalDealValue,
    int WonDeals,
    Dictionary<string, int> DealsByStage,
    List<ActivityResponse> RecentActivities);
