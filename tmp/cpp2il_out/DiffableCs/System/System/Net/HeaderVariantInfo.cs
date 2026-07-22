namespace System.Net;

internal struct HeaderVariantInfo
{
	private string m_name; //Field offset: 0x0
	private CookieVariant m_variant; //Field offset: 0x8

	internal string Name
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal CookieVariant Variant
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal HeaderVariantInfo(string name, CookieVariant variant) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	internal string get_Name() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	internal CookieVariant get_Variant() { }

}

