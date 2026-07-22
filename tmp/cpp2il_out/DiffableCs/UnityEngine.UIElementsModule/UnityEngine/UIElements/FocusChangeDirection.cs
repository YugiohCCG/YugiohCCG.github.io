namespace UnityEngine.UIElements;

public class FocusChangeDirection : IDisposable
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly FocusChangeDirection <unspecified>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly FocusChangeDirection <none>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly FocusChangeDirection <lastValue>k__BackingField; //Field offset: 0x10
	private readonly int m_Value; //Field offset: 0x10

	protected static FocusChangeDirection lastValue
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public static FocusChangeDirection none
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public static FocusChangeDirection unspecified
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static FocusChangeDirection() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected FocusChangeDirection(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FocusController), Member = "SwitchFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection), typeof(bool), typeof(DispatchMode)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal override void ApplyTo(FocusController focusController, Focusable f) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	protected static FocusChangeDirection get_lastValue() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static FocusChangeDirection get_none() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static FocusChangeDirection get_unspecified() { }

	[CalledBy(Type = typeof(VisualElementFocusChangeDirection), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFocusChangeTarget+<>c", Member = "<.cctor>b__9_0", ReturnType = typeof(VisualElementFocusChangeTarget))]
	[CalledBy(Type = typeof(VisualElementFocusChangeTarget), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	public static int op_Implicit(FocusChangeDirection fcd) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void System.IDisposable.Dispose() { }

}

