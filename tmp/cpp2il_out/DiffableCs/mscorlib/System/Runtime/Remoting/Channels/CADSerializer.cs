namespace System.Runtime.Remoting.Channels;

internal class CADSerializer
{

	[CalledBy(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static object DeserializeObject(MemoryStream mem) { }

	[CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[])}, ReturnType = typeof(ObjRef))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static object DeserializeObjectSafe(Byte[] mem) { }

	[CalledBy(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage)}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink+ProcessMessageRes")]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static MemoryStream SerializeMessage(IMessage msg) { }

	[CalledBy(Type = typeof(AppDomain), Member = "GetMarshalledDomainObjRef", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ObjRef), Member = "SerializeType", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(CADMessageBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CADMethodCallMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodCallMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static MemoryStream SerializeObject(object obj) { }

}

