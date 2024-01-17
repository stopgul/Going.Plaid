namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Create a new Identity Verification for the user specified by the <c>client_user_id</c> field. The requirements and behavior of the verification are determined by the <c>template_id</c> provided.</para>
	/// <para>If you don't know whether the associated user already has an active Identity Verification, you can specify <c>"is_idempotent": true</c> in the request body. With idempotency enabled, a new Identity Verification will only be created if one does not already exist for the associated <c>client_user_id</c> and <c>template_id</c>. If an Identity Verification is found, it will be returned unmodified with an <c>200 OK</c> HTTP status code.</para>
	/// <para>You can also use this endpoint to supply information you already have collected about the user; if any of these fields are specified, the screens prompting the user to enter them will be skipped during the Link flow.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity-verification/#identity_verificationcreate" /></remarks>
	public Task<IdentityVerification.IdentityVerificationCreateResponse> IdentityVerificationCreateAsync(IdentityVerification.IdentityVerificationCreateRequest request) =>
		PostAsync("/identity_verification/create", request)
			.ParseResponseAsync<IdentityVerification.IdentityVerificationCreateResponse>();

	/// <summary>
	/// <para>Retrieve a previously created Identity Verification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity-verification/#identity_verificationget" /></remarks>
	public Task<IdentityVerification.IdentityVerificationGetResponse> IdentityVerificationGetAsync(IdentityVerification.IdentityVerificationGetRequest request) =>
		PostAsync("/identity_verification/get", request)
			.ParseResponseAsync<IdentityVerification.IdentityVerificationGetResponse>();

	/// <summary>
	/// <para>Filter and list Identity Verifications created by your account</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity-verification/#identity_verificationlist" /></remarks>
	public Task<IdentityVerification.IdentityVerificationListResponse> IdentityVerificationListAsync(IdentityVerification.IdentityVerificationListRequest request) =>
		PostAsync("/identity_verification/list", request)
			.ParseResponseAsync<IdentityVerification.IdentityVerificationListResponse>();

	/// <summary>
	/// <para>Allow a customer to retry their Identity Verification</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity-verification/#identity_verificationretry" /></remarks>
	public Task<IdentityVerification.IdentityVerificationRetryResponse> IdentityVerificationRetryAsync(IdentityVerification.IdentityVerificationRetryRequest request) =>
		PostAsync("/identity_verification/retry", request)
			.ParseResponseAsync<IdentityVerification.IdentityVerificationRetryResponse>();

	/// <summary>
	/// <para>Try to autofill an Identity Verification based of the provided phone number, date of birth and country of residence.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity-verification/#identity_verificationautofillcreate" /></remarks>
	public Task<IdentityVerification.IdentityVerificationAutofillCreateResponse> IdentityVerificationAutofillCreateAsync(IdentityVerification.IdentityVerificationAutofillCreateRequest request) =>
		PostAsync("/identity_verification/autofill/create", request)
			.ParseResponseAsync<IdentityVerification.IdentityVerificationAutofillCreateResponse>();

}
