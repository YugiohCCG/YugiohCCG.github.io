namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectProgress
{
	internal static int opRecordIdCount; //Field offset: 0x0
	internal bool isInitial; //Field offset: 0x10
	internal int count; //Field offset: 0x14
	internal BinaryTypeEnum expectedType; //Field offset: 0x18
	internal object expectedTypeInformation; //Field offset: 0x20
	internal string name; //Field offset: 0x28
	internal InternalObjectTypeE objectTypeEnum; //Field offset: 0x30
	internal InternalMemberTypeE memberTypeEnum; //Field offset: 0x34
	internal InternalMemberValueE memberValueEnum; //Field offset: 0x38
	internal Type dtType; //Field offset: 0x40
	internal int numItems; //Field offset: 0x48
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x4C
	internal object typeInformation; //Field offset: 0x50
	internal int nullCount; //Field offset: 0x58
	internal int memberLength; //Field offset: 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x60
	internal Object[] typeInformationA; //Field offset: 0x68
	internal String[] memberNames; //Field offset: 0x70
	internal Type[] memberTypes; //Field offset: 0x78
	internal ParseRecord pr; //Field offset: 0x80

	[CallerCount(Count = 0)]
	private static ObjectProgress() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal ObjectProgress() { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal void ArrayCountIncrement(int value) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	internal void Init() { }

}

