namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class MemberPrimitiveTyped
{
	internal InternalPrimitiveTypeE primitiveTypeEnum; //Field offset: 0x10
	internal object value; //Field offset: 0x18

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MemberPrimitiveTyped() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Read(__BinaryParser input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void Write(__BinaryWriter sout) { }

}

