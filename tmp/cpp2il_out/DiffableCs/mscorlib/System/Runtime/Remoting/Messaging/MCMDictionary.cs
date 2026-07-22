namespace System.Runtime.Remoting.Messaging;

internal class MCMDictionary : MessageDictionary
{
	public static String[] InternalKeys; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 9)]
	private static MCMDictionary() { }

	[CalledBy(Type = typeof(MethodCall), Member = "InitDictionary", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = "get_Properties", ReturnType = typeof(IDictionary))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public MCMDictionary(IMethodMessage message) { }

}

