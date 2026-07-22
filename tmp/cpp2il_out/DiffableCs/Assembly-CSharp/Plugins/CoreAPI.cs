namespace Plugins;

public static class CoreAPI
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, ValueTuple`2<Int32, IntPtr>>, String> <>9__74_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal string <get_PuzzleOptions>b__74_0(KeyValuePair<String, ValueTuple`2<Int32, IntPtr>> p) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class CardReader : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public CardReader(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginInvoke(uint code, CardData* pData, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override uint EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override uint Invoke(uint code, CardData* pData) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class MessageHandler : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public MessageHandler(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(IntPtr pDuel, uint messageType, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override uint EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override uint Invoke(IntPtr pDuel, uint messageType) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class ScriptReader : MulticastDelegate
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public ScriptReader(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(string scriptName, Int32* len, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override IntPtr EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IntPtr Invoke(string scriptName, Int32* len) { }

	}

	public static string CustomScriptsPath; //Field offset: 0x0
	private const string ExternalLibraryName = "libocgcore"; //Field offset: 0x0
	private const string InternalLibraryName = "__Internal"; //Field offset: 0x0
	public const string PUZZLE_PREFIX = "Puzzle_"; //Field offset: 0x0
	public static bool UseExternalLibrary; //Field offset: 0x8
	private static CardReader creader; //Field offset: 0x10
	private static ScriptReader sreader; //Field offset: 0x18
	private static MessageHandler mhandler; //Field offset: 0x20
	private static IntPtr Buffer; //Field offset: 0x28
	private static readonly Dictionary<String, ValueTuple`2<Int32, IntPtr>> CardScripts; //Field offset: 0x30
	private static readonly Dictionary<String, ValueTuple`2<Int32, IntPtr>> PuzzleScripts; //Field offset: 0x38
	private static bool CoreInited; //Field offset: 0x40

	public static IEnumerable<String> PuzzleOptions
	{
		[CalledBy(Type = typeof(GameRoom), Member = "InitializePuzzle", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 320
	}

	public static string RandomPuzzleName
	{
		[CalledBy(Type = typeof(Packet), Member = "SetPuzzle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BinaryWriter))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 437
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static CoreAPI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	public static void ClearScriptMemory(ValueTuple<Int32, IntPtr> ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	private static void ClearScriptsMemory() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create_duel(uint seed) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create_duel_V2(UInt32[] seed) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static IntPtr CreateDuel(uint seed) { }

	[CalledBy(Type = typeof(LocalDuel), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(LocalGame)}, ReturnType = typeof(LocalDuel))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static IntPtr CreateDuelV2(UInt32[] seed) { }

	[CalledBy(Type = typeof(CoreAPI), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Application), Member = "get_isMobilePlatform", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Helper), Member = "get_IsWindows", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FileInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static void DefineNativeCore() { }

	[CalledBy(Type = "Game.Local.LocalDuel+<ProcessDuel>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int DoProcess() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void End_duel(IntPtr pduel) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<End>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void EndDuel() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr ext_Create_duel(uint seed) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr ext_Create_duel_V2(UInt32[] seed) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_End_duel(IntPtr pduel) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_Get_log_message(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ext_Get_message(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_New_card(IntPtr pduel, uint code, byte owner, byte playerid, byte location, byte sequence, byte position, uint rarity, uint sleeverarity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_New_tag_card(IntPtr pduel, uint code, byte owner, byte location, byte pid, uint rarity, uint sleeverarity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ext_Preload_script(IntPtr pduel, IntPtr script) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ext_Process(IntPtr pduel) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ext_Query_card(IntPtr pduel, byte playerid, byte location, byte sequence, int queryFlag, IntPtr buf, int useCache) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ext_Query_field_card(IntPtr pduel, byte playerid, byte location, int queryFlag, IntPtr buf, int useCache) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ext_Query_field_count(IntPtr pduel, byte playerid, byte location) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int ext_Query_field_info(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_Set_card_reader(CardReader f) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_Set_message_handler(MessageHandler f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_Set_player_info(IntPtr pduel, int playerid, int lp, int startcount, int drawcount, uint tokenrarity, uint sleeverarity) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_Set_responseb(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_Set_responsei(IntPtr pduel, uint value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_Set_script_reader(ScriptReader f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ext_Start_duel(IntPtr pduel, int options) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Get_log_message(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Get_message(IntPtr pduel, IntPtr buf) { }

	[CalledBy(Type = typeof(GameRoom), Member = "InitializePuzzle", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<String> get_PuzzleOptions() { }

	[CalledBy(Type = typeof(Packet), Member = "SetPuzzle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BinaryWriter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string get_RandomPuzzleName() { }

	[CalledBy(Type = "Game.Local.LocalDuel+<OnMessage>d__26", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void GetLogMessage(IntPtr buffer) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<ProcessDuel>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int GetMessage(IntPtr buffer) { }

	[CalledBy(Type = "Manager.Helper+<DatabaseDeserialize>d__126", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CoreAPI), Member = "DefineNativeCore", ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	public static void Init() { }

	[CallerCount(Count = 0)]
	private static IntPtr int_Create_duel(uint seed) { }

	[CallerCount(Count = 0)]
	private static IntPtr int_Create_duel_V2(UInt32[] seed) { }

	[CallerCount(Count = 0)]
	private static void int_End_duel(IntPtr pduel) { }

	[CallerCount(Count = 0)]
	private static void int_Get_log_message(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	private static int int_Get_message(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	private static void int_New_card(IntPtr pduel, uint code, byte owner, byte playerid, byte location, byte sequence, byte position, uint rarity, uint sleeverarity) { }

	[CallerCount(Count = 0)]
	private static void int_New_tag_card(IntPtr pduel, uint code, byte owner, byte location, byte pid, uint rarity, uint sleeverarity) { }

	[CallerCount(Count = 0)]
	private static int int_Preload_script(IntPtr pduel, IntPtr script) { }

	[CallerCount(Count = 0)]
	private static int int_Process(IntPtr pduel) { }

	[CallerCount(Count = 0)]
	private static int int_Query_card(IntPtr pduel, byte playerid, byte location, byte sequence, int queryFlag, IntPtr buf, int useCache) { }

	[CallerCount(Count = 0)]
	private static int int_Query_field_card(IntPtr pduel, byte playerid, byte location, int queryFlag, IntPtr buf, int useCache) { }

	[CallerCount(Count = 0)]
	private static int int_Query_field_count(IntPtr pduel, byte playerid, byte location) { }

	[CallerCount(Count = 0)]
	private static int int_Query_field_info(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void int_Set_card_reader(CardReader f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void int_Set_message_handler(MessageHandler f) { }

	[CallerCount(Count = 0)]
	private static void int_Set_player_info(IntPtr pduel, int playerid, int lp, int startcount, int drawcount, uint tokenrarity, uint sleeverarity) { }

	[CallerCount(Count = 0)]
	private static void int_Set_responseb(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	private static void int_Set_responsei(IntPtr pduel, uint value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void int_Set_script_reader(ScriptReader f) { }

	[CallerCount(Count = 0)]
	private static void int_Start_duel(IntPtr pduel, int options) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void New_card(IntPtr pduel, uint code, byte owner, byte playerid, byte location, byte sequence, byte position, uint rarity = 0, uint sleeverarity = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void New_tag_card(IntPtr pduel, uint code, byte owner, byte location, byte pid, uint rarity = 0, uint sleeverarity = 0) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<AddCard>d__9", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void NewCard(uint code, byte owner, byte playerid, byte location, byte sequence, byte position) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<AddTagCard>d__10", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void NewTagCard(uint code, byte owner, byte location, byte pid) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[MonoPInvokeCallback(typeof(CardReader))]
	public static uint OnCardReader(uint code, CardData* pData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDuel), Member = "OnMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(MessageHandler))]
	public static uint OnMessageHandler(IntPtr pDuel, uint messageType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_Script", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Card), Member = "get_ScriptLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback(typeof(ScriptReader))]
	public static IntPtr OnScriptReader(string scriptName, Int32* len) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Preload_script(IntPtr pduel, IntPtr script) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<PreloadScript>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IntPtr), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void PreloadScript(string scriptName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Process(IntPtr pduel) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Query_card(IntPtr pduel, byte playerid, byte location, byte sequence, int queryFlag, IntPtr buf, int useCache) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Query_field_card(IntPtr pduel, byte playerid, byte location, int queryFlag, IntPtr buf, int useCache) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Query_field_count(IntPtr pduel, byte playerid, byte location) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int Query_field_info(IntPtr pduel, IntPtr buf) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<QueryCard>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int QueryCard(byte playerid, byte location, byte sequence, int queryFlag, IntPtr buffer, int useCache) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<QueryFieldCard>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int QueryFieldCard(byte player, byte location, int flag, IntPtr buffer, int useCache) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<QueryFieldCount>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int QueryFieldCount(byte player, byte location) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<QueryFieldInfo>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static int QueryFieldInfo(IntPtr buffer) { }

	[CalledBy(Type = "Card.Manager+<LoadCustomScript>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "ReadScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scripts)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(General), Member = "ToPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.IntPtr>))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<System.Int32, System.IntPtr>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.ValueTuple`2<System.Int32, System.IntPtr>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static void ReadScript(string name, Byte[] scpt) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void Set_card_reader(CardReader f) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void Set_message_handler(MessageHandler f) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Set_player_info(IntPtr pduel, int playerid, int lp, int startcount, int drawcount, uint tokenrarity = 0, uint sleeverarity = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Set_responseb(IntPtr pduel, IntPtr buf) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Set_responsei(IntPtr pduel, uint value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void Set_script_reader(ScriptReader f) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<InitPlayers>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetPlayerInfo(int playerid, int lp, int startcount, int drawcount) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<SetResponse>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetResponse(IntPtr buffer) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<SetResponse>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void SetResponse(uint value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Start_duel(IntPtr pduel, int options) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<Start>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void StartDuel(int options) { }

}

