namespace Unity.Properties.Internal;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.PropertiesModule"})]
internal static class PropertiesInitialization
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectedPropertyBagProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag), Member = "Register", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.PropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SystemVersionPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 30)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode(False)]
	public static void InitializeProperties() { }

}

