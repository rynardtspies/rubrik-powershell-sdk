### ActivitySeriesFilter
Filters for list of event series.

- ancestorId: System.String
  - Filter by ancestor ID.
- clusterId: a list of System.Strings
  - Filter by cluster UUID.
- clusterType: a list of EventClusterTypes
  - Filter by cluster type.
- lastActivityStatus: a list of EventStatuss
  - Filter by last activity status.
- lastActivityType: a list of EventTypes
  - Filter by last activity type.
- lastUpdatedTimeGt: DateTime
  - Filter activites having last updated time after the specified value.
- lastUpdatedTimeLt: DateTime
  - Filter activites having last updated time before than the specified value.
- objectFid: a list of System.Strings
  - Filter by object fid.
- objectName: System.String
  - Filter by object name.
- objectType: a list of EventObjectTypes
  - Filter by object type.
- orgIds: a list of System.Strings
  - Filter by organization ID.
- searchTerm: System.String
  - Filter by search term.
- severity: a list of EventSeveritys
  - Filter by severity of the activity.
- startTimeGt: DateTime
  - Filter activities having start time after the specified value.
- startTimeLt: DateTime
  - Filter activities having start time before the specified value.