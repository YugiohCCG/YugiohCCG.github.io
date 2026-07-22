namespace UnityEngine.Rendering;

[NativeClass("BatchMeshID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct BatchMeshID : IEquatable<BatchMeshID>
{
	public static readonly BatchMeshID Null; //Field offset: 0x0
	public uint value; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static BatchMeshID() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(BatchMeshID other) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = "UnityEngine.Rendering.DrawKey", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DrawKey"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(BatchMeshID a, BatchMeshID b) { }

}

