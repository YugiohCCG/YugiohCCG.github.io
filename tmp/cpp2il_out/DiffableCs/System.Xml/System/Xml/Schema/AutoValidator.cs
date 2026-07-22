namespace System.Xml.Schema;

internal class AutoValidator : BaseValidator
{

	public virtual bool PreserveWhitespace
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlValidatingReaderImpl), typeof(XmlSchemaCollection), typeof(IValidationEventHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public AutoValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void CompleteValidation() { }

	[CalledBy(Type = typeof(AutoValidator), Member = "Validate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaCollection), Member = "GetEnumerator", ReturnType = typeof(XmlSchemaCollectionEnumerator))]
	[Calls(Type = typeof(XmlSchemaCollectionEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaCollectionEnumerator), Member = "get_CurrentNode", ReturnType = typeof(XmlSchemaCollectionNode))]
	[Calls(Type = typeof(BaseValidator), Member = "get_SchemaNames", ReturnType = typeof(SchemaNames))]
	[Calls(Type = typeof(SchemaNames), Member = "SchemaTypeFromRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(SchemaType))]
	[Calls(Type = typeof(XmlSchemaDatatype), Member = "FromXdrName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlSchemaDatatype))]
	[Calls(Type = typeof(XmlValidatingReaderImpl), Member = "set_SchemaTypeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrBuilder), Member = "IsXdrSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	private ValidationType DetectValidationType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual object FindId(string name) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public virtual bool get_PreserveWhitespace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
	[Calls(Type = typeof(XsdValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseValidator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XdrValidator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseValidator)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Validate() { }

}

