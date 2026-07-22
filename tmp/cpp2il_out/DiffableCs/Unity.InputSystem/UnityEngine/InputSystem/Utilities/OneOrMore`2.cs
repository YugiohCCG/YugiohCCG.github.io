namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
internal struct OneOrMore : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue>
{
	private class Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		internal int m_Index; //Field offset: 0x0
		internal OneOrMore<TValue, TList> m_List; //Field offset: 0x0

		public override TValue Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(OneOrMore`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[DeduplicatedMethod]
			 get { } //Length: 31
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(OneOrMore`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
			[DeduplicatedMethod]
			private get { } //Length: 46
		}

		[CallerCount(Count = 57)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public Enumerator() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OneOrMore`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[DeduplicatedMethod]
		public override TValue get_Current() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OneOrMore`2), Member = "get_Count", ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public override bool MoveNext() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public override void Reset() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OneOrMore`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[DeduplicatedMethod]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private readonly bool m_IsSingle; //Field offset: 0x0
	private readonly TValue m_Single; //Field offset: 0x0
	private readonly TList m_Multiple; //Field offset: 0x0

	public override int Count
	{
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 57
	}

	public override TValue Item
	{
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
		[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 172
	}

	[CalledBy(Type = typeof(InputControlScheme), Member = "FindControlSchemeForDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSchemes"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), "TSchemes"}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public OneOrMore`2(TValue single) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public OneOrMore`2(TList multiple) { }

	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override TValue get_Item(int index) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override IEnumerator<TValue> GetEnumerator() { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static OneOrMore<TValue, TList> op_Implicit(TValue single) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static OneOrMore<TValue, TList> op_Implicit(TList multiple) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

