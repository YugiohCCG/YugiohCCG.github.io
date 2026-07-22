namespace UnityEngine.UIElements;

public abstract class MouseManipulator : Manipulator
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private List<ManipulatorActivationFilter> <activators>k__BackingField; //Field offset: 0x18

	public private List<ManipulatorActivationFilter> activators
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

	[CalledBy(Type = typeof(PointerManipulator), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected MouseManipulator() { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public List<ManipulatorActivationFilter> get_activators() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_activators(List<ManipulatorActivationFilter> value) { }

}

