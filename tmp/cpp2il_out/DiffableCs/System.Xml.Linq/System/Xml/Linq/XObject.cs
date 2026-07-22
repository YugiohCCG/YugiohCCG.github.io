namespace System.Xml.Linq;

public abstract class XObject : IXmlLineInfo
{
	internal XContainer parent; //Field offset: 0x10
	internal object annotations; //Field offset: 0x18

	public string BaseUri
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		 get { } //Length: 114
	}

	internal bool HasBaseUri
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 64
	}

	public abstract XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public XElement Parent
	{
		[CalledBy(Type = "Newtonsoft.Json.Converters.XTextWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[CalledBy(Type = "Newtonsoft.Json.Converters.XCommentWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[CalledBy(Type = "Newtonsoft.Json.Converters.XContainerWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[CalledBy(Type = "Newtonsoft.Json.Converters.XAttributeWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[CallerCount(Count = 8)]
		 get { } //Length: 114
	}

	private override int System.Xml.IXmlLineInfo.LineNumber
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		private get { } //Length: 72
	}

	private override int System.Xml.IXmlLineInfo.LinePosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		private get { } //Length: 72
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XObject() { }

	[CalledBy(Type = typeof(XElement), Member = "ReadElementFromImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "SetEndElementLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XObject), Member = "SetBaseUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XObject), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 25)]
	public void AddAnnotation(object annotation) { }

	[CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "RemoveNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "RemoveNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XObject), Member = "get_BaseUri", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XObject), Member = "System.Xml.IXmlLineInfo.HasLineInfo", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XObject), Member = "System.Xml.IXmlLineInfo.get_LineNumber", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XObject), Member = "System.Xml.IXmlLineInfo.get_LinePosition", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XObject), Member = "get_HasBaseUri", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XObject), Member = "SkipNotify", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public T Annotation() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private object AnnotationForSealedType(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	public string get_BaseUri() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[ContainsUnimplementedInstructions]
	internal bool get_HasBaseUri() { }

	public abstract XmlNodeType get_NodeType() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XTextWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XCommentWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XContainerWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XAttributeWrapper", Member = "get_ParentNode", ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CallerCount(Count = 8)]
	public XElement get_Parent() { }

	[CalledBy(Type = typeof(XNode), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal SaveOptions GetSaveOptionsFromAnnotations() { }

	[CalledBy(Type = typeof(XAttribute), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XComment), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "RemoveNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "AppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XText), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	[CalledBy(Type = typeof(XAttribute), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XComment), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "RemoveNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "RemoveNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "AppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XProcessingInstruction), Member = "set_Data", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XText), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	[CalledBy(Type = typeof(XElement), Member = "ReadElementFromImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XObject), Member = "AddAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void SetBaseUri(string baseUri) { }

	[CalledBy(Type = typeof(XElement), Member = "ReadElementFromImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XObject), Member = "AddAnnotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	internal bool SkipNotify() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	private override int System.Xml.IXmlLineInfo.get_LineNumber() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	private override int System.Xml.IXmlLineInfo.get_LinePosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[ContainsUnimplementedInstructions]
	private override bool System.Xml.IXmlLineInfo.HasLineInfo() { }

}

