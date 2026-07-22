namespace System.Xml.Linq;

public abstract class XContainer : XNode
{
	[CompilerGenerated]
	private sealed class <Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private XNode <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public XContainer <>4__this; //Field offset: 0x28
		private XNode <n>5__2; //Field offset: 0x30

		private override XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 31)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 5
		}

		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <Nodes>d__18(int <>1__state) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[CallerCount(Count = 31)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[CallerCount(Count = 13327)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override void System.IDisposable.Dispose() { }

	}

	private sealed class ContentReader
	{
		private readonly NamespaceCache _eCache; //Field offset: 0x10
		private readonly NamespaceCache _aCache; //Field offset: 0x20
		private readonly IXmlLineInfo _lineInfo; //Field offset: 0x30
		private XContainer _currentContainer; //Field offset: 0x38
		private string _baseUri; //Field offset: 0x40

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ContentReader(XContainer rootContainer) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o) { }

		[CalledBy(Type = typeof(XContainer), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XContainer), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XNamespace))]
		[Calls(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(XName))]
		[Calls(Type = typeof(XContainer), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XAttribute), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XContainer), Member = "AddNodeSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XProcessingInstruction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XDocumentType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XContainer), Member = "AddStringSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 26)]
		[CallsUnknownMethods(Count = 63)]
		public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

		[CalledBy(Type = typeof(XContainer), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsInvalidInstructions]
		public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	}

	internal object content; //Field offset: 0x28

	public XNode LastNode
	{
		[CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "get_HasChildNodes", ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Converters.XContainerWrapper", Member = "get_HasChildNodes", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 328
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XContainer() { }

	[CalledBy(Type = typeof(XDocument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XDocument)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDocument), Member = "CloneNode", ReturnType = typeof(XNode))]
	[CalledBy(Type = typeof(XElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "CloneNode", ReturnType = typeof(XNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XContainer), Member = "AppendNodeSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	internal XContainer(XContainer other) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XContainerWrapper", Member = "AppendChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Converters.IXmlNode"}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "SetAttributeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Converters.IXmlNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(XContainer), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XContainer), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XContainer), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public void Add(object content) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void AddAttribute(XAttribute a) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	[CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XStreamingElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XContainer), Member = "AddNodeSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XContainer), Member = "GetStringValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XContainer), Member = "AddStringSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	internal void AddContentSkipNotify(object content) { }

	[CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XContainer), Member = "ConvertTextToNode", ReturnType = typeof(void))]
	[Calls(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void AddNode(XNode n) { }

	[CalledBy(Type = typeof(ContentReader), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XContainer), Member = "ConvertTextToNode", ReturnType = typeof(void))]
	[Calls(Type = typeof(XContainer), Member = "AppendNodeSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal void AddNodeSkipNotify(XNode n) { }

	[CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XContainer), Member = "ConvertTextToNode", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	internal void AddString(string s) { }

	[CalledBy(Type = typeof(ContentReader), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XContainer), Member = "AppendNodeSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal void AddStringSkipNotify(string s) { }

	[CalledBy(Type = typeof(XContainer), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XContainer), Member = "AppendNodeSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void AppendNode(XNode n) { }

	[CalledBy(Type = typeof(XContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddNodeSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddStringSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	internal void AppendNodeSkipNotify(XNode n) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal virtual void AppendText(StringBuilder sb) { }

	[CalledBy(Type = typeof(XContainer), Member = "RemoveNodes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddNodeSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal void ConvertTextToNode() { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "get_HasChildNodes", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Converters.XContainerWrapper", Member = "get_HasChildNodes", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public XNode get_LastNode() { }

	[CalledBy(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContentReader), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "ReadElementFromImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(XmlDateTimeSerializationMode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	internal static string GetStringValue(object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Converters.XContainerWrapper", Member = "get_ChildNodes", ReturnType = "System.Collections.Generic.List`1<IXmlNode>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<Nodes>d__18))]
	public IEnumerable<XNode> Nodes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ContentReader), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	internal void ReadContentFrom(XmlReader r) { }

	[CalledBy(Type = typeof(XElement), Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "ReadElementFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ContentReader), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader), typeof(LoadOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ContentReader), Member = "ReadContentFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XContainer), typeof(XmlReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	[CalledBy(Type = typeof(XNode), Member = "Remove", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	internal void RemoveNode(XNode n) { }

	[CalledBy(Type = typeof(XElement), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XContainer), Member = "ConvertTextToNode", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	public void RemoveNodes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveNodesSkipNotify() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void ValidateNode(XNode node, XNode previous) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	internal override void ValidateString(string s) { }

	[CalledBy(Type = typeof(XDocument), Member = "WriteTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XNode), Member = "GetXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SaveOptions)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void WriteContentTo(XmlWriter writer) { }

}

