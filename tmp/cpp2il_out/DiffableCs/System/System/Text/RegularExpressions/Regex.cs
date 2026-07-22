namespace System.Text.RegularExpressions;

public class Regex : ISerializable
{
	public sealed class CachedCodeEntry
	{
		public CachedCodeEntry Next; //Field offset: 0x10
		public CachedCodeEntry Previous; //Field offset: 0x18
		public readonly CachedCodeEntryKey Key; //Field offset: 0x20
		public RegexCode Code; //Field offset: 0x38
		public readonly Hashtable Caps; //Field offset: 0x40
		public readonly Hashtable Capnames; //Field offset: 0x48
		public readonly String[] Capslist; //Field offset: 0x50
		public readonly int Capsize; //Field offset: 0x58
		public readonly ExclusiveReference Runnerref; //Field offset: 0x60
		public readonly WeakReference<RegexReplacement> ReplRef; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public CachedCodeEntry(CachedCodeEntryKey key, Hashtable capnames, String[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref) { }

	}

	[IsReadOnly]
	public struct CachedCodeEntryKey : IEquatable<CachedCodeEntryKey>
	{
		private readonly RegexOptions _options; //Field offset: 0x0
		private readonly string _cultureKey; //Field offset: 0x8
		private readonly string _pattern; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public CachedCodeEntryKey(RegexOptions options, string cultureKey, string pattern) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		public virtual bool Equals(object obj) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override bool Equals(CachedCodeEntryKey other) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public virtual int GetHashCode() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	}

	private const int CacheDictionarySwitchLimit = 10; //Field offset: 0x0
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT"; //Field offset: 0x0
	internal const int MaxOptionShift = 10; //Field offset: 0x0
	private static int s_cacheSize; //Field offset: 0x0
	private static readonly Dictionary<CachedCodeEntryKey, CachedCodeEntry> s_cache; //Field offset: 0x8
	private static int s_cacheCount; //Field offset: 0x10
	private static CachedCodeEntry s_cacheFirst; //Field offset: 0x18
	private static CachedCodeEntry s_cacheLast; //Field offset: 0x20
	private static readonly TimeSpan s_maximumMatchTimeout; //Field offset: 0x28
	internal static readonly TimeSpan s_defaultMatchTimeout; //Field offset: 0x30
	public static readonly TimeSpan InfiniteMatchTimeout; //Field offset: 0x38
	protected private TimeSpan internalMatchTimeout; //Field offset: 0x10
	protected private string pattern; //Field offset: 0x18
	protected private RegexOptions roptions; //Field offset: 0x20
	protected private RegexRunnerFactory factory; //Field offset: 0x28
	protected private Hashtable caps; //Field offset: 0x30
	protected private Hashtable capnames; //Field offset: 0x38
	protected private String[] capslist; //Field offset: 0x40
	protected private int capsize; //Field offset: 0x48
	internal ExclusiveReference _runnerref; //Field offset: 0x50
	internal WeakReference<RegexReplacement> _replref; //Field offset: 0x58
	internal RegexCode _code; //Field offset: 0x60
	internal bool _refsInitialized; //Field offset: 0x68

	public RegexOptions Options
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public bool RightToLeft
	{
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(Regex), Member = "InitDefaultMatchTimeout", ReturnType = typeof(TimeSpan))]
	[CallsUnknownMethods(Count = 1)]
	private static Regex() { }

	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[Calls(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions)}, ReturnType = typeof(RegexTree))]
	[Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 34)]
	[ContainsUnimplementedInstructions]
	private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.ConvertUtils", Member = "TryConvertGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Guid&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "ContainsProfanity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	public Regex(string pattern) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected Regex() { }

	[CallerCount(Count = 44)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	public Regex(string pattern, RegexOptions options) { }

	[CalledBy(Type = "Extensions.General", Member = "WildCardToRegular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor+<>c", Member = "<TzolkinWinCon>b__51_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor+<>c", Member = "<TzolkinWinCon>b__51_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RegexParser), Member = "Escape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static string Escape(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FillCacheDictionary() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public RegexOptions get_Options() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_RightToLeft() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(bool)}, ReturnType = typeof(CachedCodeEntry))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	[CalledBy(Type = typeof(X509PalImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Regex), Member = "GetCachedCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(bool)}, ReturnType = typeof(CachedCodeEntry))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "LookupCachedAndPromote", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey)}, ReturnType = typeof(CachedCodeEntry))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashtableExtensions), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(object), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public string GroupNameFromNumber(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(HashtableExtensions), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hashtable), typeof(object), "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public int GroupNumberFromName(string name) { }

	[CalledBy(Type = typeof(Regex), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AppDomain), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Regex), Member = "ValidateMatchTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(void))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static TimeSpan InitDefaultMatchTimeout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected void InitializeReferences() { }

	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "CheckPatternFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.RestrictionFacets", typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "TextFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckFilters", Member = "TextFilterDescOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.Card"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_1", Member = "<UpdateDeckList>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher", Member = "MatchSingleProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "UnityEngine.InputSystem.Utilities.JsonParser+JsonValue"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "CheckLexicalFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(XmlSchemaDatatype)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.StringFacetsChecker", Member = "CheckBuiltInFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlTypeCode), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngineInternal.WebRequestUtils", Member = "MakeInitialUrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool IsMatch(string input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool IsMatch(string input, int startat) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression", Member = "RegexEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JValue", "Newtonsoft.Json.Linq.JValue", "Newtonsoft.Json.Linq.JsonSelectSettings"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor+<>c", Member = "<TzolkinWinCon>b__51_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DuelBot.Game.AI.Decks.VirtualWorldExecutor+<>c", Member = "<TzolkinWinCon>b__51_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "get_CurrentMemberSchemas", ReturnType = "System.Collections.Generic.IList`1<JsonSchemaModel>")]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "ValidateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonValidatingReader", Member = "IsPropertyDefinied", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaModel", typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Validate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool IsMatch(string input, string pattern) { }

	[CalledBy(Type = typeof(Regex), Member = "GetCachedCodeEntryInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(bool)}, ReturnType = typeof(CachedCodeEntry))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	[CalledBy(Type = "DG.Tweening.Plugins.StringPlugin", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static Match Match(string input, string pattern) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.Utilities.ConvertUtils", Member = "TryConvertGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Guid&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "NGettext.Loaders.ContentType", Member = "ParseValue", ReturnType = typeof(void))]
	[CalledBy(Type = "NGettext.Plural.AstPluralRuleGenerator", Member = "ParsePluralFormulaText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "NGettext.Plural.AstPluralRuleGenerator", Member = "ParseNumPlurals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "NGettext.Plural.AstPluralRuleGenerator", Member = "CreateRule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = "NGettext.Plural.IPluralRule")]
	[CalledBy(Type = "ZXing.Client.Result.VINResultParser", Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Result"}, ReturnType = "ZXing.Client.Result.ParsedResult")]
	[CalledBy(Type = "ZXing.Client.Result.VCardResultParser", Member = "isLikeVCardDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.Client.Result.VCardResultParser", Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Result"}, ReturnType = "ZXing.Client.Result.ParsedResult")]
	[CalledBy(Type = "ZXing.Client.Result.URIParsedResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Client.Result.URIResultParser", Member = "isBasicallyValidURI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.Client.Result.GeoResultParser", Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Result"}, ReturnType = "ZXing.Client.Result.ParsedResult")]
	[CalledBy(Type = "ZXing.Client.Result.EmailDoCoMoResultParser", Member = "isBasicallyValidEmailAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = "parseDurationMS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = "parseDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = "ZXing.Client.Result.CalendarParsedResult", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), "System.String[]", typeof(string), typeof(double), typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Client.Result.AddressBookDoCoMoResultParser", Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Result"}, ReturnType = "ZXing.Client.Result.ParsedResult")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher", Member = "MatchCustomIdent", ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.Client.Result.ResultParser", Member = "isStringOfDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[CallsUnknownMethods(Count = 4)]
	public Match Match(string input) { }

	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.Client.Result.VCardResultParser", Member = "matchVCardPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = "System.Collections.Generic.List`1<List`1<String>>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public Match Match(string input, int startat) { }

	[CalledBy(Type = "ZXing.Client.Result.ResultParser", Member = "isSubstringOfDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "ZXing.Client.Result.URIParsedResult", Member = "massageURI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "ZXing.Client.Result.URIParsedResult", Member = "isColonFollowedByPortNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public Match Match(string input, int beginning, int length) { }

	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "ContainsProfanity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public MatchCollection Matches(string input) { }

	[CalledBy(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public MatchCollection Matches(string input, int startat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	[CalledBy(Type = "Scenes.Menu.ReplayList+<>c__DisplayClass36_0", Member = "<OnClickRename>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "CensorStringByProfanityList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Collections.Generic.List`1<String>", typeof(StringBuilder), typeof(StringBuilder), typeof(bool)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = "ProfanityFilter.ProfanityFilter", Member = "CensorString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "DG.Tweening.Plugins.StringPlugin", Member = "SetChangeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Core.TweenerCore`3<String, String, StringOptions>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray128", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray64", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray256", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray16", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CalledBy(Type = "Manager.Network+<>c__DisplayClass68_0+<<OnReceiveServerReplay>b__1>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<<OnSaveReplay>b__48_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.ReplayList+<>c__DisplayClass49_0+<<ImportReplay>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.BitArray32", Member = "get_humanizedData", ReturnType = typeof(string))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 9)]
	public static string Replace(string input, string pattern, string replacement) { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+EnumField`1", Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Client.Result.VCardResultParser", Member = "matchVCardPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = "System.Collections.Generic.List`1<List`1<String>>")]
	[CalledBy(Type = "ZXing.Client.Result.VINResultParser", Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Result"}, ReturnType = "ZXing.Client.Result.ParsedResult")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public string Replace(string input, string replacement) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>), typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), typeof(RegexOptions)}, ReturnType = typeof(RegexReplacement))]
	[Calls(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public string Replace(string input, string replacement, int count, int startat) { }

	[CalledBy(Type = typeof(Match), Member = "NextMatch", ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(RegexOptions), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MatchCollection), Member = "GetMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Match))]
	[CalledBy(Type = typeof(Regex), Member = "IsMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	[CalledBy(Type = "ZXing.Client.Result.ResultParser", Member = "parseNameValuePairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Collections.Generic.IDictionary`2<String, String>")]
	[CalledBy(Type = "ZXing.Client.Result.VCardResultParser", Member = "parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"ZXing.Result"}, ReturnType = "ZXing.Client.Result.ParsedResult")]
	[CalledBy(Type = "ZXing.Client.Result.VCardResultParser", Member = "matchVCardPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = "System.Collections.Generic.List`1<List`1<String>>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Regex), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public String[] Split(string input) { }

	[CalledBy(Type = typeof(Regex), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Regex), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Regex), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Regex), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Match))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GroupCollection), Member = "GetGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Group))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 19)]
	private static String[] Split(Regex regex, string input, int count, int startat) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public String[] Split(string input, int count, int startat) { }

	[CalledBy(Type = "ZXing.Client.Result.ResultParser", Member = "appendKeyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Collections.Generic.IDictionary`2<String, String>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "ZXing.Client.Result.VCardResultParser", Member = "matchVCardPrefixedField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(bool)}, ReturnType = "System.Collections.Generic.List`1<List`1<String>>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Regex), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public String[] Split(string input, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Regex), Member = "TryGetCacheValueSmall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(CachedCodeEntry&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Text.RegularExpressions.Regex+CachedCodeEntryKey, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryGetCacheValue(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	[CalledBy(Type = typeof(Regex), Member = "TryGetCacheValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CachedCodeEntryKey), typeof(CachedCodeEntry&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, out CachedCodeEntry entry) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool UseOptionInvariant() { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	protected private bool UseOptionR() { }

	[CalledBy(Type = typeof(Regex), Member = "InitDefaultMatchTimeout", ReturnType = typeof(TimeSpan))]
	[CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RegexOptions), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(TimeSpan)}, ReturnType = typeof(Match))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TimeSpan), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan), typeof(TimeSpan)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected private static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

}

