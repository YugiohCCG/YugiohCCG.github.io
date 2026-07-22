namespace System.Globalization;

[ComVisible(True)]
public class RegionInfo
{
	private static RegionInfo currentRegion; //Field offset: 0x0
	private int regionId; //Field offset: 0x10
	private string iso2Name; //Field offset: 0x18
	private string iso3Name; //Field offset: 0x20
	private string win3Name; //Field offset: 0x28
	private string englishName; //Field offset: 0x30
	private string nativeName; //Field offset: 0x38
	private string currencySymbol; //Field offset: 0x40
	private string isoCurrencySymbol; //Field offset: 0x48
	private string currencyEnglishName; //Field offset: 0x50
	private string currencyNativeName; //Field offset: 0x58

	[ComVisible(False)]
	public override string CurrencyEnglishName
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[ComVisible(False)]
	public override string CurrencyNativeName
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string CurrencySymbol
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static RegionInfo CurrentRegion
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 198
	}

	[MonoTODO("DisplayName currently only returns the EnglishName")]
	public override string DisplayName
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string EnglishName
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[ComVisible(False)]
	public override int GeoId
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override bool IsMetric
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 112
	}

	public override string ISOCurrencySymbol
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public override string Name
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[ComVisible(False)]
	public override string NativeName
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string ThreeLetterISORegionName
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string ThreeLetterWindowsRegionName
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string TwoLetterISORegionName
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public RegionInfo(int culture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public RegionInfo(string name) { }

	[CalledBy(Type = typeof(RegionInfo), Member = "get_CurrentRegion", ReturnType = typeof(RegionInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private RegionInfo(CultureInfo ci) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static void ClearCachedData() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool construct_internal_region_from_name(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public override string get_CurrencyEnglishName() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public override string get_CurrencyNativeName() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override string get_CurrencySymbol() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static RegionInfo get_CurrentRegion() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override string get_DisplayName() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override string get_EnglishName() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override int get_GeoId() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsMetric() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public override string get_ISOCurrencySymbol() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override string get_Name() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public override string get_NativeName() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public override string get_ThreeLetterISORegionName() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public override string get_ThreeLetterWindowsRegionName() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override string get_TwoLetterISORegionName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool GetByTerritory(CultureInfo ci) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

