namespace System.Diagnostics;

[AttributeUsage(13, AllowMultiple = True)]
[ComVisible(True)]
public sealed class DebuggerTypeProxyAttribute : Attribute
{
	private string typeName; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public DebuggerTypeProxyAttribute(Type type) { }

}

