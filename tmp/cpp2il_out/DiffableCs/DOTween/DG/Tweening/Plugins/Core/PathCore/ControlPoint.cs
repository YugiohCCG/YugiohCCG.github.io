namespace DG.Tweening.Plugins.Core.PathCore;

public struct ControlPoint
{
	public Vector3 a; //Field offset: 0x0
	public Vector3 b; //Field offset: 0xC

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ControlPoint(Vector3 a, Vector3 b) { }

	[CallerCount(Count = 0)]
	public static ControlPoint op_Addition(ControlPoint cp, Vector3 v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 9)]
	public virtual string ToString() { }

}

