namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(AccelerometerState))]
public class Accelerometer : Sensor
{
	[CompilerGenerated]
	private static Accelerometer <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3Control <acceleration>k__BackingField; //Field offset: 0x190

	public Vector3Control acceleration
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

	public private static Accelerometer current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 81
	}

	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Accelerometer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector3Control get_acceleration() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static Accelerometer get_current() { }

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
	[DeduplicatedMethod]
	protected void set_acceleration(Vector3Control value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private static void set_current(Accelerometer value) { }

}

