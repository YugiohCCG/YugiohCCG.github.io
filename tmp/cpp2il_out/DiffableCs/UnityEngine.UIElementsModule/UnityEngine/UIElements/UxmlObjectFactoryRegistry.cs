namespace UnityEngine.UIElements;

[Obsolete("UxmlObjectFactoryRegistry is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UxmlObjectFactoryRegistry
{
	private static Dictionary<String, List`1<IBaseUxmlObjectFactory>> s_Factories; //Field offset: 0x0

	internal static Dictionary<String, List`1<IBaseUxmlObjectFactory>> factories
	{
		[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseUxmlObjectFactory)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjectFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlObjectAsset)}, ReturnType = typeof(IBaseUxmlObjectFactory))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
		[Calls(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterUserFactories", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 191
	}

	[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseUxmlObjectFactory)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualTreeAsset), Member = "GetUxmlObjectFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UxmlObjectAsset)}, ReturnType = typeof(IBaseUxmlObjectFactory))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static Dictionary<String, List`1<IBaseUxmlObjectFactory>> get_factories() { }

	[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "get_factories", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Collections.Generic.List`1<UnityEngine.UIElements.IBaseUxmlObjectFactory>>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UxmlObjectFactory), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlObjectFactory), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlObjectFactory), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlObjectFactory), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseUxmlObjectFactory)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 18)]
	private static void RegisterEngineFactories() { }

	[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterEngineFactories", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UxmlObjectFactoryRegistry), Member = "get_factories", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Collections.Generic.List`1<UnityEngine.UIElements.IBaseUxmlObjectFactory>>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 15)]
	protected static void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	[CalledBy(Type = typeof(UxmlObjectFactoryRegistry), Member = "get_factories", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.Collections.Generic.List`1<UnityEngine.UIElements.IBaseUxmlObjectFactory>>))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.ScriptingRuntime", Member = "GetAllUserAssemblies", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(UxmlObjectFactoryRegistry), Member = "RegisterFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IBaseUxmlObjectFactory)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private static void RegisterUserFactories() { }

}

