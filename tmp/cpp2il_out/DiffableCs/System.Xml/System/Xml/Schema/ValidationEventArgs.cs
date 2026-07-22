namespace System.Xml.Schema;

public class ValidationEventArgs : EventArgs
{
	private XmlSchemaException ex; //Field offset: 0x10
	private XmlSeverityType severity; //Field offset: 0x18

	public XmlSchemaException Exception
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlSeverityType Severity
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(BaseValidator), Member = "ProcessEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(string), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaInfo), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaInfo), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrValidator), Member = "CheckDefaultValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SchemaAttDef), typeof(SchemaInfo), typeof(XmlNamespaceManager), typeof(XmlNameTable), typeof(object), typeof(ValidationEventHandler), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchema), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler)}, ReturnType = typeof(XmlSchema))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ValidationEventArgs(XmlSchemaException ex) { }

	[CalledBy(Type = typeof(ValidationEventHandling), Member = "System.Xml.IValidationEventHandling.SendEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationEventHandler), typeof(object), typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaValidationException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "CompleteValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "ElementValidationError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(ValidationState), typeof(ValidationEventHandler), typeof(object), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSet), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEventNoThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException), typeof(XmlSeverityType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "AddToTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectTable), typeof(XmlQualifiedName), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseProcessor), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaException)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public XmlSchemaException get_Exception() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlSeverityType get_Severity() { }

}

