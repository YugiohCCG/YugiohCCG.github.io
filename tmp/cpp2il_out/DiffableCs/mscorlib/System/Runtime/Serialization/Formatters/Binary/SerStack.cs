namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerStack
{
	internal Object[] objects; //Field offset: 0x10
	internal string stackId; //Field offset: 0x18
	internal int top; //Field offset: 0x20

	[CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[]), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerObjectInfoInit), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "get_ValueFixupStack", ReturnType = typeof(SerStack))]
	[CalledBy(Type = typeof(ObjectReader), Member = "InitFullDeserialization", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISurrogateSelector), typeof(StreamingContext), typeof(InternalFE), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(ObjectReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectProgress)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal SerStack(string stackId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void IncreaseCapacity() { }

	[CalledBy(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit)}, ReturnType = typeof(WriteObjectInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool IsEmpty() { }

	[CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMemberEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 2)]
	internal object Peek() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal object PeekPeek() { }

	[CalledBy(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit)}, ReturnType = typeof(WriteObjectInfo))]
	[CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseSerializedStreamHeaderEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	internal object Pop() { }

	[CalledBy(Type = typeof(WriteObjectInfo), Member = "ObjectEnd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectProgress)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryHeaderEnum)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "PutNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseSerializedStreamHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "PutObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMemberSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(string), typeof(Type), typeof(object), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal void Push(object obj) { }

}

