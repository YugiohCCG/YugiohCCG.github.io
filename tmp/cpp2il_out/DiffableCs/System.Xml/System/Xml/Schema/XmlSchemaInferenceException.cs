namespace System.Xml.Schema;

public class XmlSchemaInferenceException : XmlSchemaException
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected XmlSchemaInferenceException(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public XmlSchemaInferenceException() { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlSchemaInferenceException(string res, string arg) { }

	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferSchema1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSchemaSet)}, ReturnType = typeof(XmlSchemaSet))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(bool), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(XmlSchemaObjectTable)}, ReturnType = typeof(XmlSchemaAttribute))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "AddElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(XmlSchema), typeof(XmlSchemaObjectCollection), typeof(int)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "InferElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "CheckSimpleContentExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType)}, ReturnType = typeof(XmlSchemaSimpleContentExtension))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "FindMatchingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(XmlReader), typeof(XmlSchemaComplexType), typeof(Int32&), typeof(Boolean&), typeof(XmlSchema), typeof(bool)}, ReturnType = typeof(XmlSchemaElement))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "ProcessAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement&), typeof(XmlSchemaType), typeof(bool), typeof(XmlSchema)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "MakeExistingAttributesOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaInference), Member = "GetSchemaType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(int))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(string), typeof(int), typeof(int), typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	internal XmlSchemaInferenceException(string res, int lineNumber, int linePosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaException), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

