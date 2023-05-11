### VcdVappConnection
Paginated list of VcdVapp objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of VcdVapp objects matching the request arguments.
- edges: a list of VcdVappEdges
  - List of VcdVapp objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of VcdVapps
  - List of VcdVapp objects.
- pageInfo: PageInfo
  - General information about this page of results.