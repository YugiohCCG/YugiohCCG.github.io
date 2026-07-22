namespace System.Runtime.Remoting;

[ComVisible(True)]
public class WellKnownServiceTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x20
	private string obj_uri; //Field offset: 0x28
	private WellKnownObjectMode obj_mode; //Field offset: 0x30

	public WellKnownObjectMode Mode
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Type ObjectType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string ObjectUri
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public WellKnownObjectMode get_Mode() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Type get_ObjectType() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_ObjectUri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public virtual string ToString() { }

}

