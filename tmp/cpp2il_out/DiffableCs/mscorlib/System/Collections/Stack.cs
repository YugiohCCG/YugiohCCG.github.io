namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(StackDebugView))]
public class Stack : ICollection, IEnumerable, ICloneable
{
	public class StackDebugView
	{

	}

	private class StackEnumerator : IEnumerator, ICloneable
	{
		private Stack _stack; //Field offset: 0x10
		private int _index; //Field offset: 0x18
		private int _version; //Field offset: 0x1C
		private object _currentElement; //Field offset: 0x20

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 8)]
			 get { } //Length: 173
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal StackEnumerator(Stack stack) { }

		[CallerCount(Count = 113)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override object Clone() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		public override void Reset() { }

	}

	private Object[] _array; //Field offset: 0x10
	private int _size; //Field offset: 0x18
	private int _version; //Field offset: 0x1C
	private object _syncRoot; //Field offset: 0x20

	public override int Count
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override bool IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override object SyncRoot
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 104
	}

	[CalledBy(Type = typeof(SecurityParser), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList), typeof(bool)}, ReturnType = typeof(ProviderData))]
	[CalledBy(Type = typeof(SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Schema.ParticleContentValidator", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlNameTable", "System.Xml.Schema.ValidationEventHandler"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlNameTable", "System.Xml.Schema.ValidationEventHandler", "System.Xml.Schema.XmlSchema", "System.Xml.Schema.XmlSchemaCompilationSettings"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XsdBuilder", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlReader", "System.Xml.XmlNamespaceManager", "System.Xml.Schema.XmlSchema", "System.Xml.XmlNameTable", "System.Xml.Schema.SchemaNames", "System.Xml.Schema.ValidationEventHandler"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "get_LogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.CorrelationManager", Member = "GetLogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.TraceEventCache", Member = "get_LogicalOperationStack", ReturnType = typeof(Stack))]
	[CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.TraceEventCache"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngineInternal.GenericStack", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Stack() { }

	[CalledBy(Type = "System.Data.XmlDataLoader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataSet", typeof(bool), "System.Xml.XmlElement", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XmlDataLoader", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", typeof(bool), "System.Xml.XmlElement", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Stack(int initialCapacity) { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public override object Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	public override void CopyTo(Array array, int index) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override object get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public override IEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public override object Peek() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public override object Pop() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public override void Push(object obj) { }

}

