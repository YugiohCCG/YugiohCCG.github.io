namespace System.Runtime.Remoting;

[ComVisible(True)]
public class ActivatedClientTypeEntry : TypeEntry
{
	private string applicationUrl; //Field offset: 0x20
	private Type obj_type; //Field offset: 0x28

	public string ApplicationUrl
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public IContextAttribute[] ContextAttributes
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public Type ObjectType
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
	public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_ApplicationUrl() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public IContextAttribute[] get_ContextAttributes() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public Type get_ObjectType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

