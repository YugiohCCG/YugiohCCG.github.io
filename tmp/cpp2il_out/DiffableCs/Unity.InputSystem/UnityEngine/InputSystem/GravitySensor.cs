namespace UnityEngine.InputSystem;

[InputControlLayout(stateType = typeof(GravityState), displayName = "Gravity")]
public class GravitySensor : Sensor
{
	[CompilerGenerated]
	private static GravitySensor <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3Control <gravity>k__BackingField; //Field offset: 0x190

	public private static GravitySensor current
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 54
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		private set { } //Length: 81
	}

	public Vector3Control gravity
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
	public GravitySensor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "GetChildControl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TControl"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "TControl")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static GravitySensor get_current() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Vector3Control get_gravity() { }

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
	private static void set_current(GravitySensor value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_gravity(Vector3Control value) { }

}

