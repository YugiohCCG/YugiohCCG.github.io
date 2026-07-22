namespace System.Runtime.Remoting.Messaging;

internal class ConstructionCallDictionary : MessageDictionary
{
	public static String[] InternalKeys; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 14)]
	private static ConstructionCallDictionary() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ConstructionCallDictionary(IConstructionCallMessage message) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageDictionary), Member = "GetMethodProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 26)]
	protected virtual object GetMethodProperty(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MessageDictionary), Member = "SetMethodProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	protected virtual void SetMethodProperty(string key, object value) { }

}

