### CreatePolarisReportInput
Parameters for creating a report with configurations.

- name: System.String
  - Report name.
- reportViewType: PolarisReportViewType
  - Type of report.
- charts: list of ChartViewTypes
  - Selected charts of the report.
- table: TableViewType
  - The selected table of the report.
- filters: list of ReportFilterInputs
  - The filter used for sorting in the report.
- sortBy: System.String
  - The selected order of sorting in the report.
- sortOrder: SortOrder
  - The selected sortOrder in the report.