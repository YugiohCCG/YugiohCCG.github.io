namespace System.Reflection;

[ComVisible(True)]
public class ExceptionHandlingClause
{
	internal Type catch_type; //Field offset: 0x10
	internal int filter_offset; //Field offset: 0x18
	internal ExceptionHandlingClauseOptions flags; //Field offset: 0x1C
	internal int try_offset; //Field offset: 0x20
	internal int try_length; //Field offset: 0x24
	internal int handler_offset; //Field offset: 0x28
	internal int handler_length; //Field offset: 0x2C

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ExceptionHandlingClause() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	public virtual string ToString() { }

}

