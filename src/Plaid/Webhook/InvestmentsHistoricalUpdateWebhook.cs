namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired after an asynchronous extraction on an investments account.</para>
/// </summary>
public record InvestmentsHistoricalUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.InvestmentsTransactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.HistoricalUpdate;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>The number of new transactions reported since the last time this webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("new_investments_transactions")]
	public decimal NewInvestmentsTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The number of canceled transactions reported since the last time this webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("canceled_investments_transactions")]
	public decimal CanceledInvestmentsTransactions { get; init; } = default!;

}
