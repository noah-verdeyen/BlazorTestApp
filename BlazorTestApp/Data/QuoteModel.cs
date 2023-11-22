namespace BlazorTestApp.Data
{
	public class QuoteModel
	{
		public DateTime QuoteSentDate { get; set; }
		public string? SalesRep { get; set; }
		public string? ProjectName { get; set; }
		public string? ProjectCode { get; set; }
		public string? Customer { get; set; }
		public string? CustomerCity { get; set; }
		public string? CustomerState { get; set; }
		public string? MarketingCategory { get; set; }
		public double NumberOfQuotes { get; set; }
		public double TotalNetQuote { get; set; }

	}
}
