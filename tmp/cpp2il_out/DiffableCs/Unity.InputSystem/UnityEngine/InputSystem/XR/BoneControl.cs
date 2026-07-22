namespace UnityEngine.InputSystem.XR;

public class BoneControl : InputControl<Bone>
{
	[CompilerGenerated]
	private IntegerControl <parentBoneIndex>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private Vector3Control <position>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private QuaternionControl <rotation>k__BackingField; //Field offset: 0x150

	[InputControl(offset = 0, displayName = "parentBoneIndex")]
	public IntegerControl parentBoneIndex
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

	[InputControl(offset = 4, displayName = "Position")]
	public Vector3Control position
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 96
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 19
	}

	[InputControl(offset = 16, displayName = "Rotation")]
	public QuaternionControl rotation
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
	public BoneControl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[Calls(Type = typeof(InputControl`1), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public IntegerControl get_parentBoneIndex() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector3Control get_position() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public QuaternionControl get_rotation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "ReadUnprocessedValueFromStateWithCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Vector3>), Member = "ReadUnprocessedValueFromStateWithCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<UnityEngine.Quaternion>), Member = "ReadUnprocessedValueFromStateWithCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(Quaternion))]
	[CallsUnknownMethods(Count = 1)]
	public virtual Bone ReadUnprocessedValueFromState(Void* statePtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_parentBoneIndex(IntegerControl value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_position(Vector3Control value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_rotation(QuaternionControl value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual void WriteValueIntoState(Bone value, Void* statePtr) { }

}

