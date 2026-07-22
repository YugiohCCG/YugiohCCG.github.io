namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObjectWithMapTyped
{
	internal BinaryHeaderEnum binaryHeaderEnum; //Field offset: 0x10
	internal int objectId; //Field offset: 0x14
	internal string name; //Field offset: 0x18
	internal int numMembers; //Field offset: 0x20
	internal String[] memberNames; //Field offset: 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x30
	internal Object[] typeInformationA; //Field offset: 0x38
	internal Int32[] memberAssemIds; //Field offset: 0x40
	internal int assemId; //Field offset: 0x48

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BinaryObjectWithMapTyped() { }

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
	[Calls(Type = typeof(__BinaryParser), Member = "ReadString", ReturnType = typeof(string))]
	[Calls(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(__BinaryParser), typeof(Int32&)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public override void Read(__BinaryParser input) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal void Set(int objectId, string name, int numMembers, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, int assemId) { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(int), typeof(String[]), typeof(Type[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinaryConverter), Member = "WriteTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(int), typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public override void Write(__BinaryWriter sout) { }

}

