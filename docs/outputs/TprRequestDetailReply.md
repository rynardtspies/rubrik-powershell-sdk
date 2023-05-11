### TprRequestDetailReply
Reply for getting TPR Request Detail.

- createdAt: DateTime
  - Time the request was created.
- details: TprRequestDetail
  - Details of the request.
- executionExpiresAt: DateTime
  - Time the request's execution window expires.
- executionType: TprExecutionType
  - Execution type for the request.
- expiresAt: DateTime
  - Time the request expires.
- id: System.String
  - ID of the TPR request.
- orgId: System.String
  - ID of the org.
- orgName: System.String
  - Name of the org.
- requester: TprRequester
  - User making the TPR request.
- status: TprReqStatus
  - Status of the request.
- statusLog: a list of TprReqStatusChanges
  - Log of the changes to the request.
- triggeredTprPolicies: a list of TriggeredTprPolicys
  - Policies triggered by the request.
- triggeredTprRule: System.String
  - Highest priority rule triggered by the request.
- triggeredTprRules: a list of System.Strings
  - All rules triggered by the request.
- updatedAt: DateTime
  - Time the request was last updated.