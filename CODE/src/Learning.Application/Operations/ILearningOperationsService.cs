namespace Learning.Application.Operations;

public interface ILearningOperationsService
{
    Task<IReadOnlyCollection<RiskRuleDto>> GetRiskRulesAsync(CancellationToken cancellationToken);

    Task<RiskRuleDto> CreateRiskRuleAsync(CreateRiskRuleRequest request, CancellationToken cancellationToken);

    Task<bool> SetRiskRuleActiveAsync(Guid riskRuleId, bool isActive, CancellationToken cancellationToken);

    Task<RiskRecalculationResultDto?> RecalculateRiskAsync(
        RiskRecalculationRequest request,
        CancellationToken cancellationToken);

    Task<IReadOnlyCollection<InterventionDto>> GetInterventionsAsync(CancellationToken cancellationToken);

    Task<InterventionDto> CreateInterventionAsync(CreateInterventionRequest request, CancellationToken cancellationToken);

    Task<bool> AddInterventionNoteAsync(
        Guid interventionId,
        AddInterventionNoteRequest request,
        CancellationToken cancellationToken);

    Task<bool> RecordInterventionOutcomeAsync(
        Guid interventionId,
        RecordInterventionOutcomeRequest request,
        CancellationToken cancellationToken);

    Task<IReadOnlyCollection<DashboardMetricDto>> GetDashboardMetricsAsync(CancellationToken cancellationToken);

    Task<IReadOnlyCollection<ReportTemplateDto>> GetReportTemplatesAsync(CancellationToken cancellationToken);

    Task<IReadOnlyCollection<ReportRequestDto>> GetReportRequestsAsync(CancellationToken cancellationToken);

    Task<ReportRequestDto> CreateReportRequestAsync(CreateReportRequestDto request, CancellationToken cancellationToken);

    Task<IReadOnlyCollection<AuditLogDto>> GetAuditLogsAsync(CancellationToken cancellationToken);

    Task<IReadOnlyCollection<SystemUserDto>> GetUsersAsync(CancellationToken cancellationToken);

    Task<IReadOnlyCollection<RoleDto>> GetRolesAsync(CancellationToken cancellationToken);

    Task<IReadOnlyCollection<SystemConfigurationDto>> GetConfigurationsAsync(CancellationToken cancellationToken);
}
