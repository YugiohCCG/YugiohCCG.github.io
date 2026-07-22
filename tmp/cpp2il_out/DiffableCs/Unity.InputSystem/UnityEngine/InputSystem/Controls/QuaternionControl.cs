namespace UnityEngine.InputSystem.Controls;

public class QuaternionControl : InputControl<Quaternion>
{
	[CompilerGenerated]
	private AxisControl <x>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private AxisControl <y>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private AxisControl <z>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private AxisControl <w>k__BackingField; //Field offset: 0x138

	[InputControl(displayName = "W")]
	public AxisControl w
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[InputControl(displayName = "X")]
	public AxisControl x
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[InputControl(displayName = "Y")]
	public AxisControl y
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[InputControl(displayName = "Z")]
	public AxisControl z
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl`1), Member = ".ctor", ReturnType = typeof(void))]
	public QuaternionControl() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual FourCC CalculateOptimizedControlDataType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Quaternion>), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AxisControl get_w() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AxisControl get_x() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AxisControl get_y() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public AxisControl get_z() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromStateWithCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadUnprocessedValueFromStateWithCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Quaternion ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_w(AxisControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_x(AxisControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_y(AxisControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_z(AxisControl value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValueIntoState(Quaternion value, Void* statePtr) { }

}

