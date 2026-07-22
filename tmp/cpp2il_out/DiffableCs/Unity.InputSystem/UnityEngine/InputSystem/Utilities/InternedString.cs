namespace UnityEngine.InputSystem.Utilities;

public struct InternedString : IEquatable<InternedString>, IComparable<InternedString>
{
	private readonly string m_StringOriginalCase; //Field offset: 0x0
	private readonly string m_StringLowerCase; //Field offset: 0x8

	public int length
	{
		[CalledBy(Type = typeof(InputControlPath), Member = "StringMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlLayout), Member = "FindControlIncludingArrayElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
		[CalledBy(Type = typeof(Substring), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Substring), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Substring), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Substring), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Substring)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Substring), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Substring)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		 get { } //Length: 14
	}

	[CallerCount(Count = 1417)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Intern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	public InternedString(string text) { }

	[CalledBy(Type = typeof(ReadOnlyArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	public override int CompareTo(InternedString other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(InternedString other) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "StringMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "FindControlIncludingArrayElements", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
	[CalledBy(Type = typeof(Substring), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Substring), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Substring), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Substring), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Substring), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Substring)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Substring), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Substring)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	public int get_length() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 35)]
	[ContainsUnimplementedInstructions]
	public bool IsEmpty() { }

	[CalledBy(Type = typeof(InputManager), Member = "IsControlUsingLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(InternedString)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(string a, InternedString b) { }

	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(InternedString a, InternedString b) { }

	[CalledBy(Type = typeof(XRLayoutBuilder), Member = "ConvertPotentialAliasToName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlLayout), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ControlItem))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(InternedString a, string b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThan(InternedString left, InternedString right) { }

	[CallerCount(Count = 865)]
	[DeduplicatedMethod]
	public static string op_Implicit(InternedString str) { }

	[CalledBy(Type = typeof(InputControlPath), Member = "FindControlLayoutRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PathParser&), typeof(InputControlLayout)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(InternedString a, string b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(string a, InternedString b) { }

	[CalledBy(Type = typeof(RebindingOperation), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Collection), Member = "ComputeDistanceInInheritanceHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(InternedString), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "CreateLookupTableForControls", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ControlItem[]), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(InternedString a, InternedString b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	public static bool op_LessThan(InternedString left, InternedString right) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string ToLower() { }

	[CallerCount(Count = 865)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

