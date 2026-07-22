namespace UnityEngine.InputSystem.Utilities;

public struct NameAndParameters
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<NamedValue, String> <>9__8_0; //Field offset: 0x8
		public static Func<NameAndParameters, String> <>9__9_0; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NameAndParameters), Member = "ToString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		internal string <ToSerializableString>b__9_0(NameAndParameters x) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NamedValue), Member = "ToString", ReturnType = typeof(string))]
		[DeduplicatedMethod]
		internal string <ToString>b__8_0(NamedValue x) { }

	}

	[CompilerGenerated]
	private string <name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ReadOnlyArray<NamedValue> <parameters>k__BackingField; //Field offset: 0x8

	public string name
	{
		[CallerCount(Count = 138)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public ReadOnlyArray<NamedValue> parameters
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		 set { } //Length: 18
	}

	[CalledBy(Type = typeof(InputActionAsset), Member = "MigrateJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamedValue)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NamedValue>)}, ReturnType = typeof(NamedValue[]))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static NameAndParameters Create(string name, IList<NamedValue> parameters) { }

	[CallerCount(Count = 138)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public string get_name() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public ReadOnlyArray<NamedValue> get_parameters() { }

	[CalledBy(Type = typeof(InputActionRebindingExtensions), Member = "GetBindingDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(int), typeof(String&), typeof(String&), typeof(DisplayStringOptions)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputBinding), Member = "GetNameOfComposite", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "InstantiateBindingComposite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputBinding&), typeof(InputActionMap)}, ReturnType = typeof(InputBindingComposite))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseNameAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool)}, ReturnType = typeof(NameAndParameters))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static NameAndParameters Parse(string text) { }

	[CalledBy(Type = typeof(InputBinding), Member = "ToDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&), typeof(String&), typeof(DisplayStringOptions), typeof(InputControl)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ControlBuilder), Member = "WithProcessors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson", Member = "ToLayout", ReturnType = typeof(ControlItem))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute)}, ReturnType = typeof(ControlItem))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseNameAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool)}, ReturnType = typeof(NameAndParameters))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static IEnumerable<NameAndParameters> ParseMultiple(string text) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "MigrateJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputBindingResolver), Member = "InstantiateWithParameters", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeTable), typeof(string), "TType[]&", typeof(Int32&), typeof(InputActionMap), typeof(InputBinding&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseNameAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool)}, ReturnType = typeof(NameAndParameters))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static bool ParseMultiple(string text, ref List<NameAndParameters>& list) { }

	[CalledBy(Type = typeof(BindingSyntax), Member = "IterateCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "AddCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(CompositeSyntax))]
	[CalledBy(Type = typeof(InputActionSetupExtensions), Member = "ChangeCompositeBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction), typeof(string)}, ReturnType = typeof(BindingSyntax))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NameAndParameters), Member = "ParseNameAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool)}, ReturnType = typeof(NameAndParameters))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static string ParseName(string text) { }

	[CalledBy(Type = typeof(NameAndParameters), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.Utilities.NameAndParameters>))]
	[CalledBy(Type = typeof(NameAndParameters), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(List`1<NameAndParameters>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NameAndParameters), Member = "ParseName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NameAndParameters), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NameAndParameters))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NamedValue), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NamedValue[]))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	public void set_parameters(ReadOnlyArray<NamedValue> value) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "MigrateJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	internal static string ToSerializableString(IEnumerable<NameAndParameters> list) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson+<>c", Member = "<FromControlItems>b__25_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndParameters)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(<>c), Member = "<ToSerializableString>b__9_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameAndParameters)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

