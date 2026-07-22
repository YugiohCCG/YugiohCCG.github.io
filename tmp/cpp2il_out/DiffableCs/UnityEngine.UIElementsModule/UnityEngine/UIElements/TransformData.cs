namespace UnityEngine.UIElements;

internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData>
{
	public Rotate rotate; //Field offset: 0x0
	public Scale scale; //Field offset: 0x18
	public TransformOrigin transformOrigin; //Field offset: 0x28
	public Translate translate; //Field offset: 0x3C

	[CallerCount(Count = 0)]
	public override TransformData Copy() { }

	[CallerCount(Count = 0)]
	public override void CopyFrom(ref TransformData other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformData), typeof(TransformData)}, ReturnType = typeof(bool))]
	public override bool Equals(TransformData other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformData), typeof(TransformData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rotate), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(TransformData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransformData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(TransformData lhs, TransformData rhs) { }

}

