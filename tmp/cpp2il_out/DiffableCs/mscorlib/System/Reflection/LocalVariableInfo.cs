namespace System.Reflection;

[ComVisible(True)]
public class LocalVariableInfo
{
	internal Type type; //Field offset: 0x10
	internal bool is_pinned; //Field offset: 0x18
	internal ushort position; //Field offset: 0x1A

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected LocalVariableInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

