namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
{
	internal string m_Name; //Field offset: 0x0
	[NativeName("m_FeatureType")]
	internal InputFeatureType m_InternalType; //Field offset: 0x8

	internal InputFeatureType internalType
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	public string name
	{
		[CallerCount(Count = 223)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(InputFeatureUsage other) { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	internal InputFeatureType get_internalType() { }

	[CallerCount(Count = 223)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

}

