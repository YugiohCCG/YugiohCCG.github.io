namespace Effects;

public class SynchroSummon : MonoBehaviour
{
	[CompilerGenerated]
	private struct <SetLevel>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SynchroSummon <>4__this; //Field offset: 0x28
		public sbyte lv; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncExtensions), Member = "WaitUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(EmissionModule), Member = "get_burstCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(EmissionModule), Member = "GetBurst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Burst))]
		[Calls(Type = typeof(MinMaxCurve), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(MinMaxCurve))]
		[Calls(Type = typeof(Burst), Member = "set_count", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxCurve)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(EmissionModule), Member = "SetBurst", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Burst)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		private override void MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public ParticleSystem RMSystem; //Field offset: 0x20

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SynchroSummon() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParticleSystem), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private bool <SetLevel>b__2_0() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SynchroSummon), Member = "SetLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetLevel(SynchroSummon target, object callback) { }

	[AsyncStateMachine(typeof(<SetLevel>d__2))]
	[CalledBy(Type = typeof(SpineSummon), Member = "DefineData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Card), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SynchroSummon), Member = "SetLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SynchroSummon), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Create", ReturnType = typeof(AsyncVoidMethodBuilder))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetLevel>d__2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<SetLevel>d__2&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void SetLevel(sbyte lv) { }

}

