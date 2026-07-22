namespace UnityEngine;

internal class AttributeHelperEngine
{
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; //Field offset: 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; //Field offset: 0x8
	public static RequireComponent[] _requireComponentArray; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static AttributeHelperEngine() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static int CheckIsEditorScript(Type klass) { }

	[CalledBy(Type = typeof(AttributeHelperEngine), Member = "GetDefaultExecutionOrderFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static T GetCustomAttributeOfType(Type klass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributeHelperEngine), Member = "GetCustomAttributeOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "T")]
	[RequiredByNativeCode]
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int GetExecuteMode(Type klass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Attribute), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 19)]
	[RequiredByNativeCode]
	private static Type[] GetRequiredComponents(Type klass) { }

}

