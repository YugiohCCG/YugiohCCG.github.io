namespace UnityEngine.UIElements;

public class FocusOutEvent : FocusEventBase<FocusOutEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FocusEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
		internal FocusOutEvent <.cctor>b__0_0() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventBase`1), Member = "SetCreateFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static FocusOutEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusEventBase`1), Member = ".ctor", ReturnType = typeof(void))]
	public FocusOutEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusEventBase`1), Member = "Init", ReturnType = typeof(void))]
	protected virtual void Init() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void LocalInit() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "ProcessPendingFocusChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected private virtual void PostDispatch(IPanel panel) { }

}

