### ExchangeDagConnection
Paginated list of ExchangeDag objects. Each page of the results will include at most 1000 entries. Query the `pageInfo.hasNextPage` field to know whether all objects were returned.

- count: System.Int32
  - Total number of ExchangeDag objects matching the request arguments.
- edges: a list of ExchangeDagEdges
  - List of ExchangeDag objects with additional pagination information. Use `nodes` if per-object cursors are not needed.
- nodes: a list of ExchangeDags
  - List of ExchangeDag objects.
- pageInfo: PageInfo
  - General information about this page of results.