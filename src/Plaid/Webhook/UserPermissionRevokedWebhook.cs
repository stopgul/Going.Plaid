namespace Going.Plaid.Webhook;

/// <summary>
/// <para>The <c>USER_PERMISSION_REVOKED</c> webhook may be fired when an end user has used either the <a href="https://my.plaid.com">my.plaid.com portal</a> or the financial institution’s OAuth consent portal to revoke the permission that they previously granted to access an Item. This webhook is not guaranteed to always be fired upon consent revocation, since some institutions’ consent portals do not trigger this webhook. Once access to an Item has been revoked, it cannot be restored. If the user subsequently returns to your application, a new Item must be created for the user.</para>
/// <para>Note that when using ACH flows with Chase Items specifically, the account number provided by Plaid will no longer work for creating transfers once user permission has been revoked. If you receive this webhook for a Chase Item, you should not create any new ACH transfers for that Item, as they will be returned.</para>
/// </summary>
public record UserPermissionRevokedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UserPermissionRevoked;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

}
