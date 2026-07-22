namespace System.Runtime.Remoting.Messaging;

internal class CADMethodReturnMessage : CADMessageBase
{
	private object _returnValue; //Field offset: 0x38
	private CADArgHolder _exception; //Field offset: 0x40
	private Type[] _sig; //Field offset: 0x48

	internal int PropertiesCount
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = typeof(CADMethodReturnMessage), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(CADMethodReturnMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CADMessageBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADMessageBase), Member = "MarshalProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDictionary), typeof(ArrayList&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CADMessageBase), Member = "MarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CADMessageBase), Member = "MarshalArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(ArrayList&)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CADMessageBase), Member = "GetMethod", ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(CADMessageBase), Member = "GetSignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(bool)}, ReturnType = typeof(Type[]))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CADMessageBase), Member = "SaveLogicalCallContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage), typeof(ArrayList&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CADSerializer), Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(MemoryStream))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	internal CADMethodReturnMessage(IMethodReturnMessage retMsg) { }

	[CalledBy(Type = typeof(AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage), typeof(Byte[]&), typeof(CADMethodReturnMessage&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CADMethodReturnMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal int get_PropertiesCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(ArrayList)}, ReturnType = typeof(Object[]))]
	[DeduplicatedMethod]
	internal Object[] GetArgs(ArrayList args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal ArrayList GetArguments() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal Exception GetException(ArrayList args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ArrayList)}, ReturnType = typeof(object))]
	internal object GetReturnValue(ArrayList args) { }

}

