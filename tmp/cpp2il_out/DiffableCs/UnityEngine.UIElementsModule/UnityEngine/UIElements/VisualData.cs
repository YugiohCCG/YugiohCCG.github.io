namespace UnityEngine.UIElements;

internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData>
{
	public Color backgroundColor; //Field offset: 0x0
	public Background backgroundImage; //Field offset: 0x10
	public BackgroundPosition backgroundPositionX; //Field offset: 0x30
	public BackgroundPosition backgroundPositionY; //Field offset: 0x3C
	public BackgroundRepeat backgroundRepeat; //Field offset: 0x48
	public BackgroundSize backgroundSize; //Field offset: 0x50
	public Color borderBottomColor; //Field offset: 0x64
	public Length borderBottomLeftRadius; //Field offset: 0x74
	public Length borderBottomRightRadius; //Field offset: 0x7C
	public Color borderLeftColor; //Field offset: 0x84
	public Color borderRightColor; //Field offset: 0x94
	public Color borderTopColor; //Field offset: 0xA4
	public Length borderTopLeftRadius; //Field offset: 0xB4
	public Length borderTopRightRadius; //Field offset: 0xBC
	public float opacity; //Field offset: 0xC4
	public OverflowInternal overflow; //Field offset: 0xC8

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override VisualData Copy() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override void CopyFrom(ref VisualData other) { }

	[CalledBy(Type = typeof(VisualData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData), typeof(VisualData)}, ReturnType = typeof(bool))]
	public override bool Equals(VisualData other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Background), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundPosition), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundSize), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(VisualData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(VisualData lhs, VisualData rhs) { }

}

