namespace System.Diagnostics;

[AttributeUsage(384, AllowMultiple = False)]
[ComVisible(True)]
public sealed class DebuggerBrowsableAttribute : Attribute
{
	private DebuggerBrowsableState state; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public DebuggerBrowsableAttribute(DebuggerBrowsableState state) { }

}

