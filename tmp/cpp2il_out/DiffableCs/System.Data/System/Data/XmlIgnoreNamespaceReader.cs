namespace System.Data;

internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader
{
	private List<String> _namespacesToIgnore; //Field offset: 0x30

	[CalledBy(Type = typeof(DataSet), Member = "InferSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(String[]), typeof(XmlReadMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlNodeReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlIgnoreNamespaceReader(XmlDocument xdoc, String[] namespacesToIgnore) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReader), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNodeReader), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool MoveToNextAttribute() { }

}

