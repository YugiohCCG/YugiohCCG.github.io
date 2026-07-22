namespace System.Xml;

internal class AttributePSVIInfo
{
	internal string localName; //Field offset: 0x10
	internal string namespaceUri; //Field offset: 0x18
	internal object typedAttributeValue; //Field offset: 0x20
	internal XmlSchemaInfo attributeSchemaInfo; //Field offset: 0x28

	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "GetUnspecifiedDefaultAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal AttributePSVIInfo() { }

	[CalledBy(Type = typeof(ValidatingReaderNodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaInfo), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void Reset() { }

}

