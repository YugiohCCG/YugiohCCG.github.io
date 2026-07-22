namespace System.Runtime.Remoting.Messaging;

internal class MethodReturnDictionary : MessageDictionary
{
	public static String[] InternalReturnKeys; //Field offset: 0x0
	public static String[] InternalExceptionKeys; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 12)]
	private static MethodReturnDictionary() { }

	[CalledBy(Type = typeof(ConstructionResponse), Member = "get_Properties", ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(MethodResponse), Member = "get_Properties", ReturnType = typeof(IDictionary))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_Properties", ReturnType = typeof(IDictionary))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public MethodReturnDictionary(IMethodReturnMessage message) { }

}

