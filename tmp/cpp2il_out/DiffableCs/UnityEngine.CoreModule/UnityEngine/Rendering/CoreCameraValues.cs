namespace UnityEngine.Rendering;

[UsedByNativeCode]
internal struct CoreCameraValues : IEquatable<CoreCameraValues>
{
	private int filterMode; //Field offset: 0x0
	private uint cullingMask; //Field offset: 0x4
	private int instanceID; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(CoreCameraValues other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

}

