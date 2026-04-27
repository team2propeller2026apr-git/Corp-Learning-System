using Learning.Domain.Enums;

namespace Learning.Application.Operations;

public sealed record RiskRuleDto(
    Guid Id,
    string Name,
    string ConditionExpression,
    RiskLevel Severity,
    int Version,
    bool IsActive);

public sealed record CreateRiskRuleRequest(
    string Name,
    string ConditionExpression,
    RiskLevel Severity);

public sealed record RiskRecalculationRequest(Guid EmployeeId, Guid? ProgramId);

public sealed record RiskRecalculationResultDto(
    Guid RiskAssessmentId,
    Guid EmployeeId,
    Guid ProgramId,
    RiskLevel RiskLevel,
    string Reason,
    IReadOnlyCollection<string> TriggeredRules);

public sealed record InterventionDto(
    Guid Id,
    Guid EmployeeId,
    string EmployeeNumber,
    string EmployeeName,
    Guid ProgramId,
    string ProgramName,
    string InterventionType,
    string OwnerName,
    DateOnly DueDate,
    InterventionStatus Status,
    string? Outcome);

public sealed record CreateInterventionRequest(
    Guid EmployeeId,
    Guid ProgramId,
    string InterventionType,
    Guid OwnerId,
    DateOnly DueDate);

public sealed record AddInterventionNoteRequest(Guid AuthorUserId, string Note);

public sealed record RecordInterventionOutcomeRequest(string Outcome, string Measurement);

public sealed record DashboardMetricDto(string Name, string Scope, decimal Value, DateTimeOffset CapturedAt);

public sealed record ReportTemplateDto(Guid Id, string Code, string Name, string ReportType, bool IsActive);

public sealed record ReportRequestDto(
    Guid Id,
    string TemplateName,
    string RequestedBy,
    string FiltersJson,
    ReportStatus Status,
    DateTimeOffset CreatedAt,
    DateTimeOffset? CompletedAt,
    string? OutputUri);

public sealed record CreateReportRequestDto(Guid ReportTemplateId, Guid RequestedByUserId, string FiltersJson);

public sealed record AuditLogDto(
    Guid Id,
    string ActorName,
    string Action,
    string EntityType,
    string EntityId,
    DateTimeOffset CreatedAt);

public sealed record SystemUserDto(Guid Id, string DisplayName, string Email, bool IsActive);

public sealed record RoleDto(Guid Id, string Code, string Name);

public sealed record SystemConfigurationDto(Guid Id, string Key, string Value, string Category);
