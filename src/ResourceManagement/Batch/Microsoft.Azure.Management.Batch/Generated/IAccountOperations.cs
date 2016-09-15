// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AccountOperations operations.
    /// </summary>
    public partial interface IAccountOperations
    {
        /// <summary>
        /// Creates a new Batch account with the specified parameters.
        /// Existing accounts cannot be updated with this API and should
        /// instead be updated with the Update Batch Account API.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the new Batch account.
        /// </param>
        /// <param name='accountName'>
        /// A name for the Batch account which must be unique within the
        /// region. Batch account names must be between 3 and 24 characters
        /// in length and must use only numbers and lowercase letters. This
        /// name is used as part of the DNS name that is used to access the
        /// Batch service in the region in which the account is created. For
        /// example: http://accountname.region.batch.azure.com/.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters for account creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AccountResource>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, BatchAccountCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new Batch account with the specified parameters.
        /// Existing accounts cannot be updated with this API and should
        /// instead be updated with the Update Batch Account API.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the new Batch account.
        /// </param>
        /// <param name='accountName'>
        /// A name for the Batch account which must be unique within the
        /// region. Batch account names must be between 3 and 24 characters
        /// in length and must use only numbers and lowercase letters. This
        /// name is used as part of the DNS name that is used to access the
        /// Batch service in the region in which the account is created. For
        /// example: http://accountname.region.batch.azure.com/.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters for account creation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AccountResource>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string accountName, BatchAccountCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the properties of an existing Batch account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters for account update.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AccountResource>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, BatchAccountUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Batch account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account to
        /// be deleted.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to be deleted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified Batch account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account to
        /// be deleted.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account to be deleted.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the specified Batch account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AccountResource>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the Batch accounts associated with the
        /// subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AccountResource>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the Batch accounts associated within the
        /// specified resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group whose Batch accounts to list.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AccountResource>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Synchronizes access keys for the auto storage account configured
        /// for the specified Batch account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> SynchronizeAutoStorageKeysWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Regenerates the specified account key for the specified Batch
        /// account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account.
        /// </param>
        /// <param name='parameters'>
        /// The type of key to regenerate.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<BatchAccountRegenerateKeyResult>> RegenerateKeyWithHttpMessagesAsync(string resourceGroupName, string accountName, BatchAccountRegenerateKeyParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the account keys for the specified Batch account.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<BatchAccountListKeyResult>> ListKeysWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the Batch accounts associated with the
        /// subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AccountResource>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the Batch accounts associated within the
        /// specified resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<AccountResource>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}