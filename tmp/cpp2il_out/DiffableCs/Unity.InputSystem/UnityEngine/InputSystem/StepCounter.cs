namespace UnityEngine.InputSystem;

[InputControlLayout(displayName = "Step Counter")]
public class StepCounter : Sensor
{
	[CompilerGenerated]
	private static StepCounter <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private IntegerControl <stepCounter>k__BackingField; //Field offset: 0x190

	public private static StepCounter current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 81
	}

	[InputControl(displayName = "Step Counter", noisy = True)]
	public IntegerControl stepCounter
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public StepCounter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static StepCounter get_current() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IntegerControl get_stepCounter() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void MakeCurrent() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnRemoved() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_current(StepCounter value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_stepCounter(IntegerControl value) { }

}

