namespace System.Runtime.Remoting;

[ComVisible(True)]
public class WellKnownClientTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x20
	private string obj_url; //Field offset: 0x28
	private string app_url; //Field offset: 0x30

	public string ApplicationUrl
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Type ObjectType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string ObjectUrl
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
	public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_ApplicationUrl() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Type get_ObjectType() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_ObjectUrl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

