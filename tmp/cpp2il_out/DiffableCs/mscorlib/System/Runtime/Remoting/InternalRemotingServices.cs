namespace System.Runtime.Remoting;

[ComVisible(True)]
public class InternalRemotingServices
{
	private static Hashtable _soapAttributes; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static InternalRemotingServices() { }

	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlElementForInteropType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlTypeForInteropType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 14)]
	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject) { }

}

