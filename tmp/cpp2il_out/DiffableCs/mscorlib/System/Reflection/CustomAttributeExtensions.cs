namespace System.Reflection;

[Extension]
public static class CustomAttributeExtensions
{

	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Extension]
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[CalledBy(Type = "SQLite.TableMapping+Column", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), "SQLite.CreateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "T")]
	[CalledBy(Type = "System.Linq.Expressions.ExpressionStringBuilder", Member = "VisitMethodCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.MethodCallExpression"}, ReturnType = "System.Linq.Expressions.Expression")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Extension]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(UltimateResourceFallbackLocation&)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguageAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(String&), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "TryGetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), "Unity.Burst.BurstCompileAttribute&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "TryGetOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(String&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Type)}, ReturnType = typeof(Attribute))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static T GetCustomAttribute(Assembly element) { }

	[CalledBy(Type = "System.Xml.Serialization.TypeData", Member = "LookupTypeConvertor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeTraits`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "Unity.Burst.BurstCompileAttribute")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.SupportedOnRenderPipelineAttribute", Member = "IsTypeSupportedOnRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "IsSupportedByObsoleteVolumeComponentMenuForRenderPipeline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+EnumField`1", Member = "AutoFillFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplaySettingsPanel", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Serialization.TypeData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), "System.Xml.Serialization.TypeData", "System.Xml.Schema.XmlSchemaPatternFacet"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBindingComposite+<GetPartNames>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputInteraction", Member = "GetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputInteraction", Member = "GetDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "SQLite.Orm", Member = "MaxStringLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = "System.Nullable`1<Int32>")]
	[CalledBy(Type = "SQLite.Orm", Member = "Collation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "SQLite.TableMapping", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "SQLite.CreateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.TableMapping+Column", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), "SQLite.CreateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBindingComposite", Member = "GetDisplayFormatString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static T GetCustomAttribute(MemberInfo element) { }

	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "ComponentDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[Extension]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IUxmlFactory"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBindingComposite", Member = "GetExpectedControlLayoutName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout", Member = "FromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout", Member = "CreateControlItemFromMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), "UnityEngine.InputSystem.Layouts.InputControlAttribute"}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem")]
	[CalledBy(Type = "UnityEngine.Rendering.DocumentationUtils", Member = "TryGetHelpURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(String&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static T GetCustomAttribute(MemberInfo element, bool inherit) { }

	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "TriggerUnsafeStaticMethodRecompilation", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(Attribute[]))]
	[Extension]
	public static IEnumerable<Attribute> GetCustomAttributes(Assembly element) { }

	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "Compile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MethodInfo), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "Unity.Burst.BurstCompilerOptions", Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "Unity.Burst.BurstCompileAttribute")]
	[CalledBy(Type = "Unity.Properties.FieldMember", Member = "GetCustomAttributes", ReturnType = "System.Collections.Generic.IEnumerable`1<Attribute>")]
	[CalledBy(Type = "Unity.Properties.PropertyMember", Member = "GetCustomAttributes", ReturnType = "System.Collections.Generic.IEnumerable`1<Attribute>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(Attribute[]))]
	[Extension]
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element) { }

	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute[]))]
	[Extension]
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[CalledBy(Type = "SQLite.TableMapping+Column", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), "SQLite.CreateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SQLite.Orm", Member = "GetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = "System.Collections.Generic.IEnumerable`1<IndexedAttribute>")]
	[CalledBy(Type = typeof(StackTrace), Member = "ConvertAsyncStateMachineMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase&), typeof(Type&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<T> GetCustomAttributes(MemberInfo element) { }

	[CalledBy(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = "System.Collections.Generic.IEnumerable`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(Attribute[]))]
	[Extension]
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType, bool inherit) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout", Member = "AddControlItemsFromMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Reflection.MemberInfo[]", "System.Collections.Generic.List`1<ControlItem>", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Extension]
	public static IEnumerable<T> GetCustomAttributes(MemberInfo element, bool inherit) { }

	[CalledBy(Type = typeof(StackTrace), Member = "GetFullNameForStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MethodBase), typeof(bool), typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugUI+EnumField`1+<>c", Member = "<AutoFillFromType>b__6_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Attribute), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(bool))]
	[Extension]
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

}

