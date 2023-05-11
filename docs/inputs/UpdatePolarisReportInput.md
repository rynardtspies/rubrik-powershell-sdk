### UpdatePolarisReportInput
Parameters for updating a report with configurations.

- charts: a list of ChartViewTypes
  - Selected charts of the report.
- filters: a list of ReportFilterInputs
  - The filter used for sorting in the report.
- name: System.String
  - Report name.
- reportId: System.Int64
  - Id of report.
- reportViewType: PolarisReportViewType
  - Type of report.
- sortBy: System.String
  - The selected order of sorting in the report.
- sortOrder: SortOrder
  - The selected sortOrder in the report.
- table: TableViewType
  - The selected table of the report.