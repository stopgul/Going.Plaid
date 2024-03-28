namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/event/sync</c></para>
/// </summary>
public record TransferEventSyncResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("transfer_events")]
	public IReadOnlyList<Entity.TransferEvent> TransferEvents { get; init; } = default!;

	/// <summary>
	/// <para>Whether there are more events to be pulled from the endpoint that have not already been returned</para>
	/// </summary>
	[JsonPropertyName("has_more")]
	public bool HasMore { get; init; } = default!;

}
