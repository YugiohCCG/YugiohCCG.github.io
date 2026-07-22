namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryMethodReturn
{
	private static object instanceOfVoid; //Field offset: 0x0
	private object returnValue; //Field offset: 0x10
	private Object[] args; //Field offset: 0x18
	private object callContext; //Field offset: 0x20
	private Type[] argTypes; //Field offset: 0x28
	private bool bArgsPrimitive; //Field offset: 0x30
	private MessageEnum messageEnum; //Field offset: 0x34
	private Type returnType; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private static BinaryMethodReturn() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal BinaryMethodReturn() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMethodReturn", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 5)]
	public override void Write(__BinaryWriter sout) { }

}

