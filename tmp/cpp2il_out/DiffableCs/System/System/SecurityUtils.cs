namespace System;

internal static class SecurityUtils
{

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static void DemandGrantSet(Assembly assembly) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private static void DemandReflectionAccess(Type type) { }

	[CalledBy(Type = typeof(SecurityUtils), Member = "MethodInfoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	[CalledBy(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[]), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[]), typeof(Object[]), typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	private static bool HasReflectionPermission(Type type) { }

	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecurityUtils), Member = "GenericArgumentsAreVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal static object MethodInfoInvoke(MethodInfo method, object target, Object[] args) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IServiceProvider), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecurityUtils), Member = "HasReflectionPermission", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, bool allowNonPublic) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IServiceProvider), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecurityUtils), Member = "HasReflectionPermission", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, Object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static object SecureCreateInstance(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SecurityUtils), Member = "HasReflectionPermission", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static object SecureCreateInstance(Type type, Object[] args, bool allowNonPublic) { }

	[CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IServiceProvider), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal static object SecureCreateInstance(Type type, Object[] args) { }

}

