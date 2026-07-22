namespace System.Runtime.CompilerServices;

[AttributeUsage(11148)]
[CLSCompliant(False)]
public sealed class TupleElementNamesAttribute : Attribute
{
	private readonly String[] _transformNames; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TupleElementNamesAttribute(String[] transformNames) { }

}

