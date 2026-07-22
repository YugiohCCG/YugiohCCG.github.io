namespace Game.Local;

public class LocalGame
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LocalPlayer, Boolean> <>9__75_0; //Field offset: 0x8
		public static Func<SByte, Boolean> <>9__101_0; //Field offset: 0x10
		public static Func<LocalPlayer, Boolean> <>9__150_0; //Field offset: 0x18
		public static Func<LocalPlayer, Boolean> <>9__215_0; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool <AssignHostPlayer>b__150_0(LocalPlayer p) { }

		[CallerCount(Count = 0)]
		internal bool <get_FlawlessVictory>b__101_0(sbyte r) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal bool <get_PlayerCount>b__75_0(LocalPlayer p) { }

		[CallerCount(Count = 0)]
		internal bool <RemoveAllBots>b__215_0(LocalPlayer p) { }

	}

	[CompilerGenerated]
	private struct <AddPlayer>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalPlayer LocalPlayer; //Field offset: 0x20
		public LocalGame <>4__this; //Field offset: 0x28
		public bool forceObserver; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private BinaryWriter <watch>5__2; //Field offset: 0x40
		private object <>7__wrap2; //Field offset: 0x48
		private int <>7__wrap3; //Field offset: 0x50
		private ValueTaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<InitNewSpectator>d__245"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitNewSpectator>d__245&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameAnalyser)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendJoinGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<AssignHostPlayer>d__150"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AssignHostPlayer>d__150&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Packet), Member = "WriteUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[CallsDeduplicatedMethods(Count = 26)]
		[CallsUnknownMethods(Count = 96)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AssignHostPlayer>d__150 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__2; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
		[Calls(Type = typeof(LocalPlayer), Member = "SendTypeChange", ReturnType = typeof(Task))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAllBut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalPlayer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 19)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChooseBoss>d__168 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalPlayer p; //Field offset: 0x20
		public LocalGame <>4__this; //Field offset: 0x28
		public byte choice; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(int)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<SendStartDuel>d__163"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendStartDuel>d__163&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CleanRoom>d__153 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public bool informPlayer; //Field offset: 0x28
		private LocalPlayer[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private Enumerator<LocalPlayer> <>7__wrap3; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "CleanTimerToken", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "RemovePlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateDuel>d__179 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private Random <rand>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private Enumerator<String> <>7__wrap2; //Field offset: 0x38
		private sbyte <i>5__4; //Field offset: 0x50
		private int <>7__wrap4; //Field offset: 0x54
		private int <>7__wrap5; //Field offset: 0x58
		private byte <>7__wrap6; //Field offset: 0x5C
		private byte <>7__wrap7; //Field offset: 0x5D
		private byte <>7__wrap8; //Field offset: 0x5E
		private TaskAwaiter<Int32> <>u__2; //Field offset: 0x60
		private object <>7__wrap9; //Field offset: 0x68
		private ValueTaskAwaiter <>u__3; //Field offset: 0x70

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DefineRandomStarter>d__172 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<TpResult>d__177"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TpResult>d__177&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 18)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <End>d__217 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<RemoveAllBots>d__215"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RemoveAllBots>d__215&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EndDuel>d__210 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public bool error; //Field offset: 0x28
		public bool force; //Field offset: 0x29
		public LocalPlayer surrender; //Field offset: 0x30
		private bool <isOver>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalDuel+<End>d__18"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<End>d__18&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<CleanRoom>d__153"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CleanRoom>d__153&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "MatchSaveResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(DuelEndReason)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<TimeStart>d__219"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TimeStart>d__219&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<SendChangingSideToPlayers>d__211"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendChangingSideToPlayers>d__211&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<End>d__217"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<End>d__217&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 51)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFieldCount>d__181 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public int LocalPlayer; //Field offset: 0x28
		public CardLocation loc; //Field offset: 0x2C
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalDuel+<QueryFieldCount>d__16"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<QueryFieldCount>d__16&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(LocalGame), Member = "OnInternalError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Runtime.CompilerServices.TaskAwaiter`1<System.Int32>), typeof(<GetFieldCount>d__181)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter`1<Int32>&), typeof(<GetFieldCount>d__181&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 10)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandleError>d__246 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string error; //Field offset: 0x20
		public LocalGame <>4__this; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Packet), Member = "WriteASCII", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 17)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HandResult>d__171 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		public byte result; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
		[Calls(Type = typeof(Packet), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<SendHand>d__239"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendHand>d__239&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Game.Local.LocalGame+<SendTPSelect>d__173"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendTPSelect>d__173&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 49)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitNewSpectator>d__245 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		private BinaryWriter <turn>5__2; //Field offset: 0x30
		private object <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48
		private BinaryWriter <reload>5__5; //Field offset: 0x58
		private TaskAwaiter<Byte[]> <>u__2; //Field offset: 0x60
		private TaskAwaiter <>u__3; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitPlayerForDuel>d__180 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer dplayer; //Field offset: 0x28
		public Random rand; //Field offset: 0x30
		public sbyte i; //Field offset: 0x38
		private int <tid>5__2; //Field offset: 0x3C
		private List<Int32> <cards>5__3; //Field offset: 0x40
		private byte <b>5__4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private Enumerator<Int32> <>7__wrap4; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
		[Calls(Type = typeof(General), Member = "Shuffle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", typeof(Random)}, ReturnType = "System.Collections.Generic.List`1<T>")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(LocalDuel), Member = "AddTagCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CardLocation), typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalDuel), Member = "AddCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(CardLocation)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 16)]
		[CallsUnknownMethods(Count = 32)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <KickPlayer>d__160 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public byte pos; //Field offset: 0x28
		public LocalPlayer LocalPlayer; //Field offset: 0x30
		public bool ban; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "RemovePlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MatchSide>d__231 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "TimeStart", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MoveToDuelist>d__156 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public sbyte pos; //Field offset: 0x28
		public LocalPlayer LocalPlayer; //Field offset: 0x30
		private BinaryWriter <change>5__2; //Field offset: 0x38
		private object <>7__wrap2; //Field offset: 0x40
		private int <>7__wrap3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private ValueTaskAwaiter <>u__2; //Field offset: 0x58
		private BinaryWriter <nwatch>5__5; //Field offset: 0x68
		private object <>7__wrap5; //Field offset: 0x70
		private int <>7__wrap6; //Field offset: 0x78

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "GetAvailablePlayerPos", ReturnType = typeof(sbyte))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "IsPositionAvailable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalExt), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalUser)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "SendTypeChange", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 76)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MoveToObserver>d__157 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "SendTypeChange", ReturnType = typeof(Task))]
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
	private struct <OnChatMessage>d__127 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalPlayer sender; //Field offset: 0x20
		public string msg; //Field offset: 0x28
		public LocalGame <>4__this; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Packet), Member = "WriteUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAllBut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalPlayer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 15)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnInternalError>d__209 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public Exception e; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "EndDuel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Process>d__240 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalDuel), Member = "ProcessDuel", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "OnInternalError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "EndDuel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 14)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReassignHostPlayer>d__149 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "AssignHostPlayer", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshAll>d__193 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshAllObserver>d__196 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer observer; //Field offset: 0x28
		public bool reconnect; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshAllOthers>d__194 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshLocation>d__197 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		public CardLocation loc; //Field offset: 0x2C
		public LocalPlayer observer; //Field offset: 0x30
		public bool reconnect; //Field offset: 0x38
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalDuel), Member = "QueryFieldCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(uint), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualDuel), Member = "QueryFieldCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(LocalGame), Member = "SendToCorrectDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(Byte[]), typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 11)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshReconnect>d__195 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer reconnect; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "RefreshAllObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshSingle>d__201 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public byte player; //Field offset: 0x28
		public byte location; //Field offset: 0x29
		public byte sequence; //Field offset: 0x2A
		public bool isPublic; //Field offset: 0x2B
		private BinaryWriter <update>5__2; //Field offset: 0x30
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x38
		private object <>7__wrap2; //Field offset: 0x40
		private int <>7__wrap3; //Field offset: 0x48
		private BinaryWriter <updatepub>5__5; //Field offset: 0x50
		private object <>7__wrap5; //Field offset: 0x58
		private int <>7__wrap6; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68
		private ValueTaskAwaiter <>u__3; //Field offset: 0x70

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "WritePublicCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "IsPublicKnowledge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(ManualDuel), Member = "QueryCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(LocalDuel), Member = "QueryCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(uint), typeof(bool)}, ReturnType = typeof(System.Threading.Tasks.Task`1<Byte[]>))]
		[Calls(Type = typeof(LocalGame), Member = "get_IsManual", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 16)]
		[CallsUnknownMethods(Count = 48)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RemoveAllBots>d__215 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private IEnumerator<LocalPlayer> <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[Calls(Type = typeof(LocalPlayer), Member = "Disconnect", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 18)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RemovePlayer>d__151 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalPlayer LocalPlayer; //Field offset: 0x20
		public bool informPlayer; //Field offset: 0x28
		public LocalGame <>4__this; //Field offset: 0x30
		public bool isCleaning; //Field offset: 0x38
		private bool <isObserver>5__2; //Field offset: 0x39
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private object <>7__wrap2; //Field offset: 0x48
		private int <>7__wrap3; //Field offset: 0x50
		private ValueTaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendChangingSide>d__212 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalPlayer p; //Field offset: 0x20
		private object <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private ValueTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(Packet), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Deck)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendChangingSideToPlayers>d__211 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendDuelingPlayers>d__242 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		public bool withPos; //Field offset: 0x30
		private int <i>5__2; //Field offset: 0x34
		private BinaryWriter <enter>5__3; //Field offset: 0x38
		private object <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48
		private object <>7__wrap5; //Field offset: 0x50
		private int <>7__wrap6; //Field offset: 0x58
		private ValueTaskAwaiter <>u__1; //Field offset: 0x60

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalExt), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalUser)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 41)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendFieldState>d__243 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer p; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 16)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendHand>d__239 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer p1; //Field offset: 0x28
		public LocalPlayer p2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "TimeStart", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "get_IsTeam", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "SendToPlayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "GetFirstPlayerOfTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(bool)}, ReturnType = typeof(LocalPlayer))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendJoinGame>d__241 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		public bool withPos; //Field offset: 0x30
		private object <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalExt), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(LocalGame)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "get_IsMatch", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "get_IsTeam", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "GetLockedState", ReturnType = typeof(byte))]
		[Calls(Type = typeof(LocalGame), Member = "SendDuelingPlayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalPlayer), Member = "SendTypeChange", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 27)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendNewRulesToAll>d__129 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private object <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private ValueTaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(BinaryExtensions), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameSettings)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 13)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendStartDuel>d__163 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "StartPuzzleDuel", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "GetFirstPlayerOfTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(bool)}, ReturnType = typeof(LocalPlayer))]
		[Calls(Type = typeof(LocalGame), Member = "SendHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(LocalPlayer)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "SendTPSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "DefineRandomStarter", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendTimeLimit>d__205 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer tgt; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "SendToPlayers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallsUnknownMethods(Count = 20)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendToCorrectDestination>d__198 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] result; //Field offset: 0x20
		public bool reconnect; //Field offset: 0x28
		public LocalPlayer observer; //Field offset: 0x30
		public LocalGame <>4__this; //Field offset: 0x38
		public byte LocalPlayer; //Field offset: 0x40
		public CardLocation location; //Field offset: 0x44
		private BinaryWriter <update>5__2; //Field offset: 0x48
		private object <>7__wrap2; //Field offset: 0x50
		private int <>7__wrap3; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private ValueTaskAwaiter <>u__2; //Field offset: 0x68

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalGame), Member = "WritePublicCards", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter), typeof(<SendToCorrectDestination>d__198)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskAwaiter&), typeof(<SendToCorrectDestination>d__198&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 24)]
		[CallsUnknownMethods(Count = 46)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendTPSelect>d__173 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public byte LocalPlayer; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "TimeStart", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetReady>d__158 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		public bool ready; //Field offset: 0x30
		public bool skipCheck; //Field offset: 0x31
		private int <result>5__2; //Field offset: 0x34
		private object <>7__wrap2; //Field offset: 0x38
		private int <>7__wrap3; //Field offset: 0x40
		private ValueTaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x58

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(GameAnalyser)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Deck), Member = "Check", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Banlist), typeof(GameSettings)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "IsReadyToStart", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "StartDuel", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 53)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetResponse>d__206 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public int resp; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "TimeStop", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalDuel), Member = "SetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetResponse>d__207 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		public BinaryReader resp; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualDuel), Member = "SetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(BinaryReader)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetResponse>d__208 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public Byte[] resp; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "TimeStop", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalDuel), Member = "SetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "Process", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartDuel>d__162 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "SendStartDuel", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "RequestBossDeck", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartPuzzleDuel>d__164 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "TimeStart", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "TpResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 8)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Surrender>d__191 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		public bool force; //Field offset: 0x30
		public DuelEndReason reason; //Field offset: 0x31
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BinaryClient), Member = "get_Connected", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
		[Calls(Type = typeof(LocalGame), Member = "MakeDuelWinPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(DuelEndReason)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "MatchSaveResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(DuelEndReason)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "EndDuel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TimeStart>d__219 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "TimeStop", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "SendTimeLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "TimeTick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationTokenSource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TimeTick>d__226 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationTokenSource ct; //Field offset: 0x28
		public LocalGame <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private byte <b>5__2; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x44

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalPlayer), Member = "UpdatePlayerDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Deck)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "HandResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(byte)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "TpResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "GetFirstPlayerOfTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(bool)}, ReturnType = typeof(LocalPlayer))]
		[Calls(Type = typeof(LocalGame), Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
		[Calls(Type = typeof(LocalGame), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "Surrender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(DuelEndReason), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "TimeStop", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendTimeLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 27)]
		[CallsUnknownMethods(Count = 95)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TpResult>d__177 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public LocalPlayer LocalPlayer; //Field offset: 0x28
		public bool result; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private object <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48
		private ValueTaskAwaiter <>u__2; //Field offset: 0x50

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualDuel), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "RefreshLocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation), typeof(LocalPlayer), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(LocalGame), Member = "CreateDuel", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalDuel), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(LocalGame)}, ReturnType = typeof(LocalDuel))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualDuel), Member = "QueryFieldCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(CardLocation)}, ReturnType = typeof(byte))]
		[Calls(Type = typeof(ManualDuel), Member = "AddPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualDuel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalGame)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "get_IsManual", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "StartupDuelState", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "DefineDuelOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "get_IsTeam", ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "CreateStartPacket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(int), typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(BinaryWriter))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 24)]
		[CallsUnknownMethods(Count = 44)]
		[ContainsUnimplementedInstructions]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateRules>d__128 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public uint blHash; //Field offset: 0x20
		public LocalGame <>4__this; //Field offset: 0x28
		public GameSettings gs; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x70
		private LocalPlayer[] <>7__wrap1; //Field offset: 0x78
		private int <>7__wrap2; //Field offset: 0x80

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Banlist&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(LocalGame), Member = "SetRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameSettings), typeof(Banlist), typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "Initialize", ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "SendNewRulesToAll", ReturnType = typeof(Task))]
		[Calls(Type = typeof(LocalGame), Member = "SetReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(bool), typeof(bool)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 12)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForResponse>d__203 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LocalGame <>4__this; //Field offset: 0x20
		public sbyte LocalPlayer; //Field offset: 0x28
		public bool gainTime; //Field offset: 0x29
		private TaskAwaiter <>u__1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalGame), Member = "SendWaiting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "AddTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "TimeStart", ReturnType = typeof(Task))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 9)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WritePublicCards>d__200 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Byte[] result; //Field offset: 0x20
		public BinaryWriter update; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ValueTaskAwaiter <>u__1; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LocalGame), Member = "IsPublicKnowledge", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
		[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 15)]
		[CallsUnknownMethods(Count = 30)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowMinMaxException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static LocalGame Instance; //Field offset: 0x0
	private const byte MAX_JANKENS = 10; //Field offset: 0x0
	private const byte MAX_TEAM_SIZE = 3; //Field offset: 0x0
	[CompilerGenerated]
	private static float <DEFAULT_TIMER_MULT>k__BackingField; //Field offset: 0x8
	public static readonly Byte[] DuelStartPacket; //Field offset: 0x10
	public static readonly Byte[] LeaveMessage; //Field offset: 0x18
	private static Byte[] TPSelectPacket; //Field offset: 0x20
	private static readonly Byte[] TEAM_ONE; //Field offset: 0x28
	private static readonly Byte[] TEAM_TWO; //Field offset: 0x30
	private static readonly Byte[][] WaitingPackets; //Field offset: 0x38
	private static readonly Byte[] DuelEndMessage; //Field offset: 0x40
	private static readonly Byte[] BugEndMessage; //Field offset: 0x48
	private static byte SidingTime; //Field offset: 0x50
	private static Byte[] WaitSidingPacket; //Field offset: 0x58
	private static Byte[] SelectHandPacket; //Field offset: 0x60
	private byte JankenCount; //Field offset: 0x10
	public Banlist Banlist; //Field offset: 0x18
	[CompilerGenerated]
	private uint <LFListHash>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private sbyte <PausedBy>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private GameState <State>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ushort <TurnCount>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private DuelPhase <CurrentPhase>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private byte <CurrentPlayer>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <DuelOpt>k__BackingField; //Field offset: 0x38
	public readonly Int32[] LifePoints; //Field offset: 0x40
	public int FieldState; //Field offset: 0x48
	[CompilerGenerated]
	private string <PuzzleName>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private LocalPlayer[] <Players>k__BackingField; //Field offset: 0x58
	public readonly LocalPlayer[] CurPlayers; //Field offset: 0x60
	[CompilerGenerated]
	private Boolean[] <IsReady>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Boolean[] <IsLocked>k__BackingField; //Field offset: 0x70
	public readonly List<LocalPlayer> Observers; //Field offset: 0x78
	[CompilerGenerated]
	private LocalPlayer <HostPlayer>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private ServerReplay <Replay>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private sbyte <Winner>k__BackingField; //Field offset: 0x90
	public readonly SByte[] MatchResults; //Field offset: 0x98
	public readonly DuelEndReason[] MatchReasons; //Field offset: 0xA0
	public GameSettings Settings; //Field offset: 0xA8
	public byte DuelCount; //Field offset: 0xE8
	public LocalDuel DuelInstance; //Field offset: 0xF0
	public ManualDuel ManualDuelInstance; //Field offset: 0xF8
	private GameAnalyser _analyzer; //Field offset: 0x100
	private readonly Byte[] _handResult; //Field offset: 0x108
	private sbyte _startplayer; //Field offset: 0x110
	public sbyte LastResponse; //Field offset: 0x111
	private readonly Int16[] _timelimit; //Field offset: 0x118
	private readonly Int16[] _gainedtime; //Field offset: 0x120
	private short _time; //Field offset: 0x128
	private bool _matchKill; //Field offset: 0x12A
	public DateTime StartTime; //Field offset: 0x130
	public readonly SemaphoreSlim Sync; //Field offset: 0x138
	public readonly List<Int64> BannedPlayers; //Field offset: 0x140
	private readonly Byte[] CHOOSE_BOSS_PACKET; //Field offset: 0x148
	private uint GameSeed; //Field offset: 0x150
	private CancellationTokenSource TimerToken; //Field offset: 0x158
	private short ELAPSED_TIME_THRESHOLD; //Field offset: 0x160
	private byte GameTimerTickRateAdder; //Field offset: 0x162
	private readonly Int16[] TimeTicksSinceLastAdd; //Field offset: 0x168

	public GameAnalyser Analyzer
	{
		[CalledBy(Type = "Game.Local.LocalDuel+<HandleMessage>d__27", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameAnalyser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalGame)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 121
	}

	public DuelPhase CurrentPhase
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public byte CurrentPlayer
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

	public static float DEFAULT_TIMER_MULT
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 80
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 93
	}

	public byte DrawCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public int DuelOpt
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DuelRules DuelRule
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public ExtraRules ExtraRule
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool FlawlessVictory
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.SByte>), typeof(System.Func`2<System.SByte, System.Boolean>)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 303
	}

	public LocalPlayer HostEnemy
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 195
	}

	public private LocalPlayer HostPlayer
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 16
	}

	public bool IsCustomBanlist
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 32
	}

	public private Boolean[] IsLocked
	{
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public bool IsManual
	{
		[CalledBy(Type = typeof(<RefreshLocation>d__197), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<RefreshSingle>d__201), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<TimeStart>d__219), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.Local.LocalPlayer+<OnResponse>d__52", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LocalPlayer), Member = "OnPause", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsMatch
	{
		[CalledBy(Type = "Game.Local.GameAnalyser+<OnMatchKill>d__53", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<SendJoinGame>d__241), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.Local.LocalPlayer+<OnRematchRequest>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public private Boolean[] IsReady
	{
		[CallerCount(Count = 22)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public bool IsRelay
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsSingle
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsTag
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	public bool IsTeam
	{
		[CalledBy(Type = "Game.Local.GameAnalyser+<OnNewTurn>d__33", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<SendHand>d__239), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<SendJoinGame>d__241), Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 23
	}

	public private uint LFListHash
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public byte MasterRule
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool NoShuffleDeck
	{
		[CalledBy(Type = "Game.Local.ManualDuel+PlayerCards", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(ManualDuel)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		 get { } //Length: 14
	}

	public sbyte PausedBy
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

	public byte PlayerCount
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 273
	}

	public private LocalPlayer[] Players
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	public string PuzzleName
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public CardSet Region
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public private ServerReplay Replay
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 19
	}

	public byte StartHand
	{
		[CalledBy(Type = "Game.Local.ManualDuel+<Start>d__14", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 8
	}

	public int StartLP
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public private GameState State
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 4
	}

	public short Timer
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 8
	}

	public ushort TurnCount
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public private sbyte Winner
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static LocalGame() { }

	[CalledBy(Type = "Game.Local.LocalPlayer+<OnCreateGame>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SemaphoreSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BanlistManager), Member = "GetBanlist", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Banlist&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BinaryExtensions), Member = "ReadGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(GameSettings))]
	[Calls(Type = typeof(LocalGame), Member = "Initialize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	public LocalGame(BinaryReader packet) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource"}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <get_HostEnemy>b__91_0(LocalPlayer p) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	private bool <get_HostEnemy>b__91_1(LocalPlayer p) { }

	[AsyncStateMachine(typeof(<AddPlayer>d__147))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnAddBot>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnCreateGame>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnJoinGame>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AddPlayer>d__147)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AddPlayer>d__147&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task AddPlayer(LocalPlayer LocalPlayer, bool forceObserver = false) { }

	[CalledBy(Type = typeof(<WaitForResponse>d__203), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	public void AddTime(short val = 5) { }

	[AsyncStateMachine(typeof(<AssignHostPlayer>d__150))]
	[CalledBy(Type = typeof(<ReassignHostPlayer>d__149), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AssignHostPlayer>d__150)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<AssignHostPlayer>d__150&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task AssignHostPlayer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void CalculateWinner() { }

	[AsyncStateMachine(typeof(<ChooseBoss>d__168))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChooseBoss>d__168)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ChooseBoss>d__168&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task ChooseBoss(LocalPlayer p, byte choice) { }

	[AsyncStateMachine(typeof(<CleanRoom>d__153))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CleanRoom>d__153)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CleanRoom>d__153&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task CleanRoom(bool informPlayer = true) { }

	[CalledBy(Type = typeof(<CleanRoom>d__153), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "ResetRoom", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "TimeStop", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CancellationTokenSource), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void CleanTimerToken() { }

	[AsyncStateMachine(typeof(<CreateDuel>d__179))]
	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateDuel>d__179)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<CreateDuel>d__179&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task CreateDuel() { }

	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GamePacketFactory), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StocMessage)}, ReturnType = typeof(BinaryWriter))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	private BinaryWriter CreateStartPacket(byte type, int lp1, int lp2, byte md1, byte ed1, byte md2, byte ed2) { }

	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DefineDuelOptions(bool invertPlayers) { }

	[AsyncStateMachine(typeof(<DefineRandomStarter>d__172))]
	[CalledBy(Type = typeof(<SendStartDuel>d__163), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DefineRandomStarter>d__172)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<DefineRandomStarter>d__172&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task DefineRandomStarter() { }

	[AsyncStateMachine(typeof(<End>d__217))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<End>d__217)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<End>d__217&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task End(LocalPlayer surrender = null) { }

	[AsyncStateMachine(typeof(<EndDuel>d__210))]
	[CalledBy(Type = typeof(<OnInternalError>d__209), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Process>d__240), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Surrender>d__191), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EndDuel>d__210)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<EndDuel>d__210&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task EndDuel(bool force, LocalPlayer surrender = null, bool error = false) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public LocalPlayer FindRoomPlayerByID(long id) { }

	[CalledBy(Type = "Game.Local.LocalDuel+<HandleMessage>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAnalyser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalGame)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public GameAnalyser get_Analyzer() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DuelPhase get_CurrentPhase() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public byte get_CurrentPlayer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static float get_DEFAULT_TIMER_MULT() { }

	[CallerCount(Count = 0)]
	public byte get_DrawCount() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_DuelOpt() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public DuelRules get_DuelRule() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ExtraRules get_ExtraRule() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.SByte>), typeof(System.Func`2<System.SByte, System.Boolean>)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool get_FlawlessVictory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = "TSource")]
	[CallsDeduplicatedMethods(Count = 1)]
	public LocalPlayer get_HostEnemy() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LocalPlayer get_HostPlayer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsCustomBanlist() { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Boolean[] get_IsLocked() { }

	[CalledBy(Type = typeof(<RefreshLocation>d__197), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<RefreshSingle>d__201), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TimeStart>d__219), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnResponse>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalPlayer), Member = "OnPause", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	public bool get_IsManual() { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnMatchKill>d__53", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendJoinGame>d__241), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnRematchRequest>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_IsMatch() { }

	[CallerCount(Count = 22)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Boolean[] get_IsReady() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsRelay() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsSingle() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_IsTag() { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnNewTurn>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendHand>d__239), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendJoinGame>d__241), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	public bool get_IsTeam() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public uint get_LFListHash() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public byte get_MasterRule() { }

	[CalledBy(Type = "Game.Local.ManualDuel+PlayerCards", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(ManualDuel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public bool get_NoShuffleDeck() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public sbyte get_PausedBy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>"}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public byte get_PlayerCount() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public LocalPlayer[] get_Players() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_PuzzleName() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public CardSet get_Region() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ServerReplay get_Replay() { }

	[CalledBy(Type = "Game.Local.ManualDuel+<Start>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public byte get_StartHand() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public int get_StartLP() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public GameState get_State() { }

	[CallerCount(Count = 0)]
	public short get_Timer() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public ushort get_TurnCount() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public sbyte get_Winner() { }

	[CalledBy(Type = typeof(<MoveToDuelist>d__156), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnAddBot>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public sbyte GetAvailablePlayerPos() { }

	[AsyncStateMachine(typeof(<GetFieldCount>d__181))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetFieldCount>d__181)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<GetFieldCount>d__181&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Int32>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private Task<Int32> GetFieldCount(int LocalPlayer, CardLocation loc) { }

	[CalledBy(Type = typeof(<SendHand>d__239), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendStartDuel>d__163), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(LocalGame), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 2)]
	public LocalPlayer GetFirstPlayerOfTeam(sbyte team, bool allowBot) { }

	[CalledBy(Type = typeof(<SendJoinGame>d__241), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public byte GetLockedState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalGame), Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
	[CallsUnknownMethods(Count = 2)]
	public LocalPlayer GetOpponentOfPlayer(LocalPlayer p) { }

	[CalledBy(Type = typeof(<HandResult>d__171), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<InitPlayerForDuel>d__180), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendToCorrectDestination>d__198), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Surrender>d__191), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "LockRoomSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(sbyte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "GetRealPlayerIndexOnTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(LocalGame), Member = "GetOpponentOfPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer)}, ReturnType = typeof(LocalPlayer))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "TSource"}, ReturnType = typeof(bool))]
	public sbyte GetPlayerTeam(sbyte type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalGame), Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(LocalGame), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[CallsUnknownMethods(Count = 2)]
	public sbyte GetRealPlayerIndexOnTeam(LocalPlayer p) { }

	[CalledBy(Type = typeof(LocalGame), Member = "GetScriptList", ReturnType = typeof(System.Collections.Generic.List`1<System.String>))]
	[CallerCount(Count = 1)]
	public static string GetRuleScriptName(ExtraRules rule) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(LocalGame), Member = "GetRuleScriptName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtraRules)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public List<String> GetScriptList() { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnTagSwap>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DefineRandomStarter>d__172), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "LockRoomSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(sbyte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "GetRealPlayerIndexOnTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(LocalGame), Member = "SwapTeamPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "GetFirstPlayerOfTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte), typeof(bool)}, ReturnType = typeof(LocalPlayer))]
	[CallerCount(Count = 7)]
	public static Byte[] GetTeamByIndex(sbyte team) { }

	[AsyncStateMachine(typeof(<HandleError>d__246))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleError>d__246)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandleError>d__246&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task HandleError(string error) { }

	[AsyncStateMachine(typeof(<HandResult>d__171))]
	[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandResult>d__171)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<HandResult>d__171&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task HandResult(LocalPlayer LocalPlayer, byte result) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasEmptySlots() { }

	[CalledBy(Type = typeof(<UpdateRules>d__128), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MultiPick), Member = "ValidateExtraRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExtraRules&), typeof(DuelRules)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	private void Initialize() { }

	[AsyncStateMachine(typeof(<InitNewSpectator>d__245))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitNewSpectator>d__245)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitNewSpectator>d__245&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task InitNewSpectator(LocalPlayer LocalPlayer) { }

	[AsyncStateMachine(typeof(<InitPlayerForDuel>d__180))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitPlayerForDuel>d__180)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<InitPlayerForDuel>d__180&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task InitPlayerForDuel(LocalPlayer dplayer, sbyte i, Random rand) { }

	[CalledBy(Type = typeof(<MoveToDuelist>d__156), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool IsPositionAvailable(sbyte pos) { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnMove>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnPosChange>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectCard>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<RefreshSingle>d__201), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WritePublicCards>d__200), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	public static bool IsPublicKnowledge(byte pos, byte loc) { }

	[CalledBy(Type = typeof(<SetReady>d__158), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsReadyToStart() { }

	[AsyncStateMachine(typeof(<KickPlayer>d__160))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<KickPlayer>d__160)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<KickPlayer>d__160&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task KickPlayer(LocalPlayer LocalPlayer, byte pos, bool ban) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalGame), Member = "GetPlayerTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(LocalGame), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public void LockRoomSlot(LocalPlayer LocalPlayer, sbyte pos) { }

	[CalledBy(Type = typeof(<Surrender>d__191), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Byte[] MakeDuelWinPacket(byte win, DuelEndReason reason) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public bool MatchIsEnd() { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnMatchKill>d__53", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void MatchKill() { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnWin>d__13", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<EndDuel>d__210), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Surrender>d__191), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void MatchSaveResult(sbyte LocalPlayer, DuelEndReason reason) { }

	[AsyncStateMachine(typeof(<MatchSide>d__231))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<UpdatePlayerDeck>d__51", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MatchSide>d__231)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MatchSide>d__231&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task MatchSide() { }

	[AsyncStateMachine(typeof(<MoveToDuelist>d__156))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToDuelist>d__156)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToDuelist>d__156&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task MoveToDuelist(LocalPlayer LocalPlayer, sbyte pos = -1) { }

	[AsyncStateMachine(typeof(<MoveToObserver>d__157))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToObserver>d__157)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<MoveToObserver>d__157&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task MoveToObserver(LocalPlayer LocalPlayer) { }

	[AsyncStateMachine(typeof(<OnChatMessage>d__127))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChatMessage>d__127)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnChatMessage>d__127&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Task OnChatMessage(LocalPlayer sender, string msg) { }

	[AsyncStateMachine(typeof(<OnInternalError>d__209))]
	[CalledBy(Type = typeof(<Process>d__240), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<GetFieldCount>d__181), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<Start>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<SetResponse>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<QueryFieldInfo>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<SetResponse>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<PreloadScript>d__12", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<InitPlayers>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<AddTagCard>d__10", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<AddCard>d__9", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalDuel+<QueryCard>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnInternalError>d__209)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<OnInternalError>d__209&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task OnInternalError(Exception e = null) { }

	[AsyncStateMachine(typeof(<Process>d__240))]
	[CalledBy(Type = typeof(<SetResponse>d__208), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Process>d__240)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Process>d__240&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task Process() { }

	[AsyncStateMachine(typeof(<ReassignHostPlayer>d__149))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReassignHostPlayer>d__149)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReassignHostPlayer>d__149&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task ReassignHostPlayer() { }

	[AsyncStateMachine(typeof(<RefreshAll>d__193))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnNewPhase>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnNewTurn>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectBattleCmd>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectIdleCmd>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshAll>d__193)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshAll>d__193&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task RefreshAll() { }

	[AsyncStateMachine(typeof(<RefreshAllObserver>d__196))]
	[CalledBy(Type = typeof(<RefreshReconnect>d__195), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshAllObserver>d__196)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshAllObserver>d__196&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task RefreshAllObserver(LocalPlayer observer, bool reconnect) { }

	[AsyncStateMachine(typeof(<RefreshAllOthers>d__194))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshAllOthers>d__194)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshAllOthers>d__194&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task RefreshAllOthers() { }

	[AsyncStateMachine(typeof(<RefreshLocation>d__197))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnShuffleExtra>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnShuffleHand>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnShuffleSetCard>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSwapGraveDeck>d__31", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnTagSwap>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<DrawCards>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnShuffle>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshLocation>d__197)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshLocation>d__197&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task RefreshLocation(byte LocalPlayer, CardLocation loc, LocalPlayer observer = null, bool reconnect = false) { }

	[AsyncStateMachine(typeof(<RefreshReconnect>d__195))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshReconnect>d__195)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshReconnect>d__195&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task RefreshReconnect(LocalPlayer reconnect) { }

	[AsyncStateMachine(typeof(<RefreshSingle>d__201))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnFlipSummoning>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnMove>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnPosChange>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnAnnounceCard>d__23", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnUpdateCard>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshSingle>d__201)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RefreshSingle>d__201&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task RefreshSingle(byte player, byte location, byte sequence, bool isPublic = false) { }

	[AsyncStateMachine(typeof(<RemoveAllBots>d__215))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RemoveAllBots>d__215)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RemoveAllBots>d__215&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task RemoveAllBots() { }

	[AsyncStateMachine(typeof(<RemovePlayer>d__151))]
	[CalledBy(Type = typeof(<CleanRoom>d__153), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<KickPlayer>d__160), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<Disconnect>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnLeaveGame>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RemovePlayer>d__151)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<RemovePlayer>d__151&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task RemovePlayer(LocalPlayer LocalPlayer, bool informPlayer = true, bool isCleaning = false) { }

	[CalledBy(Type = typeof(<StartDuel>d__162), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void RequestBossDeck() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public void ResetDeckChanges() { }

	[CalledBy(Type = "Game.Local.LocalPlayer+<OnRematchRequest>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalGame), Member = "CleanTimerToken", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void ResetRoom() { }

	[CalledBy(Type = "Game.Local.LocalPlayer+<OnAddBot>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectPuzzle(string puzzleName) { }

	[AsyncStateMachine(typeof(<SendChangingSide>d__212))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendChangingSide>d__212)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendChangingSide>d__212&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Task SendChangingSide(LocalPlayer p) { }

	[AsyncStateMachine(typeof(<SendChangingSideToPlayers>d__211))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendChangingSideToPlayers>d__211)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendChangingSideToPlayers>d__211&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task SendChangingSideToPlayers() { }

	[AsyncStateMachine(typeof(<SendDuelingPlayers>d__242))]
	[CalledBy(Type = typeof(<SendJoinGame>d__241), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendDuelingPlayers>d__242)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendDuelingPlayers>d__242&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task SendDuelingPlayers(LocalPlayer LocalPlayer, bool withPos) { }

	[AsyncStateMachine(typeof(<SendFieldState>d__243))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendFieldState>d__243)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendFieldState>d__243&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task SendFieldState(LocalPlayer p) { }

	[AsyncStateMachine(typeof(<SendHand>d__239))]
	[CalledBy(Type = typeof(<SendStartDuel>d__163), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendHand>d__239)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendHand>d__239&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task SendHand(LocalPlayer p1 = null, LocalPlayer p2 = null) { }

	[AsyncStateMachine(typeof(<SendJoinGame>d__241))]
	[CalledBy(Type = typeof(<AddPlayer>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendJoinGame>d__241)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendJoinGame>d__241&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Task SendJoinGame(LocalPlayer LocalPlayer, bool withPos) { }

	[AsyncStateMachine(typeof(<SendNewRulesToAll>d__129))]
	[CalledBy(Type = typeof(<UpdateRules>d__128), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendNewRulesToAll>d__129)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendNewRulesToAll>d__129&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task SendNewRulesToAll() { }

	[AsyncStateMachine(typeof(<SendStartDuel>d__163))]
	[CalledBy(Type = typeof(<StartDuel>d__162), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendStartDuel>d__163)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendStartDuel>d__163&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task SendStartDuel() { }

	[AsyncStateMachine(typeof(<SendTimeLimit>d__205))]
	[CalledBy(Type = typeof(<TimeStart>d__219), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendTimeLimit>d__205)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendTimeLimit>d__205&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task SendTimeLimit(LocalPlayer tgt = null) { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<SendToAll>d__56", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<AddPlayer>d__147), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<End>d__217), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<EndDuel>d__210), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<HandResult>d__171), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendStartDuel>d__163), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<Surrender>d__191), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "SendToAllBut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "LockRoomSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalPlayer), typeof(sbyte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalPlayer), Member = "OnPause", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<SetResponse>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualDuel), Member = "OnCardTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LocalGame), Member = "SendToObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SendToAll(Byte[] packet) { }

	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public void SendToAll(BinaryWriter packet) { }

	[CalledBy(Type = typeof(LocalGame), Member = "SendToAllBut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void SendToAllBut(Byte[] packet, LocalPlayer except) { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnTagSwap>d__54", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<AssignHostPlayer>d__150), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<OnChatMessage>d__127), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<RedirectClientMessage>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public void SendToAllBut(BinaryWriter packet, LocalPlayer except) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LocalGame), Member = "SendToAllBut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(LocalPlayer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SendToAllBut(Byte[] packet, int except) { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnShuffleExtra>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnShuffleHand>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public void SendToAllBut(BinaryWriter packet, int except) { }

	[AsyncStateMachine(typeof(<SendToCorrectDestination>d__198))]
	[CalledBy(Type = typeof(<RefreshLocation>d__197), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendToCorrectDestination>d__198)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendToCorrectDestination>d__198&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Task SendToCorrectDestination(byte LocalPlayer, CardLocation location, Byte[] result, LocalPlayer observer, bool reconnect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SendToNonBotPlayers(BinaryWriter packet) { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnDraw>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnMove>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<RefreshSingle>d__201), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendToCorrectDestination>d__198), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<DrawCards>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnMove>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnShuffle>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnSpSummoned>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnSpSummoning>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public void SendToObservers(BinaryWriter packet) { }

	[CalledBy(Type = typeof(<EndDuel>d__210), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGame), Member = "SendToAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SendToObservers(Byte[] packet) { }

	[CalledBy(Type = "Game.Local.LocalPlayer+<RedirectClientMessage>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public void SendToObserversBut(BinaryWriter packet, LocalPlayer except) { }

	[CalledBy(Type = typeof(<SendHand>d__239), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SendToPlayers(Byte[] packet) { }

	[CalledBy(Type = typeof(<SendTimeLimit>d__205), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnJanken>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SendToPlayers(BinaryWriter packet) { }

	[CalledBy(Type = "Game.Local.LocalPlayer+<RedirectClientMessage>d__39", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void SendToPlayersBut(BinaryWriter packet, LocalPlayer except) { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnMove>d__35", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualDuel), Member = "SendToOpponentTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualDuel), Member = "SendToTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnSpSummoning>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnSpSummoned>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnShuffle>d__36", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnMove>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<OnQuestionAnswer>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<AskQuestion>d__29", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendToCorrectDestination>d__198), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<RefreshSingle>d__201), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameAnalyser), Member = "SendToOpponentTeam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryWriter), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<SendToTeam>d__59", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.ManualDuel+<DrawCards>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LocalGame), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SendToTeam(BinaryWriter packet, int team) { }

	[AsyncStateMachine(typeof(<SendTPSelect>d__173))]
	[CalledBy(Type = typeof(<SendStartDuel>d__163), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendTPSelect>d__173)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SendTPSelect>d__173&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task SendTPSelect(byte LocalPlayer) { }

	[CalledBy(Type = typeof(<WaitForResponse>d__203), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalPlayer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SendWaiting(sbyte LocalPlayer) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CurrentPhase(DuelPhase value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_CurrentPlayer(byte value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static void set_DEFAULT_TIMER_MULT(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_DuelOpt(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_HostPlayer(LocalPlayer value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsLocked(Boolean[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_IsReady(Boolean[] value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_LFListHash(uint value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_PausedBy(sbyte value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Players(LocalPlayer[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_PuzzleName(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Replay(ServerReplay value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_State(GameState value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public void set_TurnCount(ushort value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Winner(sbyte value) { }

	[AsyncStateMachine(typeof(<SetReady>d__158))]
	[CalledBy(Type = typeof(<UpdateRules>d__128), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnRematchRequest>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetReady>d__158)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetReady>d__158&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task SetReady(LocalPlayer LocalPlayer, bool ready, bool skipCheck = false) { }

	[AsyncStateMachine(typeof(<SetResponse>d__208))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnResponse>d__53", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetResponse>d__208)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetResponse>d__208&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task SetResponse(Byte[] resp) { }

	[AsyncStateMachine(typeof(<SetResponse>d__207))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnResponse>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetResponse>d__207)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetResponse>d__207&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Task SetResponse(LocalPlayer LocalPlayer, BinaryReader resp) { }

	[AsyncStateMachine(typeof(<SetResponse>d__206))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectChain>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetResponse>d__206)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetResponse>d__206&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task SetResponse(int resp) { }

	[CalledBy(Type = typeof(<UpdateRules>d__128), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetRules(GameSettings settings, Banlist bl, uint blHash) { }

	[AsyncStateMachine(typeof(<StartDuel>d__162))]
	[CalledBy(Type = typeof(<SetReady>d__158), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StartDuel>d__162)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StartDuel>d__162&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task StartDuel() { }

	[AsyncStateMachine(typeof(<StartPuzzleDuel>d__164))]
	[CalledBy(Type = typeof(<SendStartDuel>d__163), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StartPuzzleDuel>d__164)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<StartPuzzleDuel>d__164&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task StartPuzzleDuel() { }

	[CalledBy(Type = typeof(<TpResult>d__177), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void StartupDuelState() { }

	[AsyncStateMachine(typeof(<Surrender>d__191))]
	[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Surrender>d__191)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<Surrender>d__191&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task Surrender(LocalPlayer LocalPlayer, DuelEndReason reason, bool force = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalGame), Member = "GetTeamByIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 6)]
	public void SwapTeamPlayer(sbyte team) { }

	[CalledBy(Type = "Game.Local.GameAnalyser+<OnNewTurn>d__33", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void TimeReset() { }

	[AsyncStateMachine(typeof(<TimeStart>d__219))]
	[CalledBy(Type = typeof(<MatchSide>d__231), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendHand>d__239), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendTPSelect>d__173), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<StartPuzzleDuel>d__164), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<WaitForResponse>d__203), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TimeStart>d__219)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TimeStart>d__219&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task TimeStart() { }

	[CalledBy(Type = typeof(<SetResponse>d__206), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SetResponse>d__208), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TimeStart>d__219), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LocalGame), Member = "CleanTimerToken", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void TimeStop() { }

	[AsyncStateMachine(typeof(<TimeTick>d__226))]
	[CalledBy(Type = typeof(<TimeStart>d__219), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TimeTick>d__226)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TimeTick>d__226&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void TimeTick(CancellationTokenSource ct) { }

	[AsyncStateMachine(typeof(<TpResult>d__177))]
	[CalledBy(Type = typeof(<StartPuzzleDuel>d__164), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<TimeTick>d__226), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnTpResult>d__49", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TpResult>d__177)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<TpResult>d__177&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Task TpResult(LocalPlayer LocalPlayer, bool result) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	public static void UpdateJankenTime(byte time) { }

	[AsyncStateMachine(typeof(<UpdateRules>d__128))]
	[CalledBy(Type = "Game.Local.LocalPlayer+<OnCreateGame>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateRules>d__128)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<UpdateRules>d__128&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task UpdateRules(GameSettings gs, uint blHash) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static void UpdateSidingTime(byte time) { }

	[AsyncStateMachine(typeof(<WaitForResponse>d__203))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSortCard>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectYesNo>d__17", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectUnselect>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectSum>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectPlace>d__22", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectOption>d__18", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectIdleCmd>d__15", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectCounter>d__23", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectChain>d__21", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectEffectYn>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectBattleCmd>d__14", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnRockPaperScissors>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnRetry>d__11", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnAnnounceRace>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnAnnounceNumber>d__51", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnAnnounceCardFilter>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnAnnounceCard>d__50", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnAnnounceAttrib>d__49", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Local.GameAnalyser+<OnSelectCard>d__19", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitForResponse>d__203)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WaitForResponse>d__203&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Task WaitForResponse(sbyte LocalPlayer, bool gainTime) { }

	[AsyncStateMachine(typeof(<WritePublicCards>d__200))]
	[CalledBy(Type = typeof(<RefreshSingle>d__201), Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<SendToCorrectDestination>d__198), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WritePublicCards>d__200)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<WritePublicCards>d__200&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Task WritePublicCards(BinaryWriter update, Byte[] result) { }

}

