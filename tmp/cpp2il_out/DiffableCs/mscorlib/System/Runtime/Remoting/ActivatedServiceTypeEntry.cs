namespace System.Runtime.Remoting;

[ComVisible(True)]
public class ActivatedServiceTypeEntry : TypeEntry
{
	private Type obj_type; //Field offset: 0x20

	public Type ObjectType
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public ActivatedServiceTypeEntry(string typeName, string assemblyName) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Type get_ObjectType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

