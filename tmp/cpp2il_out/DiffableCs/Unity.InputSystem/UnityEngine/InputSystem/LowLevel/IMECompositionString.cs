namespace UnityEngine.InputSystem.LowLevel;

[DefaultMember("Item")]
public struct IMECompositionString : IEnumerable<Char>, IEnumerable
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <buffer>e__FixedBuffer
	{
		public char FixedElementField; //Field offset: 0x0

	}

	public struct Enumerator : IEnumerator<Char>, IEnumerator, IDisposable
	{
		private IMECompositionString m_CompositionString; //Field offset: 0x0
		private char m_CurrentCharacter; //Field offset: 0x84
		private int m_CurrentIndex; //Field offset: 0x88

		public override char Current
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			private get { } //Length: 38
		}

		[CallerCount(Count = 0)]
		public Enumerator(IMECompositionString compositionString) { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public override char get_Current() { }

		[CallerCount(Count = 0)]
		public override bool MoveNext() { }

		[CallerCount(Count = 0)]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private int size; //Field offset: 0x0
	[FixedBuffer(typeof(char), 64)]
	private <buffer>e__FixedBuffer buffer; //Field offset: 0x4

	public int Count
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public char Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 107
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	public IMECompositionString(string characters) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public char get_Item(int index) { }

	[CalledBy(Type = typeof(IMECompositionString), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 1)]
	public override IEnumerator<Char> GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IMECompositionString), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Char>))]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

