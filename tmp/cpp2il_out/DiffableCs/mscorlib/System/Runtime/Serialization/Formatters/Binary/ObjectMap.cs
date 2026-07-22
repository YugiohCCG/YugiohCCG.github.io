namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectMap
{
	internal string objectName; //Field offset: 0x10
	internal Type objectType; //Field offset: 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x20
	internal Object[] typeInformationA; //Field offset: 0x28
	internal Type[] memberTypes; //Field offset: 0x30
	internal String[] memberNames; //Field offset: 0x38
	internal ReadObjectInfo objectInfo; //Field offset: 0x40
	internal bool isInitObjectInfo; //Field offset: 0x48
	internal ObjectReader objectReader; //Field offset: 0x50
	internal int objectId; //Field offset: 0x58
	internal BinaryAssemblyInfo assemblyInfo; //Field offset: 0x60

	[CalledBy(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(String[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo)}, ReturnType = typeof(ObjectMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(ObjectManager), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(bool)}, ReturnType = typeof(ReadObjectInfo))]
	[Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Type)}, ReturnType = typeof(Type[]))]
	[Calls(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	internal ObjectMap(string objectName, Type objectType, String[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	[CalledBy(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(BinaryTypeEnum[]), typeof(Object[]), typeof(Int32[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo), typeof(SizedArray)}, ReturnType = typeof(ObjectMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryAssemblyInfo), typeof(string)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SizedArray), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryTypeEnum), typeof(object), typeof(ObjectReader), typeof(BinaryAssemblyInfo), typeof(InternalPrimitiveTypeE&), typeof(String&), typeof(Type&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(Type)}, ReturnType = typeof(Type[]))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 31)]
	internal ObjectMap(string objectName, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(String[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo)}, ReturnType = typeof(void))]
	internal static ObjectMap Create(string name, Type objectType, String[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(BinaryTypeEnum[]), typeof(Object[]), typeof(Int32[]), typeof(ObjectReader), typeof(int), typeof(BinaryAssemblyInfo), typeof(SizedArray)}, ReturnType = typeof(void))]
	internal static ObjectMap Create(string name, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryObjectWithMapTyped)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ReadObjectInfo), Member = "InitDataStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo&), typeof(Object[]&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref Object[] memberData) { }

}

