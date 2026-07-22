namespace UnityEngine.InputSystem.Utilities;

[Extension]
internal static class TypeHelpers
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	[Extension]
	public static TObject As(object obj) { }

	[CalledBy(Type = typeof(InputInteraction), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(InputBindingComposite), Member = "GetValueType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(InputProcessor), Member = "GetValueTypeFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Collection), Member = "ValueTypeIsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "GetValueType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(TypeHelpers), Member = "GetGenericTypeArgumentFromHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(int)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeHelpers), Member = "GetGenericTypeArgumentFromHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(int)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 14)]
	public static Type GetGenericTypeArgumentFromHierarchy(Type type, Type genericTypeDefinition, int argumentIndex) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(InputStateHistory), Member = "ReadValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RecordHeader*)}, ReturnType = "TValue")]
	[CalledBy(Type = typeof(InputStateHistory`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	public static string GetNiceTypeName(Type type) { }

	[CalledBy(Type = typeof(InputControlLayout), Member = "AddControlItemsFromMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo[]), typeof(System.Collections.Generic.List`1<UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputControlLayout), Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(InputControlAttribute)}, ReturnType = typeof(ControlItem))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static Type GetValueType(MemberInfo member) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Extension]
	public static bool IsInt(TypeCode type) { }

}

