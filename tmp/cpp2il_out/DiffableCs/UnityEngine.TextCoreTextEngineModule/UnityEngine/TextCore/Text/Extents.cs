namespace UnityEngine.TextCore.Text;

internal struct Extents
{
	public Vector2 min; //Field offset: 0x0
	public Vector2 max; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	public virtual string ToString() { }

}

