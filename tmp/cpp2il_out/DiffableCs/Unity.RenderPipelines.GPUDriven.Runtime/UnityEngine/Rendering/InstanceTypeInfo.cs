namespace UnityEngine.Rendering;

internal static class InstanceTypeInfo
{
	public const int kInstanceTypeBitCount = 1; //Field offset: 0x0
	public const int kMaxInstanceTypesCount = 2; //Field offset: 0x0
	public const uint kInstanceTypeMask = 1; //Field offset: 0x0
	private static InstanceType[] s_ParentTypes; //Field offset: 0x0
	private static List<InstanceType>[] s_ChildTypes; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InstanceTypeInfo), Member = "InitChildTypes", ReturnType = typeof(void))]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceTypeInfo), Member = "FlattenChildInstanceTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceType>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static InstanceTypeInfo() { }

	[CalledBy(Type = typeof(InstanceTypeInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceTypeInfo), Member = "FlattenChildInstanceTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceType>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InstanceTypeInfo), Member = "ValidateTypeRelationsAreCorrectlySorted", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NativeList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceTypeInfo), Member = "FlattenChildInstanceTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceType>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void FlattenChildInstanceTypes(InstanceType instanceType, NativeList<InstanceType> instanceTypes) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static List<InstanceType> GetChildTypes(InstanceType type) { }

	[CalledBy(Type = typeof(InstanceTypeInfo), Member = "GetMaxChildTypeRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(InstanceType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(InstanceTypeInfo), Member = "GetMaxChildTypeRecursively", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType)}, ReturnType = typeof(InstanceType))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static InstanceType GetMaxChildTypeRecursively(InstanceType type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static InstanceType GetParentType(InstanceType type) { }

	[CalledBy(Type = typeof(InstanceTypeInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private static void InitChildTypes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static void InitParentTypes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AllocatorHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Allocator)}, ReturnType = typeof(AllocatorHandle))]
	[Calls(Type = typeof(NativeList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InstanceTypeInfo), Member = "FlattenChildInstanceTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InstanceType), typeof(Unity.Collections.NativeList`1<UnityEngine.Rendering.InstanceType>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static void ValidateTypeRelationsAreCorrectlySorted() { }

}

