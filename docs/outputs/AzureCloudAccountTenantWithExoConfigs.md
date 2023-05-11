### AzureCloudAccountTenantWithExoConfigs
Azure Cloud Account Tenant with details of exocompute configured for subscriptions for a given feature.

- appName: System.String
  - App name of Azure application for the tenant.
- clientId: System.String
  - Client ID of azure application for the tenant.
- cloudType: AzureCloudType
  - Type of Azure Tenant. Can be Azure Public Cloud or Azure China Cloud.
- domainName: System.String
  - Azure Active Directory (AD) domain corresponding to subscription.
- subscriptionCount: System.Int32
  - Number of subscriptions for the tenant.
- subscriptions: a list of AzureSubscriptionWithExoConfigss
  - Details of subscriptions for the tenant.