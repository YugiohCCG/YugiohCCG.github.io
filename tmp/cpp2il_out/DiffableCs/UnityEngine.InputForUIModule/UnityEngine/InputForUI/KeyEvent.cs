namespace UnityEngine.InputForUI;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct KeyEvent : IEventProperties
{
	internal struct ButtonsState
	{
		[CompilerGenerated]
		[UnsafeValueType]
		internal struct <buttons>e__FixedBuffer
		{
			public byte FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		private sealed class <GetAllPressed>d__8 : IEnumerable<KeyCode>, IEnumerable, IEnumerator<KeyCode>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private KeyCode <>2__current; //Field offset: 0x14
			private int <>l__initialThreadId; //Field offset: 0x18
			public ButtonsState <>4__this; //Field offset: 0x1C
			public ButtonsState <>3__<>4__this; //Field offset: 0x44
			private uint <index>5__1; //Field offset: 0x6C

			private override KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.Current
			{
				[CallerCount(Count = 2)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				private get { } //Length: 4
			}

			private override object System.Collections.IEnumerator.Current
			{
				[CallerCount(Count = 0)]
				[DebuggerHidden]
				private get { } //Length: 67
			}

			[CallerCount(Count = 10)]
			[CallsDeduplicatedMethods(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			public <GetAllPressed>d__8(int <>1__state) { }

			[CallerCount(Count = 0)]
			private override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override IEnumerator<KeyCode> System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>.GetEnumerator() { }

			[CallerCount(Count = 2)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.get_Current() { }

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[CallerCount(Count = 0)]
			[DebuggerHidden]
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

		[FixedBuffer(typeof(byte), 40)]
		private <buttons>e__FixedBuffer buttons; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private void ClearUnchecked(uint index) { }

		[CalledBy(Type = typeof(ButtonsState), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[IteratorStateMachine(typeof(<GetAllPressed>d__8))]
		public IEnumerable<KeyCode> GetAllPressed() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private bool GetUnchecked(uint index) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool IsPressed(KeyCode keyCode) { }

		[CallerCount(Count = 0)]
		public void Reset() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public void SetPressed(KeyCode keyCode, bool pressed) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private void SetUnchecked(uint index) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal static bool ShouldBeProcessed(KeyCode keyCode) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ButtonsState), Member = "GetAllPressed", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.KeyCode>))]
		[Calls(Type = typeof(string), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(string))]
		public virtual string ToString() { }

	}

	internal enum Type
	{
		KeyPressed = 1,
		KeyRepeated = 2,
		KeyReleased = 3,
		State = 4,
	}

	public Type type; //Field offset: 0x0
	public KeyCode keyCode; //Field offset: 0x4
	public ButtonsState buttonsState; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private uint <playerId>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x40

	public override EventModifiers eventModifiers
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public override EventSource eventSource
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public uint playerId
	{
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public DiscreteTime timestamp
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override EventModifiers get_eventModifiers() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public override EventSource get_eventSource() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_eventModifiers(EventModifiers value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_eventSource(EventSource value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_playerId(uint value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_timestamp(DiscreteTime value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual string ToString() { }

}

