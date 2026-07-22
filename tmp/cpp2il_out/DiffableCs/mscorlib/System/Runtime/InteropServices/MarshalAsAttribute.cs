namespace System.Runtime.InteropServices;

[AttributeUsage(10496, Inherited = False)]
[ComVisible(True)]
public sealed class MarshalAsAttribute : Attribute
{
	public string MarshalCookie; //Field offset: 0x10
	[ComVisible(True)]
	public string MarshalType; //Field offset: 0x18
	[ComVisible(True)]
	public Type MarshalTypeRef; //Field offset: 0x20
	public Type SafeArrayUserDefinedSubType; //Field offset: 0x28
	private UnmanagedType utype; //Field offset: 0x30
	public UnmanagedType ArraySubType; //Field offset: 0x34
	public VarEnum SafeArraySubType; //Field offset: 0x38
	public int SizeConst; //Field offset: 0x3C
	public int IidParameterIndex; //Field offset: 0x40
	public short SizeParamIndex; //Field offset: 0x44

	public UnmanagedType Value
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MarshalAsAttribute(UnmanagedType unmanagedType) { }

	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal MarshalAsAttribute Copy() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public UnmanagedType get_Value() { }

}

