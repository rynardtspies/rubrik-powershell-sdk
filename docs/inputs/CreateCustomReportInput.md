### CreateCustomReportInput
Input for creating a custom report.

- charts: a list of ReportChartCreates
  - Chart configs for the report.
- filters: CustomReportFiltersConfig
  - Filters for the report data.
- focus: ReportFocusEnum
  - None
- isHidden: System.Boolean
  - Specifies whether the report should be hidden from the gallery view.
- isReadOnly: System.Boolean
  - Specifies whether the report is auto-generated and not editable.
- name: System.String
  - Name of the report.
- tables: a list of ReportTableCreates
  - Table configs for the report.