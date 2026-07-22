namespace System.Runtime.Remoting;

[ComVisible(True)]
public class SoapServices
{
	private class TypeInfo
	{
		public Hashtable Attributes; //Field offset: 0x10
		public Hashtable Elements; //Field offset: 0x18

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public TypeInfo() { }

	}

	private static Hashtable _xmlTypes; //Field offset: 0x0
	private static Hashtable _xmlElements; //Field offset: 0x8
	private static Hashtable _soapActions; //Field offset: 0x10
	private static Hashtable _soapActionsMethods; //Field offset: 0x18
	private static Hashtable _typeInfos; //Field offset: 0x20

	public static string XmlNsForClrTypeWithAssembly
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public static string XmlNsForClrTypeWithNs
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	public static string XmlNsForClrTypeWithNsAndAssembly
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 44
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static SoapServices() { }

	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SoapTypeAttribute), Member = "SetReflectionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private static string EncodeNs(string ns) { }

	[CallerCount(Count = 0)]
	public static string get_XmlNsForClrTypeWithAssembly() { }

	[CallerCount(Count = 0)]
	public static string get_XmlNsForClrTypeWithNs() { }

	[CallerCount(Count = 0)]
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SoapServices), Member = "GetXmlNamespaceForMethodResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetAssemblyName(MethodBase mb) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	private static string GetNameKey(string name, string namspace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SoapAttribute))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	[CalledBy(Type = typeof(SoapMethodAttribute), Member = "SetReflectionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SoapServices), Member = "GetAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	[CalledBy(Type = typeof(SoapMethodAttribute), Member = "SetReflectionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SoapServices), Member = "GetAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SoapServices), Member = "CodeXmlNamespaceForClrTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SoapAttribute))]
	[CallsUnknownMethods(Count = 6)]
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void PreLoad(Assembly assembly) { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadPreload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InternalRemotingServices), Member = "GetCachedSoapAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SoapAttribute))]
	[Calls(Type = typeof(SoapServices), Member = "RegisterInteropXmlType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoapServices), Member = "RegisterInteropXmlElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 24)]
	public static void PreLoad(Type type) { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadInteropXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadInteropXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoapServices), Member = "PreLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

}

