namespace Card;

public class CardLocalization
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DBTextHeader, KeyValuePair`2<DBTextHeader, StringBuilder>> <>9__48_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<DBTextHeader, StringBuilder>, DBTextHeader> <>9__48_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<DBTextHeader, StringBuilder>, StringBuilder> <>9__48_2; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal KeyValuePair<DBTextHeader, StringBuilder> <.ctor>b__48_0(DBTextHeader h) { }

		[CallerCount(Count = 0)]
		internal DBTextHeader <.ctor>b__48_1(KeyValuePair<DBTextHeader, StringBuilder> k) { }

		[CallerCount(Count = 0)]
		internal StringBuilder <.ctor>b__48_2(KeyValuePair<DBTextHeader, StringBuilder> k) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass16_0
	{
		public bool dynamic; //Field offset: 0x0
		public ClientCard cc; //Field offset: 0x8

	}

	public const string PendulumHeader = "【"; //Field offset: 0x0
	private const string BOLD_INDICATION_CLOSE = "[/b]"; //Field offset: 0x0
	private const string BOLD_INDICATOR_OPEN = "[b]"; //Field offset: 0x0
	private static readonly String[] RUSH_TAGS; //Field offset: 0x0
	public const string RequirementHeader = "®"; //Field offset: 0x0
	public const string MonsterHeader = "】"; //Field offset: 0x0
	private const string OPEN_BOLD = "<b>"; //Field offset: 0x0
	private const string CLOSE_BOLD = "</b>"; //Field offset: 0x0
	[CompilerGenerated]
	private Card <CardData>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Description>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <PendulumDescription>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <CleanDescription>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <CleanPendulumDescription>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private String[] <Strings>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsTranslated>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <DefaultName>k__BackingField; //Field offset: 0x50

	public string AlphaColor
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CardLocalization), Member = "get_Color", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 70
	}

	public private Card CardData
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private string CleanDescription
	{
		[CallerCount(Count = 62)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private string CleanPendulumDescription
	{
		[CallerCount(Count = 38)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public string Color
	{
		[CalledBy(Type = typeof(DisplayCard), Member = "SetupBox", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardLocalization), Member = "get_AlphaColor", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(CardLocalization), Member = "get_HighlightedName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 416
	}

	public string ColoredName
	{
		[CalledBy(Type = typeof(CardOptionList), Member = "OnActivate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "ManualSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DuelManager), Member = "PostSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.ClientCard, System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>>), typeof(bool), typeof(bool), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSummoning>d__199", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSummoned>d__202", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSpSummoning>d__203", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnAttackDisabled>d__137", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnAttack>d__135", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnMissedTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnCardAttackDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnCardTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LogManager), Member = "OnCardAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CardLocalization), Member = "get_Color", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 274
	}

	public private string DefaultName
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private string Description
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public string HighlightedName
	{
		[CalledBy(Type = typeof(ChatWindow), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CardLocalization), Member = "get_Color", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 274
	}

	public bool IsTranslated
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public private string Name
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public private string PendulumDescription
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	private String[] Strings
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	private static CardLocalization() { }

	[CalledBy(Type = "Card.Manager+<>c__DisplayClass47_0", Member = "<InitCardLocalization>g__parseCard|0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(Texts)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<>c__DisplayClass47_0", Member = "<InitCardLocalization>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texts)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<>c__DisplayClass47_0", Member = "<InitCardLocalization>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texts)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextDataManager), Member = "GetSystemText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey", "TElement"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>"}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ByteEnum, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ByteEnum"}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 26)]
	public CardLocalization(Card card, string name, string description, String[] strings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	internal static bool <StarText>g__hasType|16_0(CardType type, ref <>c__DisplayClass16_0 unnamed_param_1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string ClearItallic(in string txt) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private void ClearRushDescriptionTags() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CardLocalization), Member = "get_Color", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public string get_AlphaColor() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Card get_CardData() { }

	[CallerCount(Count = 62)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_CleanDescription() { }

	[CallerCount(Count = 38)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_CleanPendulumDescription() { }

	[CalledBy(Type = typeof(DisplayCard), Member = "SetupBox", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CardLocalization), Member = "get_AlphaColor", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CardLocalization), Member = "get_ColoredName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CardLocalization), Member = "get_HighlightedName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public string get_Color() { }

	[CalledBy(Type = typeof(CardOptionList), Member = "OnActivate", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardAttack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnCardAttackDisabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LogManager), Member = "OnMissedTiming", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAttackDisabled>d__137", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnAttack>d__135", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSelectPlace>d__176", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoning>d__203", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSummoned>d__202", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSummoning>d__199", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "PostSelectChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.ClientCard, System.Collections.Generic.List`1<System.ValueTuple`2<System.Int32, System.Int32>>>), typeof(bool), typeof(bool), typeof(ClientCard), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DuelManager), Member = "ManualSelectPlace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientCard), typeof(bool), typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CardLocalization), Member = "get_Color", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public string get_ColoredName() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_DefaultName() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Description() { }

	[CalledBy(Type = typeof(ChatWindow), Member = "OnChatMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChatWindow), Member = "ParseCardInMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(String&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CardLocalization), Member = "get_Color", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public string get_HighlightedName() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsTranslated() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_PendulumDescription() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private String[] get_Strings() { }

	[CalledBy(Type = typeof(Localization), Member = "GetGameDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(String[])}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	public bool GetCardString(int id, out string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string ParseBold(in string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string RemoveBold(in string str) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CardData(Card value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CleanDescription(string value) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_CleanPendulumDescription(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_DefaultName(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Description(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_IsTranslated(bool value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_PendulumDescription(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Strings(String[] value) { }

	[CalledBy(Type = typeof(Template), Member = "BuildPlainEntireCardText", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ClientCard), Member = "get_Data", ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_LinkLevel", ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public static string StarText(ClientCard cc, bool dynamic) { }

	[CalledBy(Type = typeof(Card), Member = "ChangeLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardLocalization)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 8)]
	public void Update(CardLocalization updated) { }

}

