namespace UnityEngine.UIElements;

internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData>
{
	public Cursor cursor; //Field offset: 0x0
	public TextOverflow textOverflow; //Field offset: 0x18
	public Color unityBackgroundImageTintColor; //Field offset: 0x1C
	public OverflowClipBox unityOverflowClipBox; //Field offset: 0x2C
	public int unitySliceBottom; //Field offset: 0x30
	public int unitySliceLeft; //Field offset: 0x34
	public int unitySliceRight; //Field offset: 0x38
	public float unitySliceScale; //Field offset: 0x3C
	public int unitySliceTop; //Field offset: 0x40
	public SliceType unitySliceType; //Field offset: 0x44
	public TextOverflowPosition unityTextOverflowPosition; //Field offset: 0x48

	[CallerCount(Count = 0)]
	public override RareData Copy() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void CopyFrom(ref RareData other) { }

	[CalledBy(Type = typeof(RareData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(RareData other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RareData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RareData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(RareData lhs, RareData rhs) { }

}

