namespace Card;

public class Deck : ISerializable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__44_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<UInt16, Single>, Single> <>9__63_0; //Field offset: 0x10
		public static Func<KeyValuePair`2<Int32, Byte>, Int32> <>9__72_1; //Field offset: 0x18
		public static Func<Int32, Int32> <>9__97_0; //Field offset: 0x20
		public static Func<Int32, Single> <>9__101_0; //Field offset: 0x28
		public static Func<Int32, Single> <>9__101_1; //Field offset: 0x30
		public static Func<Int32, Single> <>9__101_2; //Field offset: 0x38
		public static Func<Int32, Int32> <>9__119_0; //Field offset: 0x40
		public static Func<IGrouping`2<Int32, Int32>, Boolean> <>9__119_1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int <Check>b__119_0(int x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		internal bool <Check>b__119_1(IGrouping<Int32, Int32> x) { }

		[CallerCount(Count = 0)]
		internal int <ClearRarity>b__72_1(KeyValuePair<Int32, Byte> x) { }

		[CallerCount(Count = 0)]
		internal float <GenerateDeckNameFromSetcodes>b__63_0(KeyValuePair<UInt16, Single> x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		internal bool <set_Tags>b__44_0(string t) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Random), Member = "get_value", ReturnType = typeof(float))]
		[DeduplicatedMethod]
		internal float <Shuffle>b__101_0(int id) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Random), Member = "get_value", ReturnType = typeof(float))]
		[DeduplicatedMethod]
		internal float <Shuffle>b__101_1(int id) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Random), Member = "get_value", ReturnType = typeof(float))]
		[DeduplicatedMethod]
		internal float <Shuffle>b__101_2(int id) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal int <SortCardList>b__97_0(int id) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass22_0
	{
		public bool tags; //Field offset: 0x0
		public bool prices; //Field offset: 0x1

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass62_0
	{
		public Dictionary<UInt16, Single> res; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public Rarity rarity; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass71_0() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <RarityCount>b__0(KeyValuePair<Int32, Byte> p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public Rarity rarity; //Field offset: 0x10
		public Func<KeyValuePair`2<Int32, Byte>, Boolean> <>9__0; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass72_0() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <ClearRarity>b__0(KeyValuePair<Int32, Byte> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public Card card; //Field offset: 0x10
		public CardType ctype; //Field offset: 0x18
		public CardAttribute cattribute; //Field offset: 0x1C
		public CardRace crace; //Field offset: 0x20
		public Category ccat; //Field offset: 0x24
		public IEnumerable<UInt16> setcodes; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass81_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "FilterByAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardAttribute)}, ReturnType = typeof(bool))]
		internal bool <GetAmountOf>g__filterByAttribute|2(int cid) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "FilterByCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Category)}, ReturnType = typeof(bool))]
		internal bool <GetAmountOf>g__filterByCategory|4(int cid) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "FilterByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Card)}, ReturnType = typeof(bool))]
		internal bool <GetAmountOf>g__filterByID|0(int cid) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "FilterByRace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardRace)}, ReturnType = typeof(bool))]
		internal bool <GetAmountOf>g__filterByRace|3(int cid) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "FilterBySetcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>)}, ReturnType = typeof(bool))]
		internal bool <GetAmountOf>g__filterBySetcode|5(int cid) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Banlist), Member = "FilterByType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CardType)}, ReturnType = typeof(bool))]
		internal bool <GetAmountOf>g__filterByType|1(int cid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass83_0
	{
		public Int32[] cards; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass83_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
		internal bool <CountOf>b__0(int id) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
		internal bool <CountOf>b__1(int id) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(int)}, ReturnType = typeof(bool))]
		internal bool <CountOf>b__2(int id) { }

	}

	[CompilerGenerated]
	private struct <Create>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Deck> <>t__builder; //Field offset: 0x8
		public string data; //Field offset: 0x20
		private Deck <d>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Deck), Member = "OmegaHashDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "ParseYDK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Deck), Member = "YDKEHashDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateFromHash>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Deck> <>t__builder; //Field offset: 0x8
		public string data; //Field offset: 0x20
		public string name; //Field offset: 0x28
		public string tags; //Field offset: 0x30
		private Deck <d>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Deck), Member = "OmegaHashDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Deck), Member = "set_Tags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateFromYDKFile>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Deck> <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		public string name; //Field offset: 0x28
		private Deck <d>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Deck), Member = "ParseYDK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FixInvalids>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Deck <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "UpdateDeckFromBetaToOfficial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Manager), Member = "FixInvalidCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Customization), Member = "SavePlayerData", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetHash>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public Deck <>4__this; //Field offset: 0x20
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(PackedBinaryData), Member = "CompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 33)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OmegaHashDecode>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string base64; //Field offset: 0x20
		public Deck <>4__this; //Field offset: 0x28
		private Byte[] <hashBuffer>5__2; //Field offset: 0x30
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(PackedBinaryData), Member = "DecompressData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ParseYDK>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isFile; //Field offset: 0x20
		public string text; //Field offset: 0x28
		public Deck <>4__this; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "set_Tags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(Helper), Member = "ReadAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.String>))]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static List<Deck> BossDecks; //Field offset: 0x0
	private const sbyte DOUBLE_EXTRA_MAX = 30; //Field offset: 0x0
	private const sbyte DOUBLE_MAIN_MIN = 100; //Field offset: 0x0
	private const sbyte DOUBLE_MAIN_MAX = 100; //Field offset: 0x0
	private const sbyte MASTER_SIDE_MAX = 15; //Field offset: 0x0
	private const sbyte MASTER_EXTRA_MAX = 15; //Field offset: 0x0
	private const sbyte MASTER_MAIN_MIN = 40; //Field offset: 0x0
	private const sbyte MASTER_MAIN_MAX = 60; //Field offset: 0x0
	private const sbyte DL_SIDE_MAX = 9; //Field offset: 0x0
	private const sbyte DL_EXTRA_MAX = 9; //Field offset: 0x0
	private const sbyte SPEED_SIDE_MAX = 6; //Field offset: 0x0
	private const sbyte SPEED_EXTRA_MAX = 6; //Field offset: 0x0
	private const sbyte SPEED_MAIN_MIN = 20; //Field offset: 0x0
	private const sbyte SPEED_MAIN_MAX = 30; //Field offset: 0x0
	private const sbyte DOUBLE_SIDE_MAX = 30; //Field offset: 0x0
	private const sbyte TRINITY_MAIN_MIN = 30; //Field offset: 0x0
	private const byte MAX_EXTRA_IGNORE = 15; //Field offset: 0x0
	private const byte MAX_MAIN_IGNORE = 60; //Field offset: 0x0
	private const float CURRENCY_MULT = 0.01; //Field offset: 0x0
	private const byte MAX_SIDE_IGNORE = 15; //Field offset: 0x0
	private static Deck _currentDeck; //Field offset: 0x8
	private static string _lastUsedDeckName; //Field offset: 0x10
	public List<Int32> Main; //Field offset: 0x10
	public List<Int32> Extra; //Field offset: 0x18
	public List<Int32> Side; //Field offset: 0x20
	private int _deckCard; //Field offset: 0x28
	public Dictionary<Int32, Byte> Rarities; //Field offset: 0x30
	public SleeveRarity CoverRarity; //Field offset: 0x38
	public string DeckName; //Field offset: 0x40
	public List<String> TagList; //Field offset: 0x48
	private bool IsSorting; //Field offset: 0x50

	public IEnumerable<Int32> AllCards
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Concat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		 get { } //Length: 81
	}

	public static Deck CurrentDeck
	{
		[CallerCount(Count = 114)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Manager), Member = "GetDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Deck))]
		[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Manager), Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 430
		[CalledBy(Type = typeof(GameRoom), Member = "SetSelectedDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager+<DeleteDeck>d__67", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager+<DeleteAllDecks>d__68", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
		[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.DuelEnd+<OnLeave>d__41", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckSelection), Member = "OnClickClose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "InitializeCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckSelection), Member = "OnClickSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxSlot)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "OnFinishSiding", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "set_SidingDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnAutoDeck>d__370", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c__DisplayClass368_0", Member = "<OnCloseButton>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "ShowCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GameRoom), Member = "OnClickRandomDeck", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "UpdateCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixInvalids>d__54)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixInvalids>d__54&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 243
	}

	public int DeckCard
	{
		[CalledBy(Type = typeof(GameRoom), Member = "SetSelectedDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyScreen), Member = "ShowCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnSaveButton>d__372", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_0", Member = "<UpdateDeckList>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPooledData))]
		[CalledBy(Type = "Card.Manager+<UpdateDeck>d__69", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
		 get { } //Length: 40
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float DeckPrice
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		 get { } //Length: 443
	}

	public float ExtraDeckPrice
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 159
	}

	public int FirstCard
	{
		[CalledBy(Type = typeof(<GetHash>d__18), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = "get_DeckCard", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Deck), Member = "GetHashSync", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(Deck)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = "UpdateInfoForCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Deck), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Manager+<UpdateDeck>d__69", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Manager), Member = "UpdateDeckFromBetaToOfficial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Deck), Member = "get_IsCompletelyEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
		 get { } //Length: 194
	}

	public bool HasTags
	{
		[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_0", Member = "<UpdateDeckList>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPooledData))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 69
	}

	public bool IsCompletelyEmpty
	{
		[CalledBy(Type = "Scenes.Deck.DeckSelection+<OnClickStatistics>d__67", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = "GetFormula", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		 get { } //Length: 137
	}

	public bool IsEmpty
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DeckSelection), Member = "OnClickExport", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClientReplay), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Manager), Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		 get { } //Length: 89
	}

	public static string LastUsedDeckName
	{
		[CalledBy(Type = typeof(DuelEnd), Member = "GoToSiding", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 172
		[CalledBy(Type = typeof(Packet), Member = "JoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Deck)}, ReturnType = typeof(BinaryWriter))]
		[CalledBy(Type = typeof(Packet), Member = "JoinTournament", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(BinaryWriter))]
		[CalledBy(Type = typeof(Packet), Member = "UpdateDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 151
	}

	public float MainDeckPrice
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 159
	}

	public string Name
	{
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(General), Member = "KeyByValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "W"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<T, W>", "W"}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 153
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string SearchableName
	{
		[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_1", Member = "<UpdateDeckList>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[Calls(Type = typeof(Deck), Member = "get_Tags", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		 get { } //Length: 132
	}

	public float SideDeckPrice
	{
		[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 159
	}

	public string Tags
	{
		[CalledBy(Type = typeof(DeckSelection), Member = "OnClickDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxSlot), typeof(PointerEventData)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Customization+<ExportSingleDeckToCSV>d__74", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(P2PManager), Member = "WriteFullDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Deck), Member = "get_YDK", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Deck), Member = "get_SearchableName", ReturnType = typeof(string))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 472
		[CalledBy(Type = "Scenes.Deck.DeckSelection+<OnChangeTags>d__55", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.P2PManager+DeckSyncRcv+<RegisterDeck>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<CreateFromHash>d__60), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<ParseYDK>d__64), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Card.DeckAPI+<RequestURLDecks>d__14", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		 set { } //Length: 490
	}

	public string YDK
	{
		[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(Deck), Member = "get_Tags", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 998
	}

	[CalledBy(Type = typeof(DecksManager), Member = "AddDeckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DuelRules), typeof(System.Func`3<DuelBot.Game.GameAI, DuelBot.Game.BotDuel, DuelBot.Game.AI.Executor>), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientReplay), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<Init>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(PackedBinaryData), Member = "DecompressDataSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public Deck(string hash) { }

	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_3", Member = "<UpdateDeckList>b__4", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickClose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
	[Calls(Type = typeof(User), Member = "get_HasRarities", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "AddRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "S"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<T, S>", "System.Collections.Generic.IDictionary`2<T, S>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "ParseRarities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IDictionary`2<System.Int32, System.Byte>), typeof(Dictionary`2<Int32, Byte>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Deck(Deck d1, Deck d2) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<OnClickReady>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c__DisplayClass368_0", Member = "<OnCloseButton>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "InitializeCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass56_0+<<OnCloneButton>b__0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "AddRange", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "S"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<T, S>", "System.Collections.Generic.IDictionary`2<T, S>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public Deck(Deck source) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public Deck(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(Packet), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
	[CalledBy(Type = typeof(LocalExt), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
	[CalledBy(Type = typeof(ClientReplay), Member = "ReceiveReplaySharing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Deck), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public Deck() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <FillRarity>b__73_0(int x) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[CompilerGenerated]
	internal static Card <GetFormula>g__get|22_0(int id) { }

	[CalledBy(Type = typeof(Deck), Member = "GetFormula", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Byte>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Byte>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(byte)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	internal static void <GetFormula>g__list|22_1(Dictionary<Card, Byte> dict, Card c) { }

	[CalledBy(Type = typeof(Deck), Member = "GetFormula", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	internal static void <GetFormula>g__write|22_2(Dictionary<Card, Byte> dict, ref StringBuilder source, ref <>c__DisplayClass22_0 unnamed_param_2) { }

	[CalledBy(Type = typeof(Deck), Member = "GetSetcodesAmount", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Single>))]
	[CalledBy(Type = typeof(Deck), Member = "GenerateDeckNameFromSetcodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(CardArchetype), Member = "get_Archetypes", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Single>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CompilerGenerated]
	internal static void <GetSetcodesAmount>g__parseDeck|62_0(List<Int32> deck, float inc, ref <>c__DisplayClass62_0 unnamed_param_2) { }

	[CalledBy(Type = typeof(Packet), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
	[CalledBy(Type = typeof(LocalExt), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AddExtra(int cardId, bool allowInvalid = false) { }

	[CalledBy(Type = typeof(Packet), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
	[CalledBy(Type = typeof(LocalExt), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsExtraCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void AddMain(int cardId, bool allowInvalid = false) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientReplay), Member = "ReceiveReplaySharing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OmegaHashDecode>d__68), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseYDK>d__64), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "YDKEHashDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "OmegaHashDecodeSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.DeckAPI+<RequestAPIDeck>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.DeckAPI+<RequestAutoDeck>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "DeckFromRecipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Deck))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsExtraCard", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void AddMain(int cardId) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.P2PManager+DeckSyncRcv+<RegisterDeck>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "ClearRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "FillRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(User), Member = "GetRarityQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool AddRarity(int cardId, Rarity rarity, bool noCheck = false) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClientReplay), Member = "ReceiveReplaySharing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OmegaHashDecode>d__68), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseYDK>d__64), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "YDKEHashDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "OmegaHashDecodeSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.DeckAPI+<RequestAutoDeck>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "DeckFromRecipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Deck))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void AddSide(int cardId) { }

	[CalledBy(Type = typeof(Packet), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
	[CalledBy(Type = typeof(LocalExt), Member = "ReadDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(bool)}, ReturnType = typeof(Deck))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void AddSide(int cardId, bool allowInvalid = false) { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static bool AddToCards(Dictionary<Int32, Byte> cards, Card card) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(Banlist), Member = "GetMaxQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte&)}, ReturnType = typeof(BanScope))]
	[Calls(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Banlist), Member = "GetAllIDsMaxLimited", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public int CanAddCard(int cardId) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<OnClickReady>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnFinishSiding", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Localization), Member = "GetClientMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MessageBox), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool Check(int result) { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(GameSettings)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Card.Manager+<>c__DisplayClass78_0", Member = "<RandomDeckForRules>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CardArchetype), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardArchetype)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Deck), Member = "AddToCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), typeof(Card)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsTrinityUnbound", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Category)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsIllegal", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsRushLegend", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsRushCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsTCG", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "GetMaxQuantity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte&)}, ReturnType = typeof(BanScope))]
	[Calls(Type = typeof(Card), Member = "get_IsWCS", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "CheckInCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(byte), typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Concat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "GroupBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<IGrouping`2<TKey, TSource>>")]
	[Calls(Type = typeof(Card), Member = "get_IsOCG", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_IsCommon", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "GetReleaseDateFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Card), Member = "get_NeedScript", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_HasScript", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Banlist), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTuple`2<SByte, SByte>&), typeof(BanflagLocation)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "get_ForceUseOCGDate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "get_ForceUseTCGDate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Banlist), Member = "DeckCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	public int Check(Banlist ban, byte gameOt, DateTime from, DateTime to, DuelRules duelRule = 0, ExtraRules extraRule = 0, int maxBudget = 0) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<OnClickReady>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnFinishSiding", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_2", Member = "<UpdateDeckList>b__2", ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_2", Member = "<UpdateDeckList>b__3", ReturnType = typeof(bool))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_3", Member = "<UpdateDeckList>b__4", ReturnType = typeof(bool))]
	[CalledBy(Type = "Game.Local.LocalGame+<SetReady>d__158", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<UpdatePlayerDeck>d__51", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	public int Check(Banlist ban, GameSettings settings) { }

	[CalledBy(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(byte), typeof(DateTime), typeof(DateTime), typeof(DuelRules), typeof(ExtraRules), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "get_Alias", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool CheckInCards(Card c, byte quantity, Dictionary<Int32, Byte> cards) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "<OnEmptyButton>b__388_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void ClearDeck() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "ClearRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(Deck), Member = "AddRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Rarity), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool ClearRarity(Rarity rarity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public int CountOf(bool includeSide, Int32[] cards) { }

	[AsyncStateMachine(typeof(<Create>d__61))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<<OnClickImport>b__75_3>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey+<PasteDeckFromClipboard>d__88", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+DeckSyncRcv+<RegisterDeck>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnAddDeck>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+<OnSetCustomBotData>d__83", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__61)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Create>d__61&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task<Deck> Create(string data) { }

	[AsyncStateMachine(typeof(<CreateFromHash>d__60))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<ImportSingleFromCSV>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateFromHash>d__60)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateFromHash>d__60&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static Task<Deck> CreateFromHash(string data, string name, string tags) { }

	[AsyncStateMachine(typeof(<CreateFromYDKFile>d__59))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<ImportSingleFromYDK>d__70", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateFromYDKFile>d__59)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateFromYDKFile>d__59&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Task<Deck> CreateFromYDKFile(string path, string name) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool DefineDeckCard(int id) { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom+<OnClickReady>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnCloseButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<UpdatePlayerDeck>d__51", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 32)]
	public bool Equals(Deck deck, bool forSiding = false) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "FillRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Union", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Deck), Member = "AddRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Rarity), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public bool FillRarity(Rarity rarity) { }

	[AsyncStateMachine(typeof(<FixInvalids>d__54))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixInvalids>d__54)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixInvalids>d__54&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void FixInvalids() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "<GetSetcodesAmount>g__parseDeck|62_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(float), typeof(<>c__DisplayClass62_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Func`2<System.Collections.Generic.KeyValuePair`2<System.UInt16, System.Single>, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(TextDataManager), Member = "TryGetSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(String&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.UInt16, System.Single>)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.UInt16, System.Single>>), typeof(int)}, ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.UInt16, System.Single>))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public string GenerateDeckNameFromSetcodes(int maxNames = 3, int minCount = -1) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Concat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	public IEnumerable<Int32> get_AllCards() { }

	[CallerCount(Count = 114)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Manager), Member = "GetDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Deck))]
	[Calls(Type = typeof(Deck), Member = "set_CurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static Deck get_CurrentDeck() { }

	[CalledBy(Type = typeof(GameRoom), Member = "SetSelectedDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "ShowCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnEnable>d__310", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnSaveButton>d__372", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineDeckCardButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_0", Member = "<UpdateDeckList>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPooledData))]
	[CalledBy(Type = "Card.Manager+<UpdateDeck>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
	public int get_DeckCard() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	public float get_DeckPrice() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public float get_ExtraDeckPrice() { }

	[CalledBy(Type = typeof(<GetHash>d__18), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "get_DeckCard", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Deck), Member = "GetHashSync", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "UpdateInfoForCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<UpdateDeck>d__69", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "UpdateDeckFromBetaToOfficial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Deck), Member = "get_IsCompletelyEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	public int get_FirstCard() { }

	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_0", Member = "<UpdateDeckList>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPooledData))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_HasTags() { }

	[CalledBy(Type = "Scenes.Deck.DeckSelection+<OnClickStatistics>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "GetFormula", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	public bool get_IsCompletelyEmpty() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickExport", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClientReplay), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	public bool get_IsEmpty() { }

	[CalledBy(Type = typeof(DuelEnd), Member = "GoToSiding", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public static string get_LastUsedDeckName() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public float get_MainDeckPrice() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(General), Member = "KeyByValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T", "W"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<T, W>", "W"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	public string get_Name() { }

	[CalledBy(Type = "Scenes.Deck.DeckSelection+<>c__DisplayClass60_1", Member = "<UpdateDeckList>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Deck), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "get_Tags", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public string get_SearchableName() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public float get_SideDeckPrice() { }

	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxSlot), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportSingleDeckToCSV>d__74", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(P2PManager), Member = "WriteFullDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "get_YDK", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Deck), Member = "get_SearchableName", ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public string get_Tags() { }

	[CalledBy(Type = "Manager.Customization+<ExportAllDecksToYDK>d__73", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Deck), Member = "get_Tags", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	public string get_YDK() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RefreshCardCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Banlist), Member = "DeckCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Banlist), Member = "GetSpentGenesysPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Deck), Member = "AddRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Rarity), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Deck), Member = "CanAddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Deck), Member = "UpdateInfoForCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_IsExtraCard", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(General), Member = "ToSetCodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.UInt16>))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 4)]
	public int GetAmountOf(long flag, BanflagLocation location = 0, BanflagType type = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetCardAtkSortOrder(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	public static string GetCardNameSortOrder(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_CardTypeSortOrder", ReturnType = typeof(int))]
	public static int GetCardTypeSortOrder(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(BanlistManager), Member = "get_CurrentBanlist", ReturnType = typeof(Banlist))]
	[Calls(Type = typeof(Banlist), Member = "get_IsTCG", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Card), Member = "GetReleaseDateFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsUnknownMethods(Count = 1)]
	public static long GetDateSortOrder(int id) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "InsertCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckEdit), Member = "SwapCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Template), typeof(Template), typeof(DeckType), typeof(DeckType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public List<Int32> GetDeckByType(DeckType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	private int GetDeckCardPrice(int id) { }

	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxSlot), typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "GetLocale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "<GetFormula>g__write|22_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.Card, System.Byte>), typeof(StringBuilder&), typeof(<>c__DisplayClass22_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Localization), Member = "GetGameMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Deck), Member = "<GetFormula>g__list|22_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<Card.Card, System.Byte>), typeof(Card)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Card), Member = "HasType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_IsCompletelyEmpty", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public string GetFormula(bool tags, bool prices) { }

	[AsyncStateMachine(typeof(<GetHash>d__18))]
	[CalledBy(Type = "Scenes.Deck.DeckSelection+<OnClickStatistics>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization+<ExportSingleDeckToCSV>d__74", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey+<CopyDeckToClipboard>d__85", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+<GetDeckHash>d__37", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+DeckData+<Create>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+BotInfo+<Create>d__4", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetHash>d__18)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetHash>d__18&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task<String> GetHash() { }

	[CalledBy(Type = typeof(ClientReplay), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(PackedBinaryData), Member = "CompressDataSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CompressionLevel), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public string GetHashSync() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	public static int GetPriceSortOrder(int id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "<GetSetcodesAmount>g__parseDeck|62_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(float), typeof(<>c__DisplayClass62_0&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public Dictionary<UInt16, Single> GetSetcodesAmount() { }

	[CalledBy(Type = typeof(<Create>d__61), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CreateFromHash>d__60), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CreateFromYDKFile>d__59), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.DeckAPI+<RequestAPIDeck>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.DeckAPI+<RequestAutoDeck>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "DeckFromRecipe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Deck))]
	[CalledBy(Type = typeof(Manager), Member = "GetDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Deck))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Init() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "AddCardToDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DeckTrunk), Member = "OnEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool IsFull(DeckType type) { }

	[AsyncStateMachine(typeof(<OmegaHashDecode>d__68))]
	[CalledBy(Type = typeof(<Create>d__61), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CreateFromHash>d__60), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OmegaHashDecode>d__68)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OmegaHashDecode>d__68&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OmegaHashDecode(string base64) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(PackedBinaryData), Member = "DecompressDataSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private void OmegaHashDecodeSync(string base64) { }

	[AsyncStateMachine(typeof(<ParseYDK>d__64))]
	[CalledBy(Type = typeof(<Create>d__61), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CreateFromYDKFile>d__59), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseYDK>d__64)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ParseYDK>d__64&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task ParseYDK(string text, bool isFile) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "SetRarityCounters", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Template), Member = "DefineRarity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rarity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public byte RarityCount(Rarity rarity) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "FixInvalidCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "UpdateInfoForCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
	[Calls(Type = typeof(Card), Member = "get_IsExtraCard", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveMain(int cardId, byte mode = 0) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "RemoveCardFromDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeckType), typeof(Template)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Manager), Member = "FixInvalidCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "UpdateInfoForCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveSide(int cardId) { }

	[CalledBy(Type = typeof(GameRoom), Member = "SetSelectedDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "UpdateCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameRoom), Member = "OnClickRandomDeck", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen+<LeaveQueue>d__123", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "ShowCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyScreen), Member = "OnJoinTournamentButton", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<>c__DisplayClass368_0", Member = "<OnCloseButton>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit+<OnAutoDeck>d__370", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "OnFinishSiding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "set_SidingDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckEdit), Member = "InitializeCurrentDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickClose", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelEnd+<OnLeave>d__41", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Network), Member = "OnLeaveGame", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "get_CurrentDeck", ReturnType = typeof(Deck))]
	[CalledBy(Type = "Card.Manager+<DeleteAllDecks>d__68", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<DeleteDeck>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeckSelection), Member = "OnClickSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxSlot)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixInvalids>d__54)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<FixInvalids>d__54&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public static void set_CurrentDeck(Deck value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_DeckCard(int value) { }

	[CalledBy(Type = typeof(Packet), Member = "JoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Deck)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "JoinTournament", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(BinaryWriter))]
	[CalledBy(Type = typeof(Packet), Member = "UpdateDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck), typeof(bool)}, ReturnType = typeof(BinaryWriter))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void set_LastUsedDeckName(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

	[CalledBy(Type = "Scenes.Deck.DeckSelection+<OnChangeTags>d__55", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.P2PManager+DeckSyncRcv+<RegisterDeck>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<CreateFromHash>d__60), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<ParseYDK>d__64), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.DeckAPI+<RequestURLDecks>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void set_Tags(string value) { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnShuffleButton", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(System.Func`2<System.Int32, System.Single>)}, ReturnType = typeof(System.Linq.IOrderedEnumerable`1<System.Int32>))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[CallsUnknownMethods(Count = 6)]
	public void Shuffle() { }

	[CalledBy(Type = typeof(DeckEdit), Member = "OnSortButton", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Deck), Member = "SortCardList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<Int32>&)}, ReturnType = typeof(void))]
	public void Sort() { }

	[CalledBy(Type = typeof(Deck), Member = "Sort", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenByDescending", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static void SortCardList(ref List<Int32>& idList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Byte>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool SwapRarity(int oldId, int newId) { }

	[CalledBy(Type = typeof(Deck), Member = "RemoveMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Deck), Member = "RemoveSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Deck), Member = "GetAmountOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(BanflagLocation), typeof(BanflagType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "get_FirstCard", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInfoForCard(int cardId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static void WriteInt32ToList(List<Byte> array_list, int value) { }

	[CalledBy(Type = typeof(<Create>d__61), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(General), Member = "CanRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Deck), Member = "AddMain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Deck), Member = "AddSide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	private void YDKEHashDecode(string base64) { }

}

