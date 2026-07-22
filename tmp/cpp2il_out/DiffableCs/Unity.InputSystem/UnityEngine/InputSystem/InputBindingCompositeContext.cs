namespace UnityEngine.InputSystem;

public struct InputBindingCompositeContext
{
	[CompilerGenerated]
	private sealed class <get_controls>d__2 : IEnumerable<PartBinding>, IEnumerable, IEnumerator<PartBinding>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PartBinding <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public InputBindingCompositeContext <>4__this; //Field offset: 0x30
		public InputBindingCompositeContext <>3__<>4__this; //Field offset: 0x40
		private int <totalBindingCount>5__2; //Field offset: 0x50
		private int <bindingIndex>5__3; //Field offset: 0x54
		private BindingState <bindingState>5__4; //Field offset: 0x58
		private int <controlStartIndex>5__5; //Field offset: 0x78
		private int <i>5__6; //Field offset: 0x7C

		private override PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public <get_controls>d__2(int <>1__state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionState), Member = "GetBindingState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(BindingState&))]
		[Calls(Type = typeof(BindingState), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		private override bool MoveNext() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override IEnumerator<PartBinding> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.GetEnumerator() { }

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		private override PartBinding System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBindingCompositeContext.PartBinding>.get_Current() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
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

	private struct DefaultComparer : IComparer<TValue>
	{

		[CalledBy(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TComparer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Boolean*), typeof(Int32&), "TComparer"}, ReturnType = "TValue")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override int Compare(TValue x, TValue y) { }

	}

	internal struct PartBinding
	{
		[CompilerGenerated]
		private int <part>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private InputControl <control>k__BackingField; //Field offset: 0x8

		public InputControl control
		{
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 5
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 13
		}

		public int part
		{
			[CallerCount(Count = 173)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			 get { } //Length: 3
			[CallerCount(Count = 11)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public InputControl get_control() { }

		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		public int get_part() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_control(InputControl value) { }

		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		public void set_part(int value) { }

	}

	internal InputActionState m_State; //Field offset: 0x0
	internal int m_BindingIndex; //Field offset: 0x8

	public IEnumerable<PartBinding> controls
	{
		[CalledBy(Type = typeof(OneModifierComposite), Member = "DetermineValueTypeAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(int), typeof(Type&), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[IteratorStateMachine(typeof(<get_controls>d__2))]
		 get { } //Length: 115
	}

	[CalledBy(Type = typeof(OneModifierComposite), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionState), Member = "EvaluateCompositePartMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	public float EvaluateMagnitude(int partNumber) { }

	[CalledBy(Type = typeof(OneModifierComposite), Member = "DetermineValueTypeAndSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(int), typeof(Type&), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[IteratorStateMachine(typeof(<get_controls>d__2))]
	public IEnumerable<PartBinding> get_controls() { }

	[CalledBy(Type = typeof(ButtonWithOneModifier), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ButtonWithOneModifier), Member = "ModifierIsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ButtonWithTwoModifiers), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ButtonWithTwoModifiers), Member = "ModifiersArePressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OneModifierComposite), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(OneModifierComposite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OneModifierComposite), Member = "ModifierIsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "ModifiersArePressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(InputActionState), Member = "GetCompositePartPressTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 1)]
	public double GetPressTime(int partNumber) { }

	[CalledBy(Type = typeof(AxisComposite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ButtonWithOneModifier), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ButtonWithTwoModifiers), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Vector2Composite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Vector3Composite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TComparer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Boolean*), typeof(Int32&), "TComparer"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TValue ReadValue(int partNumber) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	[DeduplicatedMethod]
	public TValue ReadValue(int partNumber, out InputControl sourceControl) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public TValue ReadValue(int partNumber, TComparer comparer = null) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	[DeduplicatedMethod]
	public TValue ReadValue(int partNumber, out InputControl sourceControl, TComparer comparer = null) { }

	[CalledBy(Type = typeof(OneModifierComposite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Void*), typeof(int)}, ReturnType = typeof(bool))]
	public void ReadValue(int partNumber, Void* buffer, int bufferSize) { }

	[CalledBy(Type = typeof(ButtonWithOneModifier), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ButtonWithOneModifier), Member = "ModifierIsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ButtonWithTwoModifiers), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ButtonWithTwoModifiers), Member = "ModifiersArePressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OneModifierComposite), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(OneModifierComposite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OneModifierComposite), Member = "ModifierIsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OneModifierComposite), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "ModifiersArePressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Vector2Composite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(Vector3Composite), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TComparer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Boolean*), typeof(Int32&), "TComparer"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	public bool ReadValueAsButton(int partNumber) { }

	[CalledBy(Type = typeof(OneModifierComposite), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TwoModifiersComposite), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingCompositeContext&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionState), Member = "ReadCompositePartValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public object ReadValueAsObject(int partNumber) { }

}

