namespace UnityEngine.SubsystemsImplementation;

[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
public static class SubsystemDescriptorStore
{
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; //Field offset: 0x0
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; //Field offset: 0x8
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static SubsystemDescriptorStore() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	internal static void ClearManagedDescriptors() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubsystemDescriptorStore), Member = "RegisterDescriptor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "TBaseTypeInList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "System.Collections.Generic.List`1<TBaseTypeInList>"}, ReturnType = typeof(void))]
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	[CalledBy(Type = typeof(Internal_SubsystemDescriptors), Member = "Internal_AddDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubsystemDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SubsystemDescriptorStore), Member = "RegisterDeprecatedDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubsystemDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SubsystemDescriptorStore), Member = "ReportSingleSubsystemAnalytics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	[DeduplicatedMethod]
	internal static void RegisterDescriptor(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }

	[CalledBy(Type = typeof(SubsystemDescriptorStore), Member = "RegisterDescriptor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "TBaseTypeInList"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDescriptor", "System.Collections.Generic.List`1<TBaseTypeInList>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static void ReportSingleSubsystemAnalytics(string id) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ReportSingleSubsystemAnalytics_Injected(ref ManagedSpanWrapper id) { }

}

