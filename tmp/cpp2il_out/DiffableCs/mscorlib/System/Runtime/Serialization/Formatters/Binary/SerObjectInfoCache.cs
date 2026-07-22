namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerObjectInfoCache
{
	internal string fullTypeName; //Field offset: 0x10
	internal string assemblyString; //Field offset: 0x18
	internal bool hasTypeForwardedFrom; //Field offset: 0x20
	internal MemberInfo[] memberInfos; //Field offset: 0x28
	internal String[] memberNames; //Field offset: 0x30
	internal Type[] memberTypes; //Field offset: 0x38

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReadObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeInformation))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal SerObjectInfoCache(Type type) { }

}

