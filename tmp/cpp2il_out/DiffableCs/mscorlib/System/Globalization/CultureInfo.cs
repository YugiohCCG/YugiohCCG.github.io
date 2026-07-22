namespace System.Globalization;

[ComVisible(True)]
public class CultureInfo : ICloneable, IFormatProvider
{
	private struct Data
	{
		public int ansi; //Field offset: 0x0
		public int ebcdic; //Field offset: 0x4
		public int mac; //Field offset: 0x8
		public int oem; //Field offset: 0xC
		public bool right_to_left; //Field offset: 0x10
		public byte list_sep; //Field offset: 0x11

	}

	private sealed class OnCultureInfoChangedDelegate : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public OnCultureInfoChangedDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(string language) { }

	}

	private static CultureInfo invariant_culture_info; //Field offset: 0x0
	private const string MSG_READONLY = "This instance is read only"; //Field offset: 0x0
	internal const int LOCALE_INVARIANT = 127; //Field offset: 0x0
	private const int CalendarTypeBits = 8; //Field offset: 0x0
	internal const int InvariantCultureId = 127; //Field offset: 0x0
	private static object shared_table_lock; //Field offset: 0x8
	private static CultureInfo default_current_culture; //Field offset: 0x10
	private static CultureInfo s_DefaultThreadCurrentUICulture; //Field offset: 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; //Field offset: 0x20
	private static Dictionary<Int32, CultureInfo> shared_by_number; //Field offset: 0x28
	private static Dictionary<String, CultureInfo> shared_by_name; //Field offset: 0x30
	private static CultureInfo s_UserPreferredCultureInfoInAppX; //Field offset: 0x38
	internal static readonly bool IsTaiwanSku; //Field offset: 0x40
	private bool m_isReadOnly; //Field offset: 0x10
	private int cultureID; //Field offset: 0x14
	private int parent_lcid; //Field offset: 0x18
	private int datetime_index; //Field offset: 0x1C
	private int number_index; //Field offset: 0x20
	private int default_calendar_type; //Field offset: 0x24
	private bool m_useUserOverride; //Field offset: 0x28
	internal NumberFormatInfo numInfo; //Field offset: 0x30
	internal DateTimeFormatInfo dateTimeInfo; //Field offset: 0x38
	private TextInfo textInfo; //Field offset: 0x40
	internal string m_name; //Field offset: 0x48
	private string englishname; //Field offset: 0x50
	private string nativename; //Field offset: 0x58
	private string iso3lang; //Field offset: 0x60
	private string iso2lang; //Field offset: 0x68
	private string win3lang; //Field offset: 0x70
	private string territory; //Field offset: 0x78
	private String[] native_calendar_names; //Field offset: 0x80
	private CompareInfo compareInfo; //Field offset: 0x88
	private readonly Void* textinfo_data; //Field offset: 0x90
	private int m_dataItem; //Field offset: 0x98
	private Calendar calendar; //Field offset: 0xA0
	private CultureInfo parent_culture; //Field offset: 0xA8
	private bool constructed; //Field offset: 0xB0
	internal Byte[] cached_serialized_form; //Field offset: 0xB8
	internal CultureData m_cultureData; //Field offset: 0xC0
	internal bool m_isInherited; //Field offset: 0xC8

	internal CultureData _cultureData
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool _isInherited
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal string _name
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
	}

	public override Calendar Calendar
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "CreateCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Calendar))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 152
	}

	internal int CalendarType
	{
		[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal get { } //Length: 152
	}

	public override CompareInfo CompareInfo
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CompareInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 324
	}

	public static CultureInfo CurrentCulture
	{
		[CallerCount(Count = 176)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 35
	}

	public static CultureInfo CurrentUICulture
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "CheckConsistency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "ZXing.ResultPoint", Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "NGettext.Catalog", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "NGettext.Catalog", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"NGettext.Loaders.ILoader"}, ReturnType = typeof(void))]
		[CalledBy(Type = "NGettext.Catalog", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[CalledBy(Type = "NGettext.Catalog", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(Thread), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 35
	}

	public override DateTimeFormatInfo DateTimeFormat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(Calendar)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 388
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 11)]
		 set { } //Length: 227
	}

	public static CultureInfo DefaultThreadCurrentCulture
	{
		[CalledBy(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 90
	}

	public static CultureInfo DefaultThreadCurrentUICulture
	{
		[CalledBy(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 90
	}

	public override string EnglishName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 53
	}

	public static CultureInfo InvariantCulture
	{
		[CallerCount(Count = 1221)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 89
	}

	public override bool IsNeutralCulture
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 61
	}

	public override int LCID
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override string Name
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public override NumberFormatInfo NumberFormat
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 165
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 11)]
		 set { } //Length: 227
	}

	public override CultureInfo Parent
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 702
	}

	internal string SortName
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
	}

	internal string Territory
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public override TextInfo TextInfo
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 336
	}

	public override string TwoLetterISOLanguageName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 53
	}

	internal static CultureInfo UserDefaultCulture
	{
		[CalledBy(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
		internal get { } //Length: 64
	}

	internal static CultureInfo UserDefaultUICulture
	{
		[CalledBy(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
		internal get { } //Length: 113
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	private static CultureInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private CultureInfo() { }

	[CalledBy(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_Parent", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "OnCultureInfoChangedInAppX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CultureInfo), Member = "CreateNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructLocaleFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private CultureInfo(string name, bool useUserOverride, bool read_only) { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public CultureInfo(string name, bool useUserOverride) { }

	[CalledBy(Type = typeof(JapaneseCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaiwanCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.XMLSchema", Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Xml.XmlAttributeCollection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "SetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Xml.XmlAttribute[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement", "System.Xml.Schema.XmlSchemaComplexType", typeof(bool)}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public CultureInfo(string name) { }

	[CalledBy(Type = typeof(CultureInfo), Member = "get_Parent", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCultureFromNeutral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private CultureInfo(int culture, bool useUserOverride, bool read_only) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public CultureInfo(int culture, bool useUserOverride) { }

	[CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataSet", Member = "DeserializeDataSetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataTable", Member = "DeserializeTableSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	public CultureInfo(int culture) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private void CheckNeutral() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "Clone", ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public override object Clone() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Construct() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool construct_internal_locale_from_lcid(int lcid) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool construct_internal_locale_from_name(string name) { }

	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructCurrentUICulture", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_UserDefaultUICulture", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_UserDefaultCulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 2)]
	internal static CultureInfo ConstructCurrentCulture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
	internal static CultureInfo ConstructCurrentUICulture() { }

	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(TextInfo), Member = "get_Invariant", ReturnType = typeof(TextInfo))]
	[CallsUnknownMethods(Count = 16)]
	private void ConstructInvariant(bool read_only) { }

	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private bool ConstructLocaleFromName(string name) { }

	[CalledBy(Type = typeof(CultureInfo), Member = "get_Calendar", ReturnType = typeof(Calendar))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GregorianCalendar), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GregorianCalendarTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static Calendar CreateCalendar(int calendarType) { }

	[CalledBy(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private static Exception CreateNotFoundException(string name) { }

	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructLocaleFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "CreateSpecificCultureFromNeutral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "CreateNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public static CultureInfo CreateSpecificCulture(string name) { }

	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 133)]
	[CallsUnknownMethods(Count = 5)]
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private TextInfo CreateTextInfo(bool readOnly) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal CultureData get__cultureData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get__isInherited() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal string get__name() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "CreateCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Calendar))]
	[CallsUnknownMethods(Count = 2)]
	public override Calendar get_Calendar() { }

	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal int get_CalendarType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CompareInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public override CompareInfo get_CompareInfo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static string get_current_locale_name() { }

	[CallerCount(Count = 176)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 1)]
	public static CultureInfo get_CurrentCulture() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "CheckConsistency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.ResultPoint", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "NGettext.Catalog", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "NGettext.Catalog", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"NGettext.Loaders.ILoader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "NGettext.Catalog", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = "NGettext.Catalog", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 1)]
	public static CultureInfo get_CurrentUICulture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override DateTimeFormatInfo get_DateTimeFormat() { }

	[CalledBy(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	[CalledBy(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_EnglishName() { }

	[CallerCount(Count = 1221)]
	[CallsUnknownMethods(Count = 1)]
	public static CultureInfo get_InvariantCulture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsNeutralCulture() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public override int get_LCID() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public override string get_Name() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override NumberFormatInfo get_NumberFormat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public override CultureInfo get_Parent() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal string get_SortName() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal string get_Territory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public override TextInfo get_TextInfo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_TwoLetterISOLanguageName() { }

	[CalledBy(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
	internal static CultureInfo get_UserDefaultCulture() { }

	[CalledBy(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
	internal static CultureInfo get_UserDefaultUICulture() { }

	[CalledBy(Type = typeof(CompareInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlString", Member = "SetCompareInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "insert_into_shared_tables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static CultureInfo GetCultureInfo(int culture) { }

	[CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(UltimateResourceFallbackLocation&)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CalendarData), Member = "GetCalendarData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
	[CalledBy(Type = typeof(TextInfo), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
	[CalledBy(Type = typeof(CompareInfo), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "GetCompareInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CompareInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "insert_into_shared_tables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static CultureInfo GetCultureInfo(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	[CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext"}, ReturnType = "System.ComponentModel.TypeConverter+StandardValuesCollection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	public override object GetFormat(Type formatType) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	private Data GetTextInfoData() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void insert_into_shared_tables(CultureInfo c) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(OnCultureInfoChangedDelegate))]
	private static void OnCultureInfoChangedInAppX(string language) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public override void set_DateTimeFormat(DateTimeFormatInfo value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public override void set_NumberFormat(NumberFormatInfo value) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

