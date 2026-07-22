namespace TMPro;

public struct Extents
{
	internal static Extents zero; //Field offset: 0x0
	internal static Extents uninitialized; //Field offset: 0x10
	public Vector2 min; //Field offset: 0x0
	public Vector2 max; //Field offset: 0x8

	[CallerCount(Count = 0)]
	private static Extents() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Extents(Vector2 min, Vector2 max) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	public virtual string ToString() { }

}

