namespace UnityEngine;

[UsedByNativeCode]
public struct Plane : IFormattable
{
	internal const int size = 16; //Field offset: 0x0
	private Vector3 m_Normal; //Field offset: 0x0
	private float m_Distance; //Field offset: 0xC

	public float distance
	{
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Vector3 normal
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 18
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	public Plane(Vector3 inNormal, Vector3 inPoint) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	public Plane(Vector3 inNormal, float d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	public Plane(Vector3 a, Vector3 b, Vector3 c) { }

	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	public float get_distance() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public Vector3 get_normal() { }

	[CallerCount(Count = 0)]
	public float GetDistanceToPoint(Vector3 point) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool Raycast(Ray ray, out float enter) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

