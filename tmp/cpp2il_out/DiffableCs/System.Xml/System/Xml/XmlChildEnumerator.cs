namespace System.Xml;

internal sealed class XmlChildEnumerator : IEnumerator
{
	internal XmlNode container; //Field offset: 0x10
	internal XmlNode child; //Field offset: 0x18
	internal bool isFirst; //Field offset: 0x20

	internal XmlNode Current
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		internal get { } //Length: 131
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		private get { } //Length: 131
	}

	[CalledBy(Type = typeof(XmlDocumentFragment), Member = "WriteContentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEntityReference), Member = "WriteContentTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlNode), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CalledBy(Type = typeof(XmlNode), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal XmlChildEnumerator(XmlNode container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal XmlNode get_Current() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool MoveNext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private override object System.Collections.IEnumerator.get_Current() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Collections.IEnumerator.Reset() { }

}

