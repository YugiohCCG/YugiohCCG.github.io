namespace System.Xml.XPath;

[DebuggerDisplay("Position={CurrentPosition}, Current={debuggerDisplayProxy}")]
public abstract class XPathNodeIterator : ICloneable, IEnumerable
{
	private class Enumerator : IEnumerator
	{
		private XPathNodeIterator original; //Field offset: 0x10
		private XPathNodeIterator current; //Field offset: 0x18
		private bool iterationStarted; //Field offset: 0x20

		public override object Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 17)]
			 get { } //Length: 421
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		public Enumerator(XPathNodeIterator original) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 17)]
		public override object get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		public override void Reset() { }

	}

	internal int count; //Field offset: 0x10

	public override int Count
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 107
	}

	public abstract XPathNavigator Current
	{
		 get { } //Length: 0
	}

	public abstract int CurrentPosition
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 57)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XPathNodeIterator() { }

	public abstract XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_Count() { }

	public abstract XPathNavigator get_Current() { }

	public abstract int get_CurrentPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public override IEnumerator GetEnumerator() { }

	public abstract bool MoveNext() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override object System.ICloneable.Clone() { }

}

