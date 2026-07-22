namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectWriter
{
	private Queue m_objectQueue; //Field offset: 0x10
	private ObjectIDGenerator m_idGenerator; //Field offset: 0x18
	private int m_currentId; //Field offset: 0x20
	private ISurrogateSelector m_surrogates; //Field offset: 0x28
	private StreamingContext m_context; //Field offset: 0x30
	private __BinaryWriter serWriter; //Field offset: 0x40
	private SerializationObjectManager m_objectManager; //Field offset: 0x48
	private long topId; //Field offset: 0x50
	private string topName; //Field offset: 0x58
	private Header[] headers; //Field offset: 0x60
	private InternalFE formatterEnums; //Field offset: 0x68
	private SerializationBinder m_binder; //Field offset: 0x70
	private SerObjectInfoInit serObjectInfoInit; //Field offset: 0x78
	private IFormatterConverter m_formatterConverter; //Field offset: 0x80
	internal Object[] crossAppDomainArray; //Field offset: 0x88
	private object previousObj; //Field offset: 0x90
	private long previousId; //Field offset: 0x98
	private Type previousType; //Field offset: 0xA0
	private InternalPrimitiveTypeE previousCode; //Field offset: 0xA8
	private Hashtable assemblyToIdTable; //Field offset: 0xB0
	private SerStack niPool; //Field offset: 0xB8

	internal SerializationObjectManager ObjectManager
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 254
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationObjectManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectNull), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal SerializationObjectManager get_ObjectManager() { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 7)]
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(String[]), typeof(Type[]), typeof(Object[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMemberSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(string), typeof(Type), typeof(object), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(InternalPrimitiveTypeE), typeof(NameInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "MemberToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameInfo))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(SerStack), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerStack), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(NameInfo), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private NameInfo GetNameInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private object GetNext(out long objID) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 1)]
	private Type GetType(object obj) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(Type)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Schedule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(Type), typeof(WriteObjectInfo)}, ReturnType = typeof(long))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallsUnknownMethods(Count = 2)]
	private NameInfo MemberToNameInfo(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void PutNameInfo(NameInfo nameInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectWriter), Member = "InternalGetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(Type), typeof(Boolean&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectWriter), Member = "InternalGetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(Type), typeof(Boolean&)}, ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	[CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object), typeof(Header[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationObjectManager), Member = "RaiseOnSerializedEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(NameInfo))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(ObjectWriter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit)}, ReturnType = typeof(WriteObjectInfo))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteSerializedStreamHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerObjectInfoInit), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectIDGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 36)]
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMemberSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(string), typeof(Type), typeof(object), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[CallsUnknownMethods(Count = 1)]
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallsUnknownMethods(Count = 2)]
	private NameInfo TypeToNameInfo(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NameInfo), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallsUnknownMethods(Count = 3)]
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(NameInfo), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallsUnknownMethods(Count = 2)]
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallsUnknownMethods(Count = 3)]
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(NameInfo), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallsUnknownMethods(Count = 3)]
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteMemberSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(string), typeof(Type), typeof(object), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(ObjectWriter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit)}, ReturnType = typeof(WriteObjectInfo))]
	[Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(int), typeof(String[]), typeof(Type[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(int), typeof(String[]), typeof(Type[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteMemberSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(string), typeof(Type), typeof(object), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, String[] memberNames, Type[] memberTypes, Object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "GetUpperBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Int32[]), typeof(Int32[]), typeof(BinaryTypeEnum), typeof(object), typeof(BinaryArrayTypeEnum), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(string), typeof(ObjectWriter), typeof(Object&), typeof(Int32&)}, ReturnType = typeof(BinaryTypeEnum))]
	[Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit)}, ReturnType = typeof(WriteObjectInfo))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(int), typeof(Int32[]), typeof(Array), typeof(NameInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectWriter), Member = "InternalGetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(Type), typeof(Boolean&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(NameInfo))]
	[Calls(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(ObjectWriter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoInit)}, ReturnType = typeof(WriteObjectInfo))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(NameInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(NameInfo), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMemberSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(string), typeof(Type), typeof(object), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo)}, ReturnType = typeof(NameInfo))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "InternalGetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool), typeof(Type), typeof(Boolean&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NameInfo), Member = "Init", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectNull), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__BinaryWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(NameInfo), typeof(String[]), typeof(Type[]), typeof(Object[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternalPrimitiveTypeE))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, Int32[] maxA, Array array, NameInfo arrayElemNameTypeInfo, Int32[] lowerBoundA) { }

	[CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Header[]), typeof(__BinaryWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
	[Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

}

