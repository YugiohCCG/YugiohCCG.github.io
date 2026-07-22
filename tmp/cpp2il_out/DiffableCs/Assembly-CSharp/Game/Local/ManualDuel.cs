namespace Game.Local;

public class ManualDuel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CardData, Boolean> <>9__36_0; //Field offset: 0x8
		public static Func<CardData, Boolean> <>9__36_1; //Field offset: 0x10
		public static Func<CardData, Boolean> <>9__49_0; //Field offset: 0x18

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool <OnShuffle>b__36_0(CardData cd) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <OnShuffle>b__36_1(CardData cd) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <QueryFieldInfo>b__49_0(CardData cd) { }

	}

	[CompilerGenerated]
	private struct <AskQuestion>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte LocalPlayer; //Field offset: 0x20
		public int question; //Field offset: 0x24
		public ManualDuel <>4__this; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DrawCards>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte LocalPlayer; //Field offset: 0x20
		public byte count; //Field offset: 0x21
		public bool bottom; //Field offset: 0x22
		public ManualDuel <>4__this; //Field offset: 0x28
		private BinaryWriter <packet>5__2; //Field offset: 0x30
		private object <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private ValueTaskAwaiter <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ManualDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(CardData&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ManualDuel), Member = "QueryFieldCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(ManualDuel), Member = "MoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardData&), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "RefreshLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 14)]
		[CallsUnknownMethods(Count = 37)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnActivateCard>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(CardData&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 21)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnAnnounceCard>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(CardData&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "RefreshSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDraw>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		public BinaryReader req; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<DrawCards>d__38"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DrawCards>d__38&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnFieldDisabled>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnHandResult>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		public BinaryReader req; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Packet), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 26)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnJanken>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToPlayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnLPUpdate>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 30)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnMove>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private byte <count>5__2; //Field offset: 0x31
		private sbyte <oldSubsequence>5__3; //Field offset: 0x32
		private CardData[] <targets>5__4; //Field offset: 0x38
		private int <subId>5__5; //Field offset: 0x40
		private byte <b>5__6; //Field offset: 0x44
		private object <>7__wrap6; //Field offset: 0x48
		private int <>7__wrap7; //Field offset: 0x50
		private ValueTaskAwaiter <>u__1; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(ManualDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(CardData&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(ManualDuel), Member = "MoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardData&), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = "Game.Local.ManualDuel+CardData", Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ManualDuel), Member = "CreateNewCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = "Game.Local.ManualDuel+CardData")]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 28)]
		[CallsUnknownMethods(Count = 57)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnNewPhase>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public DuelPhase phase; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnNewPhase>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public BinaryReader req; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private DuelPhase <phase>5__2; //Field offset: 0x34
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnNewTurn>d__15"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewTurn>d__15&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnNewPhase>d__16"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewPhase>d__16&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnNewTurn>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnQuestionAnswer>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private BinaryWriter <packet>5__2; //Field offset: 0x38
		private object <>7__wrap2; //Field offset: 0x40
		private int <>7__wrap3; //Field offset: 0x48
		private BinaryWriter <>7__wrap4; //Field offset: 0x50
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x58
		private ValueTaskAwaiter <>u__2; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<QueryFieldCard>d__46"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<QueryFieldCard>d__46&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 40)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRequestDeck>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public BinaryReader req; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<AskQuestion>d__29"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AskQuestion>d__29&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 13)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnShuffle>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public byte LocalPlayer; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public CardLocation location; //Field offset: 0x30
		private BinaryWriter <packet>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private ValueTaskAwaiter <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "RefreshLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "Game.Local.ManualDuel+CardData", Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(General), Member = "Shuffle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(Random)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 37)]
		[CallsUnknownMethods(Count = 103)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSpSummoned>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(CardData&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ManualDuel), Member = "MoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardData&), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 26)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSpSummoning>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ManualDuel), Member = "CreateNewCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = "Game.Local.ManualDuel+CardData")]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 31)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnTossCoin>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		public ManualDuel <>4__this; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 17)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnTossDice>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		public ManualDuel <>4__this; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 17)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnUpdateCard>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader req; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(CardData&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.UInt16>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.UInt16>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "RefreshSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 26)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueryCard>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		public byte location; //Field offset: 0x29
		public byte sequence; //Field offset: 0x2A
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(CardData&)}, ReturnType = typeof(bool))]
		[Calls(Type = "Game.Local.ManualDuel+CardData", Member = "GetInfos", ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueryFieldCard>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		public CardLocation location; //Field offset: 0x2C
		private MemoryStream <ms>5__2; //Field offset: 0x30
		private BinaryWriter <data>5__3; //Field offset: 0x38
		private object <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48
		private Byte[] <>7__wrap5; //Field offset: 0x50
		private object <>7__wrap6; //Field offset: 0x58
		private int <>7__wrap7; //Field offset: 0x60
		private Byte[] <>7__wrap8; //Field offset: 0x68
		private IEnumerator<CardData> <>7__wrap9; //Field offset: 0x70
		private BinaryWriter <>7__wrap10; //Field offset: 0x78
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x80
		private CardData[] <>7__wrap11; //Field offset: 0x88
		private int <>7__wrap12; //Field offset: 0x90
		private ValueTaskAwaiter <>u__2; //Field offset: 0x98

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualDuel), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(System.Collections.Generic.IList`1<Game.Local.ManualDuel+CardData>))]
		[Calls(Type = "Game.Local.ManualDuel+CardData", Member = "GetInfos", ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter), typeof(<QueryFieldCard>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValueTaskAwaiter&), typeof(<QueryFieldCard>d__46&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 18)]
		[CallsUnknownMethods(Count = 70)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueryFieldInfo>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public ManualDuel <>4__this; //Field offset: 0x20
		private MemoryStream <ms>5__2; //Field offset: 0x28
		private object <>7__wrap2; //Field offset: 0x30
		private int <>7__wrap3; //Field offset: 0x38
		private Byte[] <>7__wrap4; //Field offset: 0x40
		private object <>7__wrap5; //Field offset: 0x48
		private int <>7__wrap6; //Field offset: 0x50
		private Byte[] <>7__wrap7; //Field offset: 0x58
		private ValueTaskAwaiter <>u__1; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 28)]
		[CallsUnknownMethods(Count = 66)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetResponse>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BinaryReader resp; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		public byte LocalPlayer; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnRequestDeck>d__31"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRequestDeck>d__31&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnUpdateCard>d__27"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUpdateCard>d__27&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnQuestionAnswer>d__30"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnQuestionAnswer>d__30&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualDuel), Member = "OnShuffle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnMove>d__19"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnMove>d__19&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnNewPhase>d__17"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewPhase>d__17&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnSpSummoning>d__25"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoning>d__25&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnFieldDisabled>d__26"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldDisabled>d__26&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnActivateCard>d__22"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnActivateCard>d__22&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnSpSummoned>d__24"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoned>d__24&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnDraw>d__39"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDraw>d__39&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnTossCoin>d__40"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossCoin>d__40&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnTossDice>d__41"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossDice>d__41&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnJanken>d__42"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnJanken>d__42&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnHandResult>d__43"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHandResult>d__43&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnAnnounceCard>d__23"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceCard>d__23&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+<OnLPUpdate>d__32"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnLPUpdate>d__32&)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 75)]
		[CallsUnknownMethods(Count = 112)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool inverse; //Field offset: 0x20
		public ManualDuel <>4__this; //Field offset: 0x28
		private byte <LocalPlayer>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "get_StartHand", ReturnType = typeof(byte))]
		[Calls(Type = typeof(ManualDuel), Member = "DrawCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualDuel), Member = "OnNewTurn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ManualDuel), Member = "OnNewPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DuelPhase)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class CardData
	{
		[CompilerGenerated]
		private struct <GetInfos>d__26 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
			public CardData <>4__this; //Field offset: 0x20
			private MemoryStream <ms>5__2; //Field offset: 0x28
			private object <>7__wrap2; //Field offset: 0x30
			private int <>7__wrap3; //Field offset: 0x38
			private Byte[] <>7__wrap4; //Field offset: 0x40
			private object <>7__wrap5; //Field offset: 0x48
			private int <>7__wrap6; //Field offset: 0x50
			private Byte[] <>7__wrap7; //Field offset: 0x58
			private ValueTaskAwaiter <>u__1; //Field offset: 0x60

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
			[Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
			[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
			[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.UInt16>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.UInt16, System.UInt16>))]
			[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.UInt16, System.UInt16>), Member = "MoveNext", ReturnType = typeof(bool))]
			[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
			[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 35)]
			[CallsUnknownMethods(Count = 39)]
			private override void MoveNext() { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private const int QUERY_CODE = 7013171; //Field offset: 0x0
		public Card Original; //Field offset: 0x10
		public int Code; //Field offset: 0x18
		public int Attack; //Field offset: 0x1C
		public int Defense; //Field offset: 0x20
		public int Status; //Field offset: 0x24
		public byte Level; //Field offset: 0x28
		public byte Scales; //Field offset: 0x29
		public byte Position; //Field offset: 0x2A
		public byte Controller; //Field offset: 0x2B
		public byte Location; //Field offset: 0x2C
		public byte Sequence; //Field offset: 0x2D
		public List<Int32> Overlays; //Field offset: 0x30
		public Dictionary<UInt16, UInt16> Counters; //Field offset: 0x38

		public bool IsFaceUp
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 23
		}

		public bool IsInEMZ
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 26
		}

		public bool IsInOverlay
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		[CalledBy(Type = "Game.Local.ManualDuel+PlayerCards", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(ManualDuel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ManualDuel), Member = "CreateNewCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(CardData))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = typeof(CardData), Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public CardData(int id, byte controller, CardLocation location, byte sequence, CardPosition position = 2) { }

		[CalledBy(Type = typeof(ManualDuel), Member = "MoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardData&), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		public bool AddOverlay(ref CardData overlay) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(Card))]
		[Calls(Type = typeof(CardData), Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		public void ChangeID(int id) { }

		[CalledBy(Type = typeof(ManualDuel), Member = "MoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardData&), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CardData), Member = "SetDefaultData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		public bool ChangePosition(byte position) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_IsFaceUp() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_IsInEMZ() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_IsInOverlay() { }

		[AsyncStateMachine(typeof(<GetInfos>d__26))]
		[CalledBy(Type = "Game.Local.ManualDuel+<QueryCard>d__47", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.Local.ManualDuel+<QueryFieldCard>d__46", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.ManualDuel+CardData+<GetInfos>d__26"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetInfos>d__26&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public Task<Byte[]> GetInfos() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool HasPosition(CardPosition position) { }

		[CallerCount(Count = 0)]
		public void set_IsInOverlay(bool value) { }

		[CalledBy(Type = typeof(CardData), Member = "ChangeID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CardData), Member = "ChangePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Game.Local.ManualDuel+<OnMove>d__19", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.Local.ManualDuel+<OnShuffle>d__36", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		public void SetDefaultData(int id = 0) { }

	}

	private class PlayerCards
	{
		public List<CardData> MainDeck; //Field offset: 0x10
		public List<CardData> ExtraDeck; //Field offset: 0x18
		public List<CardData> Graveyard; //Field offset: 0x20
		public List<CardData> Banished; //Field offset: 0x28
		public List<CardData> Hand; //Field offset: 0x30
		public CardData[] MonsterZones; //Field offset: 0x38
		public CardData[] SpellZones; //Field offset: 0x40

		[CalledBy(Type = typeof(ManualDuel), Member = "AddPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LocalGame), Member = "get_NoShuffleDeck", ReturnType = typeof(bool))]
		[Calls(Type = typeof(General), Member = "Shuffle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(Random)}, ReturnType = "System.Collections.Generic.List`1<T>")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = "Game.Local.ManualDuel+CardData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 11)]
		public PlayerCards(LocalPlayer p, ManualDuel duel) { }

	}

	private readonly CardData[] ExtraMonsterZones; //Field offset: 0x10
	private readonly Dictionary<Byte, PlayerCards> GameCards; //Field offset: 0x18
	private readonly LocalGame GameRoom; //Field offset: 0x20
	private bool IsInJanken; //Field offset: 0x28
	private Byte[] JankenResults; //Field offset: 0x30
	private readonly Random RNG; //Field offset: 0x38
	private Byte[] DeckRequest; //Field offset: 0x40
	private uint BlockedZones; //Field offset: 0x48

	private bool IsWaitingForAnswer
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 9
	}

	[CalledBy(Type = "Game.Local.LocalGame+<TpResult>d__177", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public ManualDuel(LocalGame gameRoom) { }

	[CalledBy(Type = "Game.Local.LocalGame+<TpResult>d__177", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerCards), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(ManualDuel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void AddPlayer(LocalPlayer LocalPlayer) { }

	[AsyncStateMachine(typeof(<AskQuestion>d__29))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AskQuestion>d__29)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AskQuestion>d__29&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task AskQuestion(byte LocalPlayer, int question) { }

	[CalledBy(Type = typeof(<OnMove>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSpSummoning>d__25), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualDuel), Member = "MoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardData&), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ManualDuel), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(System.Collections.Generic.IList`1<Game.Local.ManualDuel+CardData>))]
	[Calls(Type = typeof(CardData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private CardData CreateNewCard(int id, byte controller, CardLocation location, byte sequence, CardPosition position = 2) { }

	[AsyncStateMachine(typeof(<DrawCards>d__38))]
	[CalledBy(Type = typeof(<Start>d__14), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DrawCards>d__38)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DrawCards>d__38&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task DrawCards(byte LocalPlayer, byte count = 1, bool bottom = false) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool get_IsWaitingForAnswer() { }

	[CalledBy(Type = typeof(<DrawCards>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnActivateCard>d__22), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnAnnounceCard>d__23), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnMove>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSpSummoned>d__24), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnUpdateCard>d__27), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<QueryCard>d__47), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ManualDuel), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(System.Collections.Generic.IList`1<Game.Local.ManualDuel+CardData>))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	private bool GetCard(byte controller, byte location, byte sequence, out CardData card) { }

	[CalledBy(Type = typeof(<QueryFieldCard>d__46), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualDuel), Member = "CreateNewCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(CardData))]
	[CalledBy(Type = typeof(ManualDuel), Member = "MoveCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardData&), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualDuel), Member = "QueryFieldCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(ManualDuel), Member = "GetCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(CardData&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Byte, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private IList<CardData> GetCards(byte controller, CardLocation location, byte sequence = 0) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsEMZ(byte loc, byte seq) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsOverlayLocation(byte loc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public static bool IsPlayableLocation(byte loc) { }

	[CalledBy(Type = typeof(<DrawCards>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnMove>d__19), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnSpSummoned>d__24), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ManualDuel), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(System.Collections.Generic.IList`1<Game.Local.ManualDuel+CardData>))]
	[Calls(Type = typeof(CardData), Member = "ChangePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ManualDuel), Member = "CreateNewCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte), typeof(CardLocation), typeof(byte), typeof(CardPosition)}, ReturnType = typeof(CardData))]
	[Calls(Type = typeof(CardData), Member = "AddOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CardData&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private bool MoveCard(ref CardData card, byte newController, byte newLocation, byte newSequence = 0, byte newPosition = 0, bool gotOverlay = false) { }

	[AsyncStateMachine(typeof(<OnActivateCard>d__22))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnActivateCard>d__22)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnActivateCard>d__22&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnActivateCard(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnAnnounceCard>d__23))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceCard>d__23)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnAnnounceCard>d__23&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnAnnounceCard(byte LocalPlayer, BinaryReader req) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnCardTarget(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnDraw>d__39))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDraw>d__39)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnDraw>d__39&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnDraw(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnFieldDisabled>d__26))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldDisabled>d__26)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnFieldDisabled>d__26&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnFieldDisabled(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnHandResult>d__43))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHandResult>d__43)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnHandResult>d__43&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnHandResult(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnJanken>d__42))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnJanken>d__42)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnJanken>d__42&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnJanken(byte LocalPlayer) { }

	[AsyncStateMachine(typeof(<OnLPUpdate>d__32))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnLPUpdate>d__32)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnLPUpdate>d__32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnLPUpdate(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnMove>d__19))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnMove>d__19)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnMove>d__19&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnMove(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnNewPhase>d__17))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewPhase>d__17)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewPhase>d__17&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnNewPhase(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnNewPhase>d__16))]
	[CalledBy(Type = typeof(<Start>d__14), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewPhase>d__16)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewPhase>d__16&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnNewPhase(DuelPhase phase) { }

	[AsyncStateMachine(typeof(<OnNewTurn>d__15))]
	[CalledBy(Type = typeof(<Start>d__14), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewTurn>d__15)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnNewTurn>d__15&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnNewTurn(byte LocalPlayer) { }

	[AsyncStateMachine(typeof(<OnQuestionAnswer>d__30))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnQuestionAnswer>d__30)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnQuestionAnswer>d__30&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnQuestionAnswer(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnRequestDeck>d__31))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRequestDeck>d__31)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnRequestDeck>d__31&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnRequestDeck(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnShuffle>d__36))]
	[CalledBy(Type = typeof(<SetResponse>d__21), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffle>d__36)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnShuffle>d__36&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task OnShuffle(byte LocalPlayer, CardLocation location) { }

	[AsyncStateMachine(typeof(<OnSpSummoned>d__24))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoned>d__24)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoned>d__24&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSpSummoned(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnSpSummoning>d__25))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoning>d__25)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnSpSummoning>d__25&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnSpSummoning(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnTossCoin>d__40))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossCoin>d__40)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossCoin>d__40&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnTossCoin(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnTossDice>d__41))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossDice>d__41)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnTossDice>d__41&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnTossDice(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<OnUpdateCard>d__27))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUpdateCard>d__27)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnUpdateCard>d__27&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task OnUpdateCard(byte LocalPlayer, BinaryReader req) { }

	[AsyncStateMachine(typeof(<QueryCard>d__47))]
	[CalledBy(Type = "Game.Local.LocalGame+<RefreshSingle>d__201", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<QueryCard>d__47)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<QueryCard>d__47&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Byte[]> QueryCard(byte LocalPlayer, byte location, byte sequence) { }

	[AsyncStateMachine(typeof(<QueryFieldCard>d__46))]
	[CalledBy(Type = "Game.Local.LocalGame+<RefreshLocation>d__197", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<QueryFieldCard>d__46)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<QueryFieldCard>d__46&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task<Byte[]> QueryFieldCard(byte LocalPlayer, CardLocation location) { }

	[CalledBy(Type = "Game.Local.LocalGame+<TpResult>d__177", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DrawCards>d__38), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ManualDuel), Member = "GetCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(byte)}, ReturnType = typeof(System.Collections.Generic.IList`1<Game.Local.ManualDuel+CardData>))]
	[CallsUnknownMethods(Count = 2)]
	public byte QueryFieldCount(byte LocalPlayer, CardLocation location) { }

	[AsyncStateMachine(typeof(<QueryFieldInfo>d__49))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<QueryFieldInfo>d__49)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<QueryFieldInfo>d__49&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task<Byte[]> QueryFieldInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SendToOpponentTeam(BinaryWriter packet, byte LocalPlayer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SendToTeam(BinaryWriter packet, byte LocalPlayer) { }

	[AsyncStateMachine(typeof(<SetResponse>d__21))]
	[CalledBy(Type = "Game.Local.LocalGame+<SetResponse>d__207", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetResponse>d__21)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetResponse>d__21&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task SetResponse(byte LocalPlayer, BinaryReader resp) { }

	[AsyncStateMachine(typeof(<Start>d__14))]
	[CalledBy(Type = "Game.Local.LocalGame+<TpResult>d__177", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Start>d__14)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Start>d__14&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task Start(bool inverse) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static void WriteCardCode(BinaryWriter packet, CardData card, byte LocalPlayer, long pos = -1) { }

}

