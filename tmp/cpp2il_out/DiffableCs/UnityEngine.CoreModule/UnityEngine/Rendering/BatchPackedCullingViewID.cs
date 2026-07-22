namespace UnityEngine.Rendering;

public struct BatchPackedCullingViewID : IEquatable<BatchPackedCullingViewID>
{
	internal ulong handle; //Field offset: 0x0

	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(BatchPackedCullingViewID other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int GetInstanceID() { }

}

