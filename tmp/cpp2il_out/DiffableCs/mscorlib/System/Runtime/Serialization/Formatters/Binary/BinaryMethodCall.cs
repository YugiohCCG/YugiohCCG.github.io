namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryMethodCall
{
	private string methodName; //Field offset: 0x10
	private string typeName; //Field offset: 0x18
	private Object[] args; //Field offset: 0x20
	private object callContext; //Field offset: 0x28
	private Type[] argTypes; //Field offset: 0x30
	private bool bArgsPrimitive; //Field offset: 0x38
	private MessageEnum messageEnum; //Field offset: 0x3C

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BinaryMethodCall() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal void Dump() { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMethodCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 4)]
	internal void Write(__BinaryWriter sout) { }

}

