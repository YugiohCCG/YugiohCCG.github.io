namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class MemberPrimitiveUnTyped
{
	internal InternalPrimitiveTypeE typeInformation; //Field offset: 0x10
	internal object value; //Field offset: 0x18

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MemberPrimitiveUnTyped() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void Dump() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public override void Read(__BinaryParser input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Write(__BinaryWriter sout) { }

}

