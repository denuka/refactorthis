namespace RefactorThis.Persistence
{
    /// <summary>
    /// Representing Payment entity
    /// </summary>
	public class Payment
	{
		public decimal Amount { get; set; }
		public string Reference { get; set; }
	}
}