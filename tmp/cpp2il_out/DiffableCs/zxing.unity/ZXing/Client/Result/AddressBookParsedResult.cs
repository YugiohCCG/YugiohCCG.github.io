namespace ZXing.Client.Result;

public sealed class AddressBookParsedResult : ParsedResult
{
	private readonly String[] names; //Field offset: 0x20
	private readonly String[] nicknames; //Field offset: 0x28
	private readonly string pronunciation; //Field offset: 0x30
	private readonly String[] phoneNumbers; //Field offset: 0x38
	private readonly String[] phoneTypes; //Field offset: 0x40
	private readonly String[] emails; //Field offset: 0x48
	private readonly String[] emailTypes; //Field offset: 0x50
	private readonly string instantMessenger; //Field offset: 0x58
	private readonly string note; //Field offset: 0x60
	private readonly String[] addresses; //Field offset: 0x68
	private readonly String[] addressTypes; //Field offset: 0x70
	private readonly string org; //Field offset: 0x78
	private readonly string birthday; //Field offset: 0x80
	private readonly string title; //Field offset: 0x88
	private readonly String[] urls; //Field offset: 0x90
	private readonly String[] geo; //Field offset: 0x98

	public String[] Addresses
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] AddressTypes
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Birthday
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public String[] Emails
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public String[] EmailTypes
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] Geo
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string InstantMessenger
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] Names
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] Nicknames
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Note
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Org
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] PhoneNumbers
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public String[] PhoneTypes
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Pronunciation
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string Title
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public String[] URLs
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AddressBookParsedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(string), typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[]), typeof(string), typeof(string), typeof(String[]), typeof(String[]), typeof(string), typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(void))]
	public AddressBookParsedResult(String[] names, String[] phoneNumbers, String[] phoneTypes, String[] emails, String[] emailTypes, String[] addresses, String[] addressTypes) { }

	[CalledBy(Type = typeof(AddressBookAUResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(AddressBookDoCoMoResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(AddressBookParsedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BizcardResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CalledBy(Type = typeof(VCardResultParser), Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(ParsedResult))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AddressBookParsedResult), Member = "getDisplayResult", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public AddressBookParsedResult(String[] names, String[] nicknames, string pronunciation, String[] phoneNumbers, String[] phoneTypes, String[] emails, String[] emailTypes, string instantMessenger, string note, String[] addresses, String[] addressTypes, string org, string birthday, string title, String[] urls, String[] geo) { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public String[] get_Addresses() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public String[] get_AddressTypes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_Birthday() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public String[] get_Emails() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public String[] get_EmailTypes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public String[] get_Geo() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_InstantMessenger() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public String[] get_Names() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public String[] get_Nicknames() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public string get_Note() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public string get_Org() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public String[] get_PhoneNumbers() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public String[] get_PhoneTypes() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_Pronunciation() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_Title() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public String[] get_URLs() { }

	[CalledBy(Type = typeof(AddressBookParsedResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(string), typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[]), typeof(string), typeof(string), typeof(String[]), typeof(String[]), typeof(string), typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 2)]
	private string getDisplayResult() { }

}

