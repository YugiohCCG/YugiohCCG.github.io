namespace ZXing.Client.Result;

public class ExpandedProductParsedResult : ParsedResult
{
	public static string KILOGRAM; //Field offset: 0x0
	public static string POUND; //Field offset: 0x8
	private readonly string rawText; //Field offset: 0x20
	private readonly string productID; //Field offset: 0x28
	private readonly string sscc; //Field offset: 0x30
	private readonly string lotNumber; //Field offset: 0x38
	private readonly string productionDate; //Field offset: 0x40
	private readonly string packagingDate; //Field offset: 0x48
	private readonly string bestBeforeDate; //Field offset: 0x50
	private readonly string expirationDate; //Field offset: 0x58
	private readonly string weight; //Field offset: 0x60
	private readonly string weightType; //Field offset: 0x68
	private readonly string weightIncrement; //Field offset: 0x70
	private readonly string price; //Field offset: 0x78
	private readonly string priceIncrement; //Field offset: 0x80
	private readonly string priceCurrency; //Field offset: 0x88
	private readonly IDictionary<String, String> uncommonAIs; //Field offset: 0x90

	public string BestBeforeDate
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string DisplayResult
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string ExpirationDate
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string LotNumber
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string PackagingDate
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public string Price
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string PriceCurrency
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string PriceIncrement
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string ProductID
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string ProductionDate
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string RawText
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Sscc
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public IDictionary<String, String> UncommonAIs
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string Weight
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string WeightIncrement
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string WeightType
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static ExpandedProductParsedResult() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public ExpandedProductParsedResult(string rawText, string productID, string sscc, string lotNumber, string productionDate, string packagingDate, string bestBeforeDate, string expirationDate, string weight, string weightType, string weightIncrement, string price, string priceIncrement, string priceCurrency, IDictionary<String, String> uncommonAIs) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private static bool equalsOrNull(IDictionary<String, String> o1, IDictionary<String, String> o2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool equalsOrNull(object o1, object o2) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_BestBeforeDate() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual string get_DisplayResult() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_ExpirationDate() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_LotNumber() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_PackagingDate() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public string get_Price() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_PriceCurrency() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_PriceIncrement() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_ProductID() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_ProductionDate() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_RawText() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_Sscc() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public IDictionary<String, String> get_UncommonAIs() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public string get_Weight() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public string get_WeightIncrement() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public string get_WeightType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private static int hashNotNull(object o) { }

}

