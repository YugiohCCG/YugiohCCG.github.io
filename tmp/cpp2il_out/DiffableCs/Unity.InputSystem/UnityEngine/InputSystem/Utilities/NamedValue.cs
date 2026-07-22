namespace UnityEngine.InputSystem.Utilities;

public struct NamedValue : IEquatable<NamedValue>
{
	public const string Separator = ","; //Field offset: 0x0
	[CompilerGenerated]
	private string <name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private PrimitiveValue <value>k__BackingField; //Field offset: 0x8

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

	public TypeCode type
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public PrimitiveValue value
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddChildControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(InternedString), typeof(InputControl), typeof(Boolean&), typeof(ControlItem), typeof(int), typeof(string)}, ReturnType = typeof(InputControl))]
	[CalledBy(Type = typeof(InputDeviceBuilder), Member = "AddProcessors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(ControlItem&), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NamedValue), Member = "ApplyToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public static void ApplyAllToObject(object instance, TParameterList parameters) { }

	[CalledBy(Type = typeof(NamedValue), Member = "ApplyAllToObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TParameterList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "TParameterList"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[Calls(Type = typeof(PrimitiveValue), Member = "ToObject", ReturnType = typeof(object))]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 25)]
	public void ApplyToObject(object instance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrimitiveValue), Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeCode)}, ReturnType = typeof(PrimitiveValue))]
	[CallsUnknownMethods(Count = 1)]
	public NamedValue ConvertTo(TypeCode type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(NamedValue other) { }

	[CalledBy(Type = typeof(InputActionAsset), Member = "MigrateJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReadFileJson&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PrimitiveValue), Member = "From", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, ReturnType = typeof(PrimitiveValue))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static NamedValue From(string name, TValue value) { }

	[CallerCount(Count = 138)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public string get_name() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public TypeCode get_type() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public PrimitiveValue get_value() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(NamedValue left, NamedValue right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(NamedValue left, NamedValue right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NamedValue), Member = "ParseParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(NamedValue))]
	public static NamedValue Parse(string str) { }

	[CalledBy(Type = typeof(ControlBuilder), Member = "WithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlBuilder))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson", Member = "ToLayout", ReturnType = typeof(ControlItem))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute)}, ReturnType = typeof(ControlItem))]
	[CalledBy(Type = typeof(NameAndParameters), Member = "ParseNameAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(bool)}, ReturnType = typeof(NameAndParameters))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NamedValue), Member = "ParseParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(NamedValue))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public static NamedValue[] ParseMultiple(string parameterString) { }

	[CalledBy(Type = typeof(NamedValue), Member = "ParseMultiple", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NamedValue[]))]
	[CalledBy(Type = typeof(NamedValue), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(NamedValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PrimitiveValue), Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PrimitiveValue))]
	[CallsUnknownMethods(Count = 2)]
	private static NamedValue ParseParameter(string parameterString, ref int index) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_name(string value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_value(PrimitiveValue value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItemJson+<>c", Member = "<FromControlItems>b__25_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamedValue)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.NameAndParameters+<>c", Member = "<ToString>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamedValue)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

