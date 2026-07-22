namespace UnityEngine.InputSystem;

[Extension]
public static class InputActionSetupExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public InputBinding binding; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass5_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputBinding), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(bool))]
		internal bool <RemoveAction>b__0(InputBinding b) { }

	}

	internal struct BindingSyntax
	{
		private readonly InputActionMap m_ActionMap; //Field offset: 0x0
		private readonly InputAction m_Action; //Field offset: 0x8
		internal readonly int m_BindingIndexInMap; //Field offset: 0x10

		public InputBinding binding
		{
			[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
			[CalledBy(Type = typeof(BindingSyntax), Member = "IterateCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
			[CalledBy(Type = typeof(BindingSyntax), Member = "IteratePartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
			[CalledBy(Type = typeof(BindingSyntax), Member = "InsertPartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 6)]
			 get { } //Length: 295
		}

		public int bindingIndex
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
			[Calls(Type = typeof(InputAction), Member = "BindingIndexOnMapToBindingIndexOnAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
			 get { } //Length: 132
		}

		public bool valid
		{
			[CalledBy(Type = typeof(BindingSyntax), Member = "WithInteraction", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInteraction"}, ReturnType = typeof(BindingSyntax))]
			[CalledBy(Type = typeof(BindingSyntax), Member = "WithProcessor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TProcessor"}, ReturnType = typeof(BindingSyntax))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
			[ContainsUnimplementedInstructions]
			 get { } //Length: 100
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal BindingSyntax(InputActionMap map, int bindingIndexInMap, InputAction action = null) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArrayHelpers), Member = "EraseAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		public void Erase() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "IterateCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "IteratePartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "InsertPartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		public InputBinding get_binding() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputAction), Member = "BindingIndexOnMapToBindingIndexOnAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		public int get_bindingIndex() { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "WithInteraction", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInteraction"}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "WithProcessor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TProcessor"}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		public bool get_valid() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BindingSyntax), Member = "get_binding", ReturnType = typeof(InputBinding))]
		[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBindingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 17)]
		public BindingSyntax InsertPartBinding(string partName, string path) { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "NextBinding", ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "PreviousBinding", ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "IterateCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "IteratePartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private BindingSyntax Iterate(bool next) { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "NextCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "PreviousCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(BindingSyntax), Member = "Iterate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BindingSyntax), Member = "get_binding", ReturnType = typeof(InputBinding))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NameAndParameters), Member = "ParseName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		private BindingSyntax IterateCompositeBinding(bool next, string compositeName) { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "NextPartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = typeof(BindingSyntax), Member = "PreviousPartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BindingSyntax), Member = "get_binding", ReturnType = typeof(InputBinding))]
		[Calls(Type = typeof(BindingSyntax), Member = "Iterate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private BindingSyntax IteratePartBinding(bool next, string partName) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BindingSyntax), Member = "Iterate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BindingSyntax))]
		public BindingSyntax NextBinding() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BindingSyntax), Member = "IterateCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		public BindingSyntax NextCompositeBinding(string compositeName = null) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BindingSyntax), Member = "IteratePartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public BindingSyntax NextPartBinding(string partName) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BindingSyntax), Member = "Iterate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(BindingSyntax))]
		public BindingSyntax PreviousBinding() { }

		[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(BindingSyntax), Member = "IterateCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		public BindingSyntax PreviousCompositeBinding(string compositeName = null) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(BindingSyntax), Member = "IteratePartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		public BindingSyntax PreviousPartBinding(string partName) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		public BindingSyntax To(InputBinding binding) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputAction), Member = "get_isSingletonAction", ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 16)]
		public BindingSyntax Triggering(InputAction action) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BindingSyntax), Member = "WithGroups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 15)]
		public BindingSyntax WithGroup(string group) { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "WithGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public BindingSyntax WithGroups(string groups) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BindingSyntax), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeTable), Member = "FindNameForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
		[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BindingSyntax), Member = "WithInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		public BindingSyntax WithInteraction() { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "WithInteraction", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInteraction"}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BindingSyntax), Member = "WithInteractions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 15)]
		public BindingSyntax WithInteraction(string interaction) { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "WithInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public BindingSyntax WithInteractions(string interactions) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		public BindingSyntax WithName(string name) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		public BindingSyntax WithPath(string path) { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "WithProcessor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TProcessor"}, ReturnType = typeof(BindingSyntax))]
		[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "RegisterInputs", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(BindingSyntax), Member = "WithProcessors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 15)]
		public BindingSyntax WithProcessor(string processor) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BindingSyntax), Member = "get_valid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TypeTable), Member = "FindNameForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
		[Calls(Type = typeof(InternedString), Member = "IsEmpty", ReturnType = typeof(bool))]
		[Calls(Type = typeof(BindingSyntax), Member = "WithProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		public BindingSyntax WithProcessor() { }

		[CalledBy(Type = typeof(BindingSyntax), Member = "WithProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 9)]
		public BindingSyntax WithProcessors(string processors) { }

	}

	internal struct CompositeSyntax
	{
		private readonly InputAction m_Action; //Field offset: 0x0
		private readonly InputActionMap m_ActionMap; //Field offset: 0x8
		private int m_BindingIndexInMap; //Field offset: 0x10

		public int bindingIndex
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InputAction), Member = "BindingIndexOnMapToBindingIndexOnAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
			 get { } //Length: 37
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal CompositeSyntax(InputActionMap map, InputAction action, int compositeIndex) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputAction), Member = "BindingIndexOnMapToBindingIndexOnAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		public int get_bindingIndex() { }

		[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "RegisterInputs", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "RegisterInputs", ReturnType = typeof(void))]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(InputActionRebindingExtensions), Member = "DeferBindingResolution", ReturnType = typeof(DeferBindingResolutionWrapper))]
		[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
		[CallsUnknownMethods(Count = 10)]
		public CompositeSyntax With(string name, string binding, string groups = null, string processors = null) { }

	}

	internal struct ControlSchemeSyntax
	{
		private readonly InputActionAsset m_Asset; //Field offset: 0x0
		private readonly int m_ControlSchemeIndex; //Field offset: 0x8
		private InputControlScheme m_ControlScheme; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal ControlSchemeSyntax(InputActionAsset asset, int index) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal ControlSchemeSyntax(InputControlScheme controlScheme) { }

		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "WithRequiredDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "WithOptionalDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "OrWithRequiredDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "OrWithOptionalDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "WithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(string), typeof(bool)}, ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "WithRequiredDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(string)}, ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "WithOptionalDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(string)}, ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "OrWithRequiredDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(string)}, ReturnType = typeof(InputControlScheme))]
		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "OrWithOptionalDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(string)}, ReturnType = typeof(InputControlScheme))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		private void AddDeviceEntry(string controlPath, Flags flags) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Collection), Member = "TryFindLayoutForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(InternedString))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private string DeviceTypeToControlPath() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		public InputControlScheme Done() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ControlSchemeSyntax), Member = "OrWithOptionalDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ControlSchemeSyntax OrWithOptionalDevice() { }

		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "OrWithOptionalDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, ReturnType = typeof(ControlSchemeSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
		public ControlSchemeSyntax OrWithOptionalDevice(string controlPath) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ControlSchemeSyntax), Member = "OrWithRequiredDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ControlSchemeSyntax OrWithRequiredDevice() { }

		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "OrWithRequiredDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, ReturnType = typeof(ControlSchemeSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
		public ControlSchemeSyntax OrWithRequiredDevice(string controlPath) { }

		[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "WithBindingGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme), typeof(string)}, ReturnType = typeof(InputControlScheme))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		public ControlSchemeSyntax WithBindingGroup(string bindingGroup) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ControlSchemeSyntax), Member = "WithOptionalDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ControlSchemeSyntax WithOptionalDevice() { }

		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "WithOptionalDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, ReturnType = typeof(ControlSchemeSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
		public ControlSchemeSyntax WithOptionalDevice(string controlPath) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ControlSchemeSyntax), Member = "WithRequiredDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public ControlSchemeSyntax WithRequiredDevice() { }

		[CalledBy(Type = typeof(ControlSchemeSyntax), Member = "WithRequiredDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, ReturnType = typeof(ControlSchemeSyntax))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
		public ControlSchemeSyntax WithRequiredDevice(string controlPath) { }

	}


	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "RegisterInputs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "RegisterInputs", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(InputActionMap), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "GenerateId", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionMap), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 37)]
	[Extension]
	public static InputAction AddAction(InputActionMap map, string name, InputActionType type = 0, string binding = null, string interactions = null, string processors = null, string groups = null, string expectedControlLayout = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionMap), Member = "GenerateId", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputActionMap)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[Extension]
	public static InputActionMap AddActionMap(InputActionAsset asset, string name) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(InputActionMap))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputActionAsset), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionAsset), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 25)]
	[Extension]
	public static void AddActionMap(InputActionAsset asset, InputActionMap map) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnComplete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompositeSyntax), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputActionType), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(InputAction))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputControl)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "RegisterInputs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "RegisterInputs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "RegisterFixedActions", ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBindingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static BindingSyntax AddBinding(InputAction action, string path, string interactions = null, string processors = null, string groups = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputControl), Member = "get_path", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Extension]
	public static BindingSyntax AddBinding(InputAction action, InputControl control) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBindingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	public static BindingSyntax AddBinding(InputAction action, InputBinding binding = null) { }

	[CalledBy(Type = typeof(CompositeSyntax), Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(InputAction), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(Guid), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBindingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	[Extension]
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, string interactions = null, string groups = null, string action = null, string processors = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputAction), Member = "get_id", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, InputAction action, string interactions = null, string groups = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Extension]
	public static BindingSyntax AddBinding(InputActionMap actionMap, string path, Guid action, string interactions = null, string groups = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBindingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	[Extension]
	public static BindingSyntax AddBinding(InputActionMap actionMap, InputBinding binding) { }

	[CalledBy(Type = typeof(BindingSyntax), Member = "InsertPartBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArrayHelpers), Member = "InsertAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int), "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding[]&), typeof(InputBinding)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "OnBindingModified", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1) { }

	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "RegisterInputs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugManager", Member = "RegisterInputs", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddBindingInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap), typeof(InputBinding), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 16)]
	[Extension]
	public static CompositeSyntax AddCompositeBinding(InputAction action, string composite, string interactions = null, string processors = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "get_controlSchemes", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(InputControlScheme), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.InputControlScheme+DeviceRequirement>), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "AddControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(InputControlScheme)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	public static ControlSchemeSyntax AddControlScheme(InputActionAsset asset, string name) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindControlScheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.InputControlScheme>))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Append", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", "TValue"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	[Extension]
	public static void AddControlScheme(InputActionAsset asset, InputControlScheme controlScheme) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBindingWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBindingWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(Guid)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBindingWithGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeBindingWithPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputAction), Member = "get_idDontGenerate", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(InputAction), Member = "get_id", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionMap), Member = "FindBindingRelativeToMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	public static BindingSyntax ChangeBinding(InputAction action, InputBinding match) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	public static BindingSyntax ChangeBinding(InputActionMap actionMap, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static BindingSyntax ChangeBinding(InputAction action, string name) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "WithTargetBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RebindingOperation))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputAction), Member = "BindingIndexOnActionToBindingIndexOnMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[Extension]
	public static BindingSyntax ChangeBinding(InputAction action, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static BindingSyntax ChangeBindingWithGroup(InputAction action, string group) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static BindingSyntax ChangeBindingWithId(InputAction action, string id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static BindingSyntax ChangeBindingWithId(InputAction action, Guid id) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "ChangeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(InputBinding)}, ReturnType = typeof(BindingSyntax))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	public static BindingSyntax ChangeBindingWithPath(InputAction action, string path) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[Extension]
	public static BindingSyntax ChangeCompositeBinding(InputAction action, string compositeName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static InputControlScheme OrWithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static InputControlScheme OrWithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	public static void RemoveAction(InputActionAsset asset, string nameOrId) { }

	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "RemoveAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionAsset), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputAction), Member = "get_bindings", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputBinding>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst", "TSecond"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TFirst[]", "TSecond", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Predicate`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]", "System.Predicate`1<TValue>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputActionMap), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[Extension]
	public static void RemoveAction(InputAction action) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Erase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[Extension]
	public static void RemoveActionMap(InputActionAsset asset, string nameOrId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionMap), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputActionAsset), Member = "OnWantToChangeSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArrayHelpers), Member = "Erase", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "OnSetupChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[Extension]
	public static void RemoveActionMap(InputActionAsset asset, InputActionMap map) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputActionAsset), Member = "FindControlSchemeIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "EraseAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[Extension]
	public static void RemoveControlScheme(InputActionAsset asset, string name) { }

	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "BindTrackingState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TrackedPoseDriver), Member = "RenameAndEnable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputActionMap), Member = "ClearActionLookupTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArrayHelpers), Member = "LengthSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InputAction), Member = "GetOrCreateActionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(InputActionMap), Member = "FindAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputAction))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InputAction), Member = "get_actionMap", ReturnType = typeof(InputActionMap))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	[Extension]
	public static void Rename(InputAction action, string newName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlSchemeSyntax), Member = "WithBindingGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlSchemeSyntax))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static InputControlScheme WithBindingGroup(InputControlScheme scheme, string bindingGroup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static InputControlScheme WithDevice(InputControlScheme scheme, string controlPath, bool required) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static InputControlScheme WithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControlSchemeSyntax), Member = "AddDeviceEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Flags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static InputControlScheme WithRequiredDevice(InputControlScheme scheme, string controlPath) { }

}

