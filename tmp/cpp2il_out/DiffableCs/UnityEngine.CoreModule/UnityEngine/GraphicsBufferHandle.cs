namespace UnityEngine;

[IsReadOnly]
[NativeClass("GfxBufferID")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public struct GraphicsBufferHandle : IEquatable<GraphicsBufferHandle>
{
	public readonly uint value; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(GraphicsBufferHandle other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

