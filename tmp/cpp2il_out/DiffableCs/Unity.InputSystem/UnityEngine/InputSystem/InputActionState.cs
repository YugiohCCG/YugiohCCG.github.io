namespace UnityEngine.InputSystem;

internal class InputActionState : IInputStateChangeMonitor, ICloneable, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static TypedRestore<GlobalState> <>9__143_0; //Field offset: 0x8
		public static Action <>9__143_1; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void <SaveAndResetState>b__143_0(ref GlobalState state) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputActionState), Member = "ResetGlobals", ReturnType = typeof(void))]
		internal void <SaveAndResetState>b__143_1() { }

	}

	internal struct ActionMapIndices
	{
		public int actionStartIndex; //Field offset: 0x0
		public int actionCount; //Field offset: 0x4
		public int controlStartIndex; //Field offset: 0x8
		public int controlCount; //Field offset: 0xC
		public int bindingStartIndex; //Field offset: 0x10
		public int bindingCount; //Field offset: 0x14
		public int interactionStartIndex; //Field offset: 0x18
		public int interactionCount; //Field offset: 0x1C
		public int processorStartIndex; //Field offset: 0x20
		public int processorCount; //Field offset: 0x24
		public int compositeStartIndex; //Field offset: 0x28
		public int compositeCount; //Field offset: 0x2C

	}

	public struct BindingState
	{
		[Flags]
		internal enum Flags
		{
			ChainsWithNext = 1,
			EndOfChain = 2,
			Composite = 4,
			PartOfComposite = 8,
			InitialStateCheckPending = 16,
			WantsInitialStateCheck = 32,
		}

		private byte m_ControlCount; //Field offset: 0x0
		private byte m_InteractionCount; //Field offset: 0x1
		private byte m_ProcessorCount; //Field offset: 0x2
		private byte m_MapIndex; //Field offset: 0x3
		private byte m_Flags; //Field offset: 0x4
		private byte m_PartIndex; //Field offset: 0x5
		private ushort m_ActionIndex; //Field offset: 0x6
		private ushort m_CompositeOrCompositeBindingIndex; //Field offset: 0x8
		private ushort m_ProcessorStartIndex; //Field offset: 0xA
		private ushort m_InteractionStartIndex; //Field offset: 0xC
		private ushort m_ControlStartIndex; //Field offset: 0xE
		private double m_PressTime; //Field offset: 0x10
		private int m_TriggerEventIdForComposite; //Field offset: 0x18
		private int __padding; //Field offset: 0x1C

		public int actionIndex
		{
			[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndexForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TrackedPoseDriver), Member = "HasResolvedControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 4)]
			 get { } //Length: 22
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 167
		}

		public bool chainsWithNext
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		public int compositeOrCompositeBindingIndex
		{
			[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = "TValue")]
			[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
			[CallerCount(Count = 5)]
			 get { } //Length: 22
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 167
		}

		public int controlCount
		{
			[CallerCount(Count = 89)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 148
		}

		public int controlStartIndex
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 5
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 151
		}

		public Flags flags
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public bool initialStateCheckPending
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		public int interactionCount
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 149
		}

		public int interactionStartIndex
		{
			[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			 get { } //Length: 22
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 167
		}

		public bool isComposite
		{
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(TrackedPoseDriver), Member = "HasResolvedControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
			[CallerCount(Count = 2)]
			 get { } //Length: 10
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 set { } //Length: 33
		}

		public bool isEndOfChain
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 9
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		public bool isPartOfChain
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 18
		}

		public bool isPartOfComposite
		{
			[CalledBy(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = "TValue")]
			[CalledBy(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TComparer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Boolean*), typeof(Int32&), "TComparer"}, ReturnType = "TValue")]
			[CalledBy(Type = "UnityEngine.InputSystem.InputBindingCompositeContext+<get_controls>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
			[CallerCount(Count = 5)]
			 get { } //Length: 10
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 set { } //Length: 33
		}

		public int mapIndex
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 5
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 149
		}

		public int partIndex
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 set { } //Length: 6
		}

		public double pressTime
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public int processorCount
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 149
		}

		public int processorStartIndex
		{
			[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputActionState), Member = "ApplyProcessors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TValue", "UnityEngine.InputSystem.InputControl`1<TValue>"}, ReturnType = "TValue")]
			[CallerCount(Count = 3)]
			 get { } //Length: 22
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
			[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 167
		}

		public int triggerEventIdForComposite
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public bool wantsInitialStateCheck
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 set { } //Length: 33
		}

		[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndexForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "HasResolvedControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		public int get_actionIndex() { }

		[CallerCount(Count = 0)]
		public bool get_chainsWithNext() { }

		[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[CallerCount(Count = 5)]
		public int get_compositeOrCompositeBindingIndex() { }

		[CallerCount(Count = 89)]
		[DeduplicatedMethod]
		public int get_controlCount() { }

		[CallerCount(Count = 0)]
		public int get_controlStartIndex() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Flags get_flags() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_initialStateCheckPending() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int get_interactionCount() { }

		[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		public int get_interactionStartIndex() { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TrackedPoseDriver), Member = "HasResolvedControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		public bool get_isComposite() { }

		[CallerCount(Count = 0)]
		public bool get_isEndOfChain() { }

		[CallerCount(Count = 0)]
		public bool get_isPartOfChain() { }

		[CalledBy(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TComparer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Boolean*), typeof(Int32&), "TComparer"}, ReturnType = "TValue")]
		[CalledBy(Type = "UnityEngine.InputSystem.InputBindingCompositeContext+<get_controls>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ActionEventPtr), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[CallerCount(Count = 5)]
		public bool get_isPartOfComposite() { }

		[CallerCount(Count = 0)]
		public int get_mapIndex() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int get_partIndex() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public double get_pressTime() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int get_processorCount() { }

		[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionState), Member = "ApplyProcessors", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TValue", "UnityEngine.InputSystem.InputControl`1<TValue>"}, ReturnType = "TValue")]
		[CallerCount(Count = 3)]
		public int get_processorStartIndex() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public int get_triggerEventIdForComposite() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_wantsInitialStateCheck() { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_actionIndex(int value) { }

		[CallerCount(Count = 0)]
		public void set_chainsWithNext(bool value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_compositeOrCompositeBindingIndex(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_controlCount(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_controlStartIndex(int value) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public void set_flags(Flags value) { }

		[CallerCount(Count = 0)]
		public void set_initialStateCheckPending(bool value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_interactionCount(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_interactionStartIndex(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public void set_isComposite(bool value) { }

		[CallerCount(Count = 0)]
		public void set_isEndOfChain(bool value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public void set_isPartOfComposite(bool value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_mapIndex(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public void set_partIndex(int value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_pressTime(double value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(byte), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_processorCount(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_processorStartIndex(int value) { }

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		public void set_triggerEventIdForComposite(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public void set_wantsInitialStateCheck(bool value) { }

	}

	public struct GlobalState
	{
		internal InlinedArray<GCHandle> globalList; //Field offset: 0x0
		internal CallbackArray<Action`2<Object, InputActionChange>> onActionChange; //Field offset: 0x18
		internal CallbackArray<Action`1<Object>> onActionControlsChanged; //Field offset: 0x68

	}

	public struct InteractionState
	{
		[Flags]
		private enum Flags
		{
			TimerRunning = 1,
		}

		private ushort m_TriggerControlIndex; //Field offset: 0x0
		private byte m_Phase; //Field offset: 0x2
		private byte m_Flags; //Field offset: 0x3
		private float m_TimerDuration; //Field offset: 0x4
		private double m_StartTime; //Field offset: 0x8
		private double m_TimerStartTime; //Field offset: 0x10
		private double m_PerformedTime; //Field offset: 0x18
		private float m_TotalTimeoutCompletionTimeDone; //Field offset: 0x20
		private float m_TotalTimeoutCompletionTimeRemaining; //Field offset: 0x24
		private long m_TimerMonitorIndex; //Field offset: 0x28

		public bool isTimerRunning
		{
			[CalledBy(Type = typeof(InputAction), Member = "GetTimeoutCompletionPercentage", ReturnType = typeof(float))]
			[CallerCount(Count = 1)]
			 get { } //Length: 7
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		public double performedTime
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			 set { } //Length: 6
		}

		public InputActionPhase phase
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public double startTime
		{
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public float timerDuration
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 14)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public long timerMonitorIndex
		{
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 5
		}

		public double timerStartTime
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public float totalTimeoutCompletionDone
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public float totalTimeoutCompletionTimeRemaining
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public int triggerControlIndex
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 20
			[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 117
		}

		[CalledBy(Type = typeof(InputAction), Member = "GetTimeoutCompletionPercentage", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		public bool get_isTimerRunning() { }

		[CallerCount(Count = 0)]
		public double get_performedTime() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public InputActionPhase get_phase() { }

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		public double get_startTime() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_timerDuration() { }

		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		public long get_timerMonitorIndex() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public double get_timerStartTime() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_totalTimeoutCompletionDone() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_totalTimeoutCompletionTimeRemaining() { }

		[CallerCount(Count = 0)]
		public int get_triggerControlIndex() { }

		[CallerCount(Count = 0)]
		public void set_isTimerRunning(bool value) { }

		[CallerCount(Count = 0)]
		public void set_performedTime(double value) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public void set_phase(InputActionPhase value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_startTime(double value) { }

		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		public void set_timerDuration(float value) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public void set_timerMonitorIndex(long value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_timerStartTime(double value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_totalTimeoutCompletionDone(float value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_totalTimeoutCompletionTimeRemaining(float value) { }

		[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_triggerControlIndex(int value) { }

	}

	internal struct TriggerState
	{
		[Flags]
		internal enum Flags
		{
			HaveMagnitude = 1,
			PassThrough = 2,
			MayNeedConflictResolution = 4,
			HasMultipleConcurrentActuations = 8,
			InProcessing = 16,
			Button = 32,
			Pressed = 64,
		}

		public const int kMaxNumMaps = 255; //Field offset: 0x0
		public const int kMaxNumControls = 65535; //Field offset: 0x0
		public const int kMaxNumBindings = 65535; //Field offset: 0x0
		private byte m_Phase; //Field offset: 0x0
		private byte m_Flags; //Field offset: 0x1
		private byte m_MapIndex; //Field offset: 0x2
		private ushort m_ControlIndex; //Field offset: 0x4
		private double m_Time; //Field offset: 0x8
		private double m_StartTime; //Field offset: 0x10
		private ushort m_BindingIndex; //Field offset: 0x18
		private ushort m_InteractionIndex; //Field offset: 0x1A
		private float m_Magnitude; //Field offset: 0x1C
		private uint m_LastPerformedInUpdate; //Field offset: 0x20
		private uint m_LastCanceledInUpdate; //Field offset: 0x24
		private uint m_PressedInUpdate; //Field offset: 0x28
		private uint m_ReleasedInUpdate; //Field offset: 0x2C
		private uint m_LastCompletedInUpdate; //Field offset: 0x30
		internal int framePerformed; //Field offset: 0x34
		internal int framePressed; //Field offset: 0x38
		internal int frameReleased; //Field offset: 0x3C
		internal int frameCompleted; //Field offset: 0x40

		public int bindingIndex
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = typeof(InputActionState), Member = "IsConflictingInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 3)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 103
		}

		public int controlIndex
		{
			[CalledBy(Type = typeof(CallbackContext), Member = "get_controlIndex", ReturnType = typeof(int))]
			[CalledBy(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
			[CalledBy(Type = typeof(CallbackContext), Member = "get_valueType", ReturnType = typeof(Type))]
			[CalledBy(Type = typeof(CallbackContext), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
			[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(CallbackContext), Member = "ReadValueAsButton", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(CallbackContext), Member = "ReadValueAsObject", ReturnType = typeof(object))]
			[CalledBy(Type = typeof(CallbackContext), Member = "ToString", ReturnType = typeof(string))]
			[CalledBy(Type = typeof(InputAction), Member = "get_activeControl", ReturnType = typeof(InputControl))]
			[CalledBy(Type = typeof(InputAction), Member = "get_activeValueType", ReturnType = typeof(Type))]
			[CalledBy(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
			[CalledBy(Type = typeof(InputAction), Member = "ReadValueAsObject", ReturnType = typeof(object))]
			[CalledBy(Type = typeof(InputInteractionContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
			[CalledBy(Type = typeof(InputInteractionContext), Member = "get_controlIndex", ReturnType = typeof(int))]
			[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 15)]
			 get { } //Length: 22
			[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputActionState), Member = "IsConflictingInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 7)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 119
		}

		public Flags flags
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public bool hasMultipleConcurrentActuations
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		public bool haveMagnitude
		{
			[CalledBy(Type = typeof(InputAction), Member = "GetControlMagnitude", ReturnType = typeof(float))]
			[CallerCount(Count = 1)]
			 get { } //Length: 7
		}

		public bool inProcessing
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		public int interactionIndex
		{
			[CalledBy(Type = typeof(CallbackContext), Member = "get_interactionIndex", ReturnType = typeof(int))]
			[CalledBy(Type = typeof(CallbackContext), Member = "get_interaction", ReturnType = typeof(IInputInteraction))]
			[CalledBy(Type = typeof(CallbackContext), Member = "ToString", ReturnType = typeof(string))]
			[CalledBy(Type = typeof(InputAction), Member = "GetTimeoutCompletionPercentage", ReturnType = typeof(float))]
			[CalledBy(Type = typeof(InputInteractionContext), Member = "get_interactionIndex", ReturnType = typeof(int))]
			[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
			[CallerCount(Count = 6)]
			 get { } //Length: 22
			[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputActionState), Member = "IsConflictingInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 7)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 119
		}

		public bool isButton
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 set { } //Length: 33
		}

		public bool isCanceled
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 7
		}

		public bool isDisabled
		{
			[CallerCount(Count = 18)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public bool isPassThrough
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 set { } //Length: 33
		}

		public bool isPerformed
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 7
		}

		public bool isPressed
		{
			[CalledBy(Type = typeof(InputAction), Member = "IsPressed", ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CallerCount(Count = 0)]
			 set { } //Length: 33
		}

		public bool isStarted
		{
			[CallerCount(Count = 20)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public bool isWaiting
		{
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		public uint lastCanceledInUpdate
		{
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public uint lastCompletedInUpdate
		{
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public uint lastPerformedInUpdate
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public float magnitude
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			 set { } //Length: 10
		}

		public int mapIndex
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 4)]
			 set { } //Length: 102
		}

		public bool mayNeedConflictResolution
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 8
			[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			 set { } //Length: 33
		}

		public InputActionPhase phase
		{
			[CallerCount(Count = 89)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 set { } //Length: 3
		}

		public uint pressedInUpdate
		{
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public uint releasedInUpdate
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 4
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 4
		}

		public double startTime
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		public double time
		{
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 6
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 set { } //Length: 6
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int get_bindingIndex() { }

		[CalledBy(Type = typeof(CallbackContext), Member = "get_controlIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(CallbackContext), Member = "get_control", ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(CallbackContext), Member = "get_valueType", ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(CallbackContext), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CallbackContext), Member = "ReadValueAsButton", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(CallbackContext), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(CallbackContext), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputAction), Member = "get_activeControl", ReturnType = typeof(InputControl))]
		[CalledBy(Type = typeof(InputAction), Member = "get_activeValueType", ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(InputAction), Member = "ReadValueAsObject", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(InputInteractionContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
		[CalledBy(Type = typeof(InputInteractionContext), Member = "get_controlIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		public int get_controlIndex() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Flags get_flags() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_hasMultipleConcurrentActuations() { }

		[CalledBy(Type = typeof(InputAction), Member = "GetControlMagnitude", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		public bool get_haveMagnitude() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_inProcessing() { }

		[CalledBy(Type = typeof(CallbackContext), Member = "get_interactionIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(CallbackContext), Member = "get_interaction", ReturnType = typeof(IInputInteraction))]
		[CalledBy(Type = typeof(CallbackContext), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(InputAction), Member = "GetTimeoutCompletionPercentage", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(InputInteractionContext), Member = "get_interactionIndex", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		public int get_interactionIndex() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_isButton() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_isCanceled() { }

		[CallerCount(Count = 18)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_isDisabled() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_isPassThrough() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_isPerformed() { }

		[CalledBy(Type = typeof(InputAction), Member = "IsPressed", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		public bool get_isPressed() { }

		[CallerCount(Count = 20)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_isStarted() { }

		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_isWaiting() { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		public uint get_lastCanceledInUpdate() { }

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		public uint get_lastCompletedInUpdate() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public uint get_lastPerformedInUpdate() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public float get_magnitude() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public int get_mapIndex() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool get_mayNeedConflictResolution() { }

		[CallerCount(Count = 89)]
		[DeduplicatedMethod]
		public InputActionPhase get_phase() { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public uint get_pressedInUpdate() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public uint get_releasedInUpdate() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public double get_startTime() { }

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		public double get_time() { }

		[CalledBy(Type = typeof(InputActionState), Member = "IsConflictingInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_bindingIndex(int value) { }

		[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "IsConflictingInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_controlIndex(int value) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public void set_flags(Flags value) { }

		[CallerCount(Count = 0)]
		public void set_hasMultipleConcurrentActuations(bool value) { }

		[CallerCount(Count = 0)]
		public void set_inProcessing(bool value) { }

		[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "IsConflictingInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_interactionIndex(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public void set_isButton(bool value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public void set_isPassThrough(bool value) { }

		[CallerCount(Count = 0)]
		public void set_isPressed(bool value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_lastCanceledInUpdate(uint value) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public void set_lastCompletedInUpdate(uint value) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public void set_lastPerformedInUpdate(uint value) { }

		[CallerCount(Count = 0)]
		public void set_magnitude(float value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public void set_mapIndex(int value) { }

		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public void set_mayNeedConflictResolution(bool value) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		public void set_phase(InputActionPhase value) { }

		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		public void set_pressedInUpdate(uint value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_releasedInUpdate(uint value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_startTime(double value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void set_time(double value) { }

	}

	internal struct UnmanagedMemory : IDisposable
	{
		public Void* basePtr; //Field offset: 0x0
		public int mapCount; //Field offset: 0x8
		public int actionCount; //Field offset: 0xC
		public int interactionCount; //Field offset: 0x10
		public int bindingCount; //Field offset: 0x14
		public int controlCount; //Field offset: 0x18
		public int compositeCount; //Field offset: 0x1C
		public TriggerState* actionStates; //Field offset: 0x20
		public BindingState* bindingStates; //Field offset: 0x28
		public InteractionState* interactionStates; //Field offset: 0x30
		public Single* controlMagnitudes; //Field offset: 0x38
		public Single* compositeMagnitudes; //Field offset: 0x40
		public Int32* enabledControls; //Field offset: 0x48
		public UInt16* actionBindingIndicesAndCounts; //Field offset: 0x50
		public UInt16* actionBindingIndices; //Field offset: 0x58
		public Int32* controlIndexToBindingIndex; //Field offset: 0x60
		public UInt16* controlGroupingAndComplexity; //Field offset: 0x68
		public bool controlGroupingInitialized; //Field offset: 0x70
		public ActionMapIndices* mapIndices; //Field offset: 0x78

		public bool isAllocated
		{
			[CallerCount(Count = 19)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			 get { } //Length: 8
		}

		public int sizeInBytes
		{
			[CallerCount(Count = 0)]
			 get { } //Length: 65
		}

		[CalledBy(Type = typeof(UnmanagedMemory), Member = "Clone", ReturnType = typeof(UnmanagedMemory))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnsafeUtility), Member = "Malloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(Allocator)}, ReturnType = typeof(Void*))]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemClear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount) { }

		[CallerCount(Count = 0)]
		private static Byte* AllocFromBlob(ref Byte* top, int size) { }

		[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "Clone", ReturnType = typeof(InputActionState))]
		[CalledBy(Type = typeof(InputActionState), Member = "System.ICloneable.Clone", ReturnType = typeof(object))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnmanagedMemory), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnmanagedMemory), Member = "CopyDataFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory)}, ReturnType = typeof(void))]
		public UnmanagedMemory Clone() { }

		[CalledBy(Type = typeof(UnmanagedMemory), Member = "Clone", ReturnType = typeof(UnmanagedMemory))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		public void CopyDataFrom(UnmanagedMemory memory) { }

		[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
		public override void Dispose() { }

		[CallerCount(Count = 19)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		public bool get_isAllocated() { }

		[CallerCount(Count = 0)]
		public int get_sizeInBytes() { }

	}

	public const int kInvalidIndex = -1; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputInitialActionStateCheckMarker; //Field offset: 0x0
	private static readonly ProfilerMarker k_InputActionResolveConflictMarker; //Field offset: 0x8
	private static readonly ProfilerMarker k_InputActionCallbackMarker; //Field offset: 0x10
	private static readonly ProfilerMarker k_InputOnActionChangeMarker; //Field offset: 0x18
	private static readonly ProfilerMarker k_InputOnDeviceChangeMarker; //Field offset: 0x20
	internal static GlobalState s_GlobalState; //Field offset: 0x28
	public InputActionMap[] maps; //Field offset: 0x10
	public InputControl[] controls; //Field offset: 0x18
	public IInputInteraction[] interactions; //Field offset: 0x20
	public InputProcessor[] processors; //Field offset: 0x28
	public InputBindingComposite[] composites; //Field offset: 0x30
	public int totalProcessorCount; //Field offset: 0x38
	public UnmanagedMemory memory; //Field offset: 0x40
	private bool m_OnBeforeUpdateHooked; //Field offset: 0xC0
	private bool m_OnAfterUpdateHooked; //Field offset: 0xC1
	private bool m_InProcessControlStateChange; //Field offset: 0xC2
	private bool m_Suppressed; //Field offset: 0xC3
	private InputEventPtr m_CurrentlyProcessingThisEvent; //Field offset: 0xC8
	private Action m_OnBeforeUpdateDelegate; //Field offset: 0xD0
	private Action m_OnAfterUpdateDelegate; //Field offset: 0xD8

	public TriggerState* actionStates
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public BindingState* bindingStates
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public UInt16* controlGroupingAndComplexity
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Int32* controlIndexToBindingIndex
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Single* controlMagnitudes
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public UInt32* enabledControls
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public InteractionState* interactionStates
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool isProcessingControlStateChange
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public bool IsSuppressed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public ActionMapIndices* mapIndices
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public int totalActionCount
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int totalBindingCount
	{
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int totalCompositeCount
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int totalControlCount
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int totalInteractionCount
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int totalMapCount
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	private static InputActionState() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public InputActionState() { }

	[CalledBy(Type = typeof(InputActionState), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingResolver)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Runtime.InteropServices.GCHandle>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GCHandle), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void AddToGlobalList() { }

	[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BindingState), Member = "get_processorStartIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	internal TValue ApplyProcessors(int bindingIndex, TValue value, InputControl<TValue> controlOfType = null) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfActionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TriggerState*), typeof(InputActionPhase), typeof(TriggerState&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CallbackContext), Member = "get_action", ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<CallbackContext>>&), typeof(CallbackContext), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void CallActionListeners(int actionIndex, InputActionMap actionMap, InputActionPhase phase, ref CallbackArray<Action`1<CallbackContext>>& listeners, string callbackName) { }

	[CalledBy(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionMap), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlPath), Member = "TryFindControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(string), typeof(int)}, ReturnType = typeof(InputControl))]
	[CallsUnknownMethods(Count = 2)]
	private bool CanUseDevice(InputDevice device) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ProcessDefaultInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfActionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TriggerState*), typeof(InputActionPhase), typeof(TriggerState&), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool ChangePhaseOfAction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformedOrCanceled = 1) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputEventPtr), Member = "set_handled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "CallActionListeners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionMap), typeof(InputActionPhase), typeof(CallbackArray`1<Action`1<CallbackContext>>&), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void ChangePhaseOfActionInternal(int actionIndex, TriggerState* actionState, InputActionPhase newPhase, ref TriggerState trigger, bool isDisablingAction = false) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ResetInteractionStateAndCancelIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(InputActionPhase)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputInteractionContext), Member = "Started", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputInteractionContext), Member = "Performed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputInteractionContext), Member = "PerformedAndStayStarted", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputInteractionContext), Member = "PerformedAndStayPerformed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputInteractionContext), Member = "Canceled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputInteractionContext), Member = "Waiting", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InputActionState), Member = "StopTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InteractionState), Member = "set_triggerControlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TriggerState), Member = "set_controlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_interactionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ResetInteractionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	internal void ChangePhaseOfInteraction(InputActionPhase newPhase, ref TriggerState trigger, InputActionPhase phaseAfterPerformed = 1, InputActionPhase phaseAfterCanceled = 1, bool processNextInteractionOnCancel = true) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "ComputeControlGroupingIfNecessary", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void ClaimDataFrom(InputBindingResolver resolver) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Copy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "TValue[]")]
	[Calls(Type = typeof(UnmanagedMemory), Member = "Clone", ReturnType = typeof(UnmanagedMemory))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public InputActionState Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TValue"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static void CompactGlobalList() { }

	[CalledBy(Type = typeof(InputActionState), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ClaimDataFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBindingResolver)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 2)]
	private void ComputeControlGroupingIfNecessary() { }

	[CalledBy(Type = typeof(DeferBindingResolutionWrapper), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionMap), Member = "ResolveBindingsIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal static void DeferredResolutionOfBindings() { }

	[CalledBy(Type = typeof(InputActionState), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ResetGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DestroyAllActionMapStates", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void Destroy(bool isFinalizing = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionState), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static void DestroyAllActionMapStates() { }

	[CalledBy(Type = typeof(InputSystem), Member = "DisableAllEnabledActions", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static void DisableAllActions() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void DisableAllActions(InputActionMap map) { }

	[CalledBy(Type = typeof(InputActionState), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DisableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DisableSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InputManager), Member = "RemoveStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DisableControls(int mapIndex, int controlStartIndex, int numControls) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DisableControls(InputActionMap map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void DisableControls(InputAction action) { }

	[CalledBy(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void DisableSingleAction(InputAction action) { }

	[CalledBy(Type = typeof(InputAction), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionAsset), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "DisposeInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputActionState), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public override void Dispose() { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionMap), Member = "Enable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "HookOnBeforeUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EnableAllActions(InputActionMap map) { }

	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "EnableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "EnableSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "AddStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(long), typeof(uint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void EnableControls(int mapIndex, int controlStartIndex, int numControls) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnableControls(InputAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnableControls(InputActionMap map) { }

	[CalledBy(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "HookOnBeforeUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void EnableSingleAction(InputAction action) { }

	[CalledBy(Type = typeof(InputBindingCompositeContext), Member = "EvaluateMagnitude", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber) { }

	[CalledBy(Type = typeof(InputAction), Member = "get_phase", ReturnType = typeof(InputActionPhase))]
	[CalledBy(Type = typeof(InputAction), Member = "get_inProgress", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputAction), Member = "get_enabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputAction), Member = "Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputAction), Member = "Disable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputAction), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputAction), Member = "get_currentState", ReturnType = typeof(TriggerState))]
	[CalledBy(Type = typeof(RebindingOperation), Member = "WithAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(RebindingOperation))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	public TriggerState FetchActionState(InputAction action) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "SetUpPerActionControlAndBindingArrays", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ActionMapIndices FetchMapIndices(InputActionMap map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnsafeUtility), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Allocator)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CalledBy(Type = typeof(InputSystem), Member = "ListEnabledActions", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputAction>))]
	[CalledBy(Type = typeof(InputSystem), Member = "ListEnabledActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.InputAction>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal static int FindAllEnabledActions(List<InputAction> result) { }

	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int FindControlIndexOnBinding(int bindingIndex, InputControl control) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void FinishBindingCompositeSetups() { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void FinishBindingResolution(bool hasEnabledActions, UnmanagedMemory oldMemory, InputControlList<InputControl> activeControls, bool isFullResolve) { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public TriggerState* get_actionStates() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public BindingState* get_bindingStates() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public UInt16* get_controlGroupingAndComplexity() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Int32* get_controlIndexToBindingIndex() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public Single* get_controlMagnitudes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UInt32* get_enabledControls() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public InteractionState* get_interactionStates() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isProcessingControlStateChange() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsSuppressed() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public ActionMapIndices* get_mapIndices() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public int get_totalActionCount() { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public int get_totalBindingCount() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public int get_totalCompositeCount() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_totalControlCount() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_totalInteractionCount() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public int get_totalMapCount() { }

	[CallerCount(Count = 0)]
	private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal InputActionMap GetActionMap(int bindingIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private object GetActionOrNoneString(ref TriggerState trigger) { }

	[CalledBy(Type = typeof(InputInteractionContext), Member = "get_action", ReturnType = typeof(InputAction))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal InputAction GetActionOrNull(ref TriggerState trigger) { }

	[CalledBy(Type = typeof(CallbackContext), Member = "get_action", ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(CallbackContext), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "get_action", ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(ActionEventPtr), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	internal InputAction GetActionOrNull(int bindingIndex) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionState), typeof(int), typeof(ParameterOverride[]&), typeof(Int32&), typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal InputBinding GetBinding(int bindingIndex) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingIndexForControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetBindingIndexInMap(int bindingIndex) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveToNextBinding", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterEnumerator", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBindingCompositeContext+<get_controls>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	internal BindingState GetBindingState(int bindingIndex) { }

	[CalledBy(Type = typeof(StateChangeMonitorsForDevice), Member = "SortMonitorsByIndex", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex) { }

	[CalledBy(Type = typeof(InputBindingCompositeContext), Member = "GetPressTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal double GetCompositePartPressTime(int bindingIndex, int partNumber) { }

	[CalledBy(Type = typeof(InputInteractionContext), Member = "get_control", ReturnType = typeof(InputControl))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal InputControl GetControl(ref TriggerState trigger) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private IInputInteraction GetInteractionOrNull(ref TriggerState trigger) { }

	[CalledBy(Type = typeof(CallbackContext), Member = "get_valueSizeInBytes", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal int GetValueSizeInBytes(int bindingIndex, int controlIndex) { }

	[CalledBy(Type = typeof(CallbackContext), Member = "get_valueType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(InputAction), Member = "get_activeValueType", ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal Type GetValueType(int bindingIndex, int controlIndex) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool HasEnabledActions() { }

	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "EnableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "EnableSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "add_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HookOnBeforeUpdate() { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "ComputeControlGroupingIfNecessary", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "AddToGlobalList", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void Initialize(InputBindingResolver resolver) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ResetActionStatesDrivenBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsActionBoundToControlFromDevice(InputDevice device, int actionIndex) { }

	[CalledBy(Type = typeof(InputActionState), Member = "OnBeforeInitialUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	private bool IsActiveControl(int bindingIndex, int controlIndex) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessDefaultInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputInteractionContext), Member = "ControlIsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsActuated(ref TriggerState trigger, float threshold = 0) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TriggerState), Member = "set_controlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_bindingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ResetInteractionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_interactionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool IsConflictingInput(ref TriggerState trigger, int actionIndex) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsControlEnabled(int controlIndex) { }

	[CalledBy(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionMap), Member = "get_devices", ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool IsUsingDevice(InputDevice device) { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "FinishBindingResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void NotifyListenersOfActionChange(InputActionChange change) { }

	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "EnableSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DisableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DisableSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`2<Object, Int32Enum>>&), typeof(object), "System.Int32Enum", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action`1<Object>>&), typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	internal static void NotifyListenersOfActionChange(InputActionChange change, object actionOrMapOrAsset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputActionState), Member = "IsActiveControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "SignalStateChangeMonitor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "FireStateChangeNotifications", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void OnBeforeInitialUpdate() { }

	[CalledBy(Type = typeof(InputManager), Member = "NotifyUsageChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "ResetDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(bool), typeof(System.Nullable`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionState), Member = "CanUseDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "LazyResolveBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "IsUsingDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeviceArray), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "ResetActionStatesDrivenBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	internal static void OnDeviceChange(InputDevice device, InputDeviceChange change) { }

	[CalledBy(Type = typeof(InputActionMap), Member = "ResolveBindings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "DisableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "ClearCachedActionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "DisableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ResetInteractionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlList`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "TControl"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlList`1), Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControlList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "ActiveControlIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "get_activeControl", ReturnType = typeof(InputControl))]
	[Calls(Type = typeof(InputAction), Member = "get_phase", ReturnType = typeof(InputActionPhase))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(InputActionMap), Member = "get_actions", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputAction>))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	internal void PrepareForBindingReResolution(bool needFullResolve, ref InputControlList<InputControl>& activeControls, ref bool hasEnabledActions) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputControl), Member = "get_isButton", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ButtonControl), Member = "get_pressPointOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	private void ProcessButtonState(ref TriggerState trigger, int actionIndex, BindingState* bindingStatePtr) { }

	[CalledBy(Type = typeof(InputActionState), Member = "UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(double), typeof(InputEventPtr), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(InputDevice), Member = "get_added", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControlExtensions), Member = "CheckStateIsAtDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputEvent), Member = "get_eventId", ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionState), Member = "ProcessInteractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputEventPtr), Member = "get_handled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "IsConflictingInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "ProcessButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int), typeof(BindingState*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ProcessDefaultInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 31)]
	[ContainsUnimplementedInstructions]
	private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, InputEventPtr eventPtr) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonControl), Member = "get_pressPointOrDefault", ReturnType = typeof(float))]
	[Calls(Type = typeof(InputActionState), Member = "IsActuated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	private void ProcessDefaultInteraction(ref TriggerState trigger, int actionIndex) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private void ProcessInteractions(ref TriggerState trigger, int interactionStartIndex, int interactionCount) { }

	[CalledBy(Type = typeof(InputActionState), Member = "UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(double), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 20)]
	private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex) { }

	[CalledBy(Type = typeof(InputBindingCompositeContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Void*), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool ReadCompositePartValue(int bindingIndex, int partNumber, Void* buffer, int bufferSize) { }

	[CalledBy(Type = typeof(InputBindingCompositeContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BindingState), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = "UnityEngine.InputSystem.InputBindingCompositeContext+DefaultComparer`1", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal TValue ReadCompositePartValue(int bindingIndex, int partNumber, Boolean* buttonValuePtr, out int controlIndex, TComparer comparer = null) { }

	[CalledBy(Type = typeof(InputBindingCompositeContext), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber) { }

	[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Void*), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputControlExtensions), Member = "ReadValueIntoBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(Void*), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void ReadValue(int bindingIndex, int controlIndex, Void* buffer, int bufferSize, bool ignoreComposites = false) { }

	[CalledBy(Type = typeof(CallbackContext), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(InputAction), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = "TValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BindingState), Member = "get_isPartOfComposite", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BindingState), Member = "get_compositeOrCompositeBindingIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Int32>), Member = "get_value", ReturnType = typeof(Int32&))]
	[Calls(Type = typeof(InputActionState), Member = "GetActionOrNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeHelpers), Member = "GetNiceTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 59)]
	[DeduplicatedMethod]
	internal TValue ReadValue(int bindingIndex, int controlIndex, bool ignoreComposites = false) { }

	[CalledBy(Type = typeof(CallbackContext), Member = "ReadValueAsButton", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ButtonControl), Member = "get_pressPointOrDefault", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal bool ReadValueAsButton(int bindingIndex, int controlIndex) { }

	[CalledBy(Type = typeof(CallbackContext), Member = "ReadValueAsObject", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InputAction), Member = "ReadValueAsObject", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(InputActionState), Member = "ReadCompositePartValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputControlExtensions), Member = "ReadValueAsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveMapFromGlobalList() { }

	[CalledBy(Type = typeof(InputAction), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ResetActionStatesDrivenBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DisableAllActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "DisableSingleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputState), Member = "get_currentTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ResetInteractionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase)}, ReturnType = typeof(bool))]
	public void ResetActionState(int actionIndex, InputActionPhase toPhase = 1, bool hardReset = false) { }

	[CalledBy(Type = typeof(InputActionState), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
	[Calls(Type = typeof(InputActionState), Member = "IsActionBoundToControlFromDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private void ResetActionStatesDrivenBy(InputDevice device) { }

	[CalledBy(Type = typeof(<>c), Member = "<SaveAndResetState>b__143_1", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(InputActionState), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArray`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static void ResetGlobals() { }

	[CalledBy(Type = typeof(InputActionState), Member = "PrepareForBindingReResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(InputControlList`1<InputControl>&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ResetActionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "IsConflictingInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InputActionState), Member = "StopTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void ResetInteractionState(int interactionIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, InputActionPhase phaseAfterCanceled) { }

	[CalledBy(Type = typeof(InputActionState), Member = "FinishBindingResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "TValue")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "GetEnumerator", ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>+Enumerator<TValue>")]
	[Calls(Type = typeof(InputActionMap), Member = "get_actions", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputAction>))]
	[Calls(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionState), Member = "NotifyListenersOfActionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionChange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "HookOnBeforeUpdate", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "StartTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TriggerState&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InteractionState), Member = "set_triggerControlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_interactionIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TriggerState), Member = "set_controlIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionState), Member = "FindControlIndexOnBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputControl)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputControlList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TControl")]
	[Calls(Type = typeof(InputActionState), Member = "EnableControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	private void RestoreActionStatesAfterReResolvingBindings(UnmanagedMemory oldState, InputControlList<InputControl> activeControls, bool isFullResolve) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.SavedStructState`1<UnityEngine.InputSystem.InputActionState+GlobalState>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlobalState&), typeof(UnityEngine.InputSystem.Utilities.SavedStructState`1+TypedRestore<UnityEngine.InputSystem.InputActionState+GlobalState>), typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal static ISavedState SaveAndResetState() { }

	[CallerCount(Count = 0)]
	private void SetControlEnabled(int controlIndex, bool state) { }

	[CallerCount(Count = 0)]
	private void SetInitialStateCheckPending(BindingState* bindingStatePtr, bool value) { }

	[CalledBy(Type = typeof(InputAction), Member = "RequestInitialStateCheckOnEnabledAction", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ApplyBindingOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetInitialStateCheckPending(int actionIndex, bool value = true) { }

	[CalledBy(Type = typeof(InputInteractionContext), Member = "SetTotalTimeoutCompletionTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal void SetTotalTimeoutCompletionTime(float seconds, ref TriggerState trigger) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputEvent), Member = "get_eventId", ReturnType = typeof(int))]
	private static bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr) { }

	[CallerCount(Count = 0)]
	private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex) { }

	[CalledBy(Type = typeof(InputActionState), Member = "RestoreActionStatesAfterReResolvingBindings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnmanagedMemory), typeof(UnityEngine.InputSystem.InputControlList`1<UnityEngine.InputSystem.InputControl>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputInteractionContext), Member = "SetTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputActionState), Member = "StopTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputManager), Member = "AddStateChangeMonitorTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(IInputStateChangeMonitor), typeof(double), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal void StartTimeout(float seconds, ref TriggerState trigger) { }

	[CalledBy(Type = typeof(InputActionState), Member = "StartTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(TriggerState&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ChangePhaseOfInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionPhase), typeof(TriggerState&), typeof(InputActionPhase), typeof(InputActionPhase), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ResetInteractionState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "RemoveStateChangeMonitorTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputStateChangeMonitor), typeof(long), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void StopTimeout(int interactionIndex) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Copy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "TValue[]")]
	[Calls(Type = typeof(UnmanagedMemory), Member = "Clone", ReturnType = typeof(UnmanagedMemory))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	private override object System.ICloneable.Clone() { }

	[CallerCount(Count = 0)]
	private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "remove_onBeforeUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void UnhookOnBeforeUpdate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "ProcessControlStateChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(void))]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long mapControlAndBindingIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionState), Member = "ProcessTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex) { }

}

