namespace UnityEngine.InputSystem.Utilities;

internal struct TypeTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<InternedString, String> <>9__2_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal string <get_names>b__2_0(InternedString x) { }

	}

	public Dictionary<InternedString, Type> table; //Field offset: 0x0
	private InputManager m_Manager; //Field offset: 0x8

	public IEnumerable<InternedString> internedNames
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 67
	}

	public IEnumerable<String> names
	{
		[CalledBy(Type = typeof(InputSystem), Member = "ListProcessors", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
		[CalledBy(Type = typeof(InputSystem), Member = "ListInteractions", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 320
	}

	[CalledBy(Type = typeof(InputSystem), Member = "RegisterProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RegisterInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "RegisterBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "InitializeData", ReturnType = typeof(void))]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void AddTypeRegistration(string name, Type type) { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "ExtractParameterOverride", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TObject", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression`1<Func`2<TObject, TValue>>", typeof(InputBinding), typeof(PrimitiveValue)}, ReturnType = typeof(ParameterOverride))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "WithInteraction", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TInteraction"}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(BindingSyntax), Member = "WithProcessor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TProcessor"}, ReturnType = typeof(BindingSyntax))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public InternedString FindNameForType(Type type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerable<InternedString> get_internedNames() { }

	[CalledBy(Type = typeof(InputSystem), Member = "ListProcessors", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CalledBy(Type = typeof(InputSystem), Member = "ListInteractions", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.String>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public IEnumerable<String> get_names() { }

	[CalledBy(Type = typeof(InputManager), Member = "InitializeData", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize(InputManager manager) { }

	[CalledBy(Type = typeof(InputInteraction), Member = "GetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddProcessors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "TryGetBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(InputSystem), Member = "TryGetInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "InstantiateBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(InputActionMap)}, ReturnType = typeof(InputBindingComposite))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "InstantiateWithParameters", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeTable), typeof(string), "TType[]&", typeof(Int32&), typeof(InputActionMap), typeof(InputBinding&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputSystem), Member = "TryGetProcessor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(InputBindingComposite), Member = "GetExpectedControlLayoutName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputBindingComposite), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBindingComposite+<GetPartNames>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ParameterOverride), Member = "get_objectType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(InputBindingComposite), Member = "GetDisplayFormatString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InternedString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeTable), Member = "TryLookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 4)]
	public Type LookupTypeRegistration(string name) { }

	[CalledBy(Type = typeof(TypeTable), Member = "LookupTypeRegistration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.Utilities.InternedString, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputManager), Member = "RegisterCustomTypes", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private Type TryLookupTypeRegistration(InternedString internedName) { }

}

