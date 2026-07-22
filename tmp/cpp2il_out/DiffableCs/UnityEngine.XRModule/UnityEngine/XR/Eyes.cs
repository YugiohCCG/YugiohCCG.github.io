namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
public struct Eyes : IEquatable<Eyes>
{
	private ulong m_DeviceId; //Field offset: 0x0
	private uint m_FeatureIndex; //Field offset: 0x8

	internal ulong deviceId
	{
		[CallerCount(Count = 223)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal uint featureIndex
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(Eyes other) { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	internal ulong get_deviceId() { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	internal uint get_featureIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

