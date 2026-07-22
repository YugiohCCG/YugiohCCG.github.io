namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[UsedByNativeCode]
public struct InputDevice : IEquatable<InputDevice>
{
	private ulong m_DeviceId; //Field offset: 0x0
	private bool m_Initialized; //Field offset: 0x8

	private ulong deviceId
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 18
	}

	[CallerCount(Count = 0)]
	internal InputDevice(ulong deviceId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(InputDevice other) { }

	[CallerCount(Count = 0)]
	private ulong get_deviceId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

}

