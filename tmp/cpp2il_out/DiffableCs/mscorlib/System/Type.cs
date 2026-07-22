namespace System;

public abstract class Type : MemberInfo
{
	private static Binder s_defaultBinder; //Field offset: 0x0
	public static readonly char Delimiter; //Field offset: 0x8
	public static readonly Type[] EmptyTypes; //Field offset: 0x10
	public static readonly object Missing; //Field offset: 0x18
	public static readonly MemberFilter FilterAttribute; //Field offset: 0x20
	public static readonly MemberFilter FilterName; //Field offset: 0x28
	public static readonly MemberFilter FilterNameIgnoreCase; //Field offset: 0x30
	internal RuntimeTypeHandle _impl; //Field offset: 0x10

	public abstract Assembly Assembly
	{
		 get { } //Length: 0
	}

	public abstract string AssemblyQualifiedName
	{
		 get { } //Length: 0
	}

	public override TypeAttributes Attributes
	{
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
		[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TypeDelegator), Member = "GetAttributeFlagsImpl", ReturnType = typeof(TypeAttributes))]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = "System.ComponentModel.AttributeCollection")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	public abstract Type BaseType
	{
		 get { } //Length: 0
	}

	public override bool ContainsGenericParameters
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 327
	}

	public override MethodBase DeclaringMethod
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual Type DeclaringType
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public static Binder DefaultBinder
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
		[CalledBy(Type = typeof(FormatterServices), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 211
	}

	public abstract string FullName
	{
		 get { } //Length: 0
	}

	internal string FullNameOrDefault
	{
		[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 133
	}

	public override GenericParameterAttributes GenericParameterAttributes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	public override int GenericParameterPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 78
	}

	public override Type[] GenericTypeArguments
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 125
	}

	public override bool HasElementType
	{
		[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[CalledBy(Type = typeof(RuntimeType), Member = "get_ContainsGenericParameters", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
		[CalledBy(Type = typeof(TypeDelegator), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "EnsureNotByRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	internal string InternalNameIfAvailable
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 39
	}

	public override bool IsAbstract
	{
		[CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsAbstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "SetImplicitConstructor", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Properties.TypeTraits`1", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonDictionaryContract", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonContract", Member = "set_CreatedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonArrayContract", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Unity.Properties.IPropertyBag")]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "LoadBaseTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Xml.Serialization.ReflectionHelper", Member = "CheckSerializableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "RegisterCustomTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Type[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UxmlObjectFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.Xml.Serialization.TypeData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), "System.Xml.Serialization.TypeData", "System.Xml.Schema.XmlSchemaPatternFacet"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.JsonUtility", Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[CallerCount(Count = 22)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 33
	}

	public override bool IsArray
	{
		[CallerCount(Count = 79)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	public override bool IsByRef
	{
		[CallerCount(Count = 56)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	public override bool IsClass
	{
		[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
		[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "RegisterCustomTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Type[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.VolumeComponent", Member = "FindParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Collections.Generic.List`1<VolumeParameter>", "System.Func`2<FieldInfo, Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "StrictHasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 67
	}

	public override bool IsCollectible
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsCOMObject
	{
		[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
		[CalledBy(Type = typeof(TypeDelegator), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	public override bool IsConstructedGenericType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public override bool IsContextful
	{
		[CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(TransparentProxy), Member = "get_IsContextBoundObject", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
		[CalledBy(Type = typeof(ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
		[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RemoteActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	public override bool IsEnum
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 116
	}

	public override bool IsExplicitLayout
	{
		[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 32
	}

	public override bool IsGenericMethodParameter
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 72
	}

	public override bool IsGenericParameter
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsGenericType
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsGenericTypeDefinition
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsInterface
	{
		[CallerCount(Count = 61)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 193
	}

	public override bool IsMarshalByRef
	{
		[CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
		[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ClientIdentity)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ClientIdentity)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RemotingSurrogateSelector), Member = "GetSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StreamingContext), typeof(ISurrogateSelector&)}, ReturnType = typeof(ISerializationSurrogate))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	public bool IsNested
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "FormatTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Unity.Properties.TypeUtility", Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Collections.Generic.IReadOnlyList`1<Type>", typeof(Int32&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 58
	}

	public override bool IsNestedAssembly
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 33
	}

	public override bool IsNestedPublic
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
		[CalledBy(Type = "System.Xml.Serialization.ReflectionHelper", Member = "CheckSerializableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.ComponentModel.EventDescriptor[]")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 32
	}

	public override bool IsNotPublic
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "get_MemberType", ReturnType = typeof(MemberTypes))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 30
	}

	public override bool IsPointer
	{
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public override bool IsPrimitive
	{
		[CallerCount(Count = 38)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	public override bool IsPublic
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(RuntimeType), Member = "get_MemberType", ReturnType = typeof(MemberTypes))]
		[CalledBy(Type = "System.Xml.Serialization.ReflectionHelper", Member = "CheckSerializableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.ComponentModel.EventDescriptor[]")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 32
	}

	public override bool IsSealed
	{
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
		[CalledBy(Type = typeof(NameInfo), Member = "get_IsSealed", ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsSealed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonArrayContract", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonContainerContract", Member = "set_ItemContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonContract"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonContract", Member = "set_CreatedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonDictionaryContract", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "StrictHasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 33
	}

	public override bool IsSerializable
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 366
	}

	public override bool IsSignatureType
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	internal override bool IsSzArray
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public override bool IsSZArray
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public override bool IsValueType
	{
		[CallerCount(Count = 114)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 17
	}

	public override bool IsVariableBoundArray
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 65
	}

	public bool IsVisible
	{
		[CalledBy(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]"}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.SecurityUtils", Member = "GenericArgumentsAreVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.SecurityUtils", Member = "MethodInfoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(object), "System.Object[]"}, ReturnType = typeof(object))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 429
	}

	public virtual MemberTypes MemberType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public abstract Module Module
	{
		 get { } //Length: 0
	}

	internal string NameOrDefault
	{
		[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 93
	}

	public abstract string Namespace
	{
		 get { } //Length: 0
	}

	public virtual Type ReflectedType
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override RuntimeTypeHandle TypeHandle
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	public abstract Type UnderlyingSystemType
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private static Type() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 10)]
	private static int BinarySearch(Array array, object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Type o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	[ContainsUnimplementedInstructions]
	private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static bool FilterNameImpl(MemberInfo m, object filterCriteria) { }

	[CalledBy(Type = typeof(ParameterInfo), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal string FormatTypeName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal override string FormatTypeName(bool serialization) { }

	public abstract Assembly get_Assembly() { }

	public abstract string get_AssemblyQualifiedName() { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "GetAttributeFlagsImpl", ReturnType = typeof(TypeAttributes))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData", Member = "GetAttributes", ReturnType = "System.ComponentModel.AttributeCollection")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override TypeAttributes get_Attributes() { }

	public abstract Type get_BaseType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_ContainsGenericParameters() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override MethodBase get_DeclaringMethod() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Type get_DeclaringType() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = typeof(FormatterServices), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Binder get_DefaultBinder() { }

	public abstract string get_FullName() { }

	[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal string get_FullNameOrDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override int get_GenericParameterPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public override Type[] get_GenericTypeArguments() { }

	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_ContainsGenericParameters", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "EnsureNotByRefType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_HasElementType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal string get_InternalNameIfAvailable() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsAbstract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.JsonUtility", Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Serialization.TypeData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool), "System.Xml.Serialization.TypeData", "System.Xml.Schema.XmlSchemaPatternFacet"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlObjectFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementFactoryRegistry", Member = "RegisterUserFactories", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "RegisterCustomTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Type[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.ReflectionHelper", Member = "CheckSerializableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Unity.Properties.IPropertyBag")]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonArrayContract", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonContract", Member = "set_CreatedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonDictionaryContract", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileNewExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeTraits`1", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeUtility+TypeConstructor`1", Member = "SetImplicitConstructor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeManager", Member = "LoadBaseTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsAbstract() { }

	[CallerCount(Count = 79)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_IsArray() { }

	[CallerCount(Count = 56)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_IsByRef() { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputManager", Member = "RegisterCustomTypes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Type[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeComponent", Member = "FindParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Collections.Generic.List`1<VolumeParameter>", "System.Func`2<FieldInfo, Boolean>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "StrictHasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsClass() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool get_IsCollectible() { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "NodeFor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = "System.ComponentModel.TypeDescriptor+TypeDescriptionNode")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_IsCOMObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_IsConstructedGenericType() { }

	[CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "get_IsContextBoundObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateConstructionCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(ConstructionCall))]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(ActivationServices), Member = "CreateProxyForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemoteActivator), Member = "Activate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConstructionCallMessage)}, ReturnType = typeof(IConstructionReturnMessage))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_IsContextful() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override bool get_IsEnum() { }

	[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsExplicitLayout() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool get_IsGenericMethodParameter() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsGenericParameter() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsGenericType() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsGenericTypeDefinition() { }

	[CallerCount(Count = 61)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool get_IsInterface() { }

	[CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
	[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ClientIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ClientIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingSurrogateSelector), Member = "GetSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(StreamingContext), typeof(ISurrogateSelector&)}, ReturnType = typeof(ISerializationSurrogate))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_IsMarshalByRef() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FormatTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.TypeUtility", Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Collections.Generic.IReadOnlyList`1<Type>", typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsNested() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsNestedAssembly() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CalledBy(Type = "System.Xml.Serialization.ReflectionHelper", Member = "CheckSerializableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.ComponentModel.EventDescriptor[]")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsNestedPublic() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_MemberType", ReturnType = typeof(MemberTypes))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsNotPublic() { }

	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool get_IsPointer() { }

	[CallerCount(Count = 38)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_IsPrimitive() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_MemberType", ReturnType = typeof(MemberTypes))]
	[CalledBy(Type = "System.Xml.Serialization.ReflectionHelper", Member = "CheckSerializableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.ComponentModel.EventDescriptor[]")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsPublic() { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CalledBy(Type = typeof(NameInfo), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsSealed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonArrayContract", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonContainerContract", Member = "set_ItemContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonContract"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonContract", Member = "set_CreatedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonDictionaryContract", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "StrictHasReferenceConversionTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsSealed() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsSerializable() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsSignatureType() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool get_IsSzArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_IsSZArray() { }

	[CallerCount(Count = 114)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool get_IsValueType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsVariableBoundArray() { }

	[CalledBy(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Object[]"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "GenericArgumentsAreVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.SecurityUtils", Member = "MethodInfoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(object), "System.Object[]"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public bool get_IsVisible() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual MemberTypes get_MemberType() { }

	public abstract Module get_Module() { }

	[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal string get_NameOrDefault() { }

	public abstract string get_Namespace() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public virtual Type get_ReflectedType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override RuntimeTypeHandle get_TypeHandle() { }

	public abstract Type get_UnderlyingSystemType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override int GetArrayRank() { }

	protected abstract TypeAttributes GetAttributeFlagsImpl() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetSerializationCtor", ReturnType = typeof(RuntimeConstructorInfo))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ComVisible(True)]
	public override ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = typeof(RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = "System.Xml.Serialization.ReflectionHelper", Member = "CheckSerializableType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Type[]", "System.Object[]", typeof(bool), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "CreateISerializableContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "Newtonsoft.Json.Serialization.JsonISerializableContract")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ComVisible(True)]
	public override ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ComVisible(True)]
	public override ConstructorInfo GetConstructor(Type[] types) { }

	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetExtensionDataDelegates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonObjectContract", typeof(MemberInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "GetImmutableConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "Newtonsoft.Json.Serialization.JsonPropertyCollection"}, ReturnType = typeof(ConstructorInfo))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ComVisible(True)]
	public override ConstructorInfo[] GetConstructors() { }

	[ComVisible(True)]
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	public abstract Type GetElementType() { }

	[CalledBy(Type = typeof(Type), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumRawConstantValues", ReturnType = typeof(Array))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Comparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.Comparer`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	private void GetEnumData(out String[] enumNames, out Array enumValues) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "IsIntegerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]&), typeof(Array&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	public override string GetEnumName(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]&), typeof(Array&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public override String[] GetEnumNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]&), typeof(Array&)}, ReturnType = typeof(void))]
	private Array GetEnumRawConstantValues() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public override Type GetEnumUnderlyingType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override Array GetEnumValues() { }

	[CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillMethods", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override EventInfo GetEvent(string name) { }

	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	public abstract EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[CalledBy(Type = "System.Xml.Serialization.XmlReflectionImporter", Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", "System.Xml.Serialization.XmlRootAttribute", typeof(string)}, ReturnType = "System.Xml.Serialization.XmlTypeMapping")]
	[CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override FieldInfo GetField(string name) { }

	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override Type[] GetGenericArguments() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override Type[] GetGenericParameterConstraints() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override Type GetGenericTypeDefinition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	public abstract Type[] GetInterfaces() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(ValueFixup), Member = "Fixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord), typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DebugDisplayStats`1", Member = "GetProfilerIdsToDisplay", ReturnType = "System.Collections.Generic.List`1<TProfileId>")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MemberInfo[] GetMember(string name) { }

	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(TypeDelegator), Member = "GetMethodImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = typeof(Delegate), Member = "GetCandidateMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(string), typeof(BindingFlags), typeof(bool), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "UnityEngine.AndroidJavaProxy", Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = "UnityEngine.AndroidJavaObject")]
	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeExtensions", Member = "GetAnyStaticMethodValidated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]"}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "UnityEngine.Events.UnityEventBase", Member = "GetValidMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]"}, ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "InitMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.TypeData", Member = "get_ListItemType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(ICustomMarshaler))]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]", typeof(Type), typeof(bool)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public override MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public override MethodInfo GetMethod(string name, Type[] types) { }

	[CallerCount(Count = 49)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override MethodInfo GetMethod(string name) { }

	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ImmutableCollectionsUtils", Member = "TryBuildImmutableForArrayContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type&), "Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ImmutableCollectionsUtils", Member = "TryBuildImmutableForDictionaryContract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type), typeof(Type&), "Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MethodInfo[] GetMethods() { }

	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	public abstract Type GetNestedType(string name, BindingFlags bindingAttr) { }

	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(TypeDelegator), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "FillAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetMemberInfoFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MemberInfo)}, ReturnType = typeof(MemberInfo))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetExtensionDataDelegates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonObjectContract", typeof(MemberInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override PropertyInfo GetProperty(string name, Type returnType) { }

	[CalledBy(Type = "System.Xml.Serialization.TypeData", Member = "get_ListItemType", ReturnType = typeof(Type))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationWriterInterpreter", Member = "WriteListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.XmlTypeMapping", typeof(object), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationWriterInterpreter", Member = "WriteListContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Xml.Serialization.TypeData", "System.Xml.Serialization.ListMap", typeof(object), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlSerializationWriterInterpreter", Member = "GetListCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Serialization.TypeData", typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Runtime.CompilerServices.CallSiteBinder", Member = "Stitch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", "System.Runtime.CompilerServices.CallSiteBinder+LambdaSignature`1<T>"}, ReturnType = "System.Linq.Expressions.Expression`1<T>")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override PropertyInfo GetProperty(string name) { }

	[CalledBy(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
	[CalledBy(Type = typeof(DependencyInjector), Member = "ReflectionLoad", ReturnType = typeof(ISystemDependencyProvider))]
	[CalledBy(Type = typeof(TypeDelegator), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(TypeInfo), Member = "GetDeclaredProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "get_MemberInfo", ReturnType = typeof(MemberInfo))]
	[CalledBy(Type = "UnityEngine.Rendering.SceneExtensions", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.VolumeComponent", Member = "SetOverridesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<VolumeParameter>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetIsSpecifiedActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataColumn", Member = "get_DefaultValue", ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.SqlUdtStorage+<>c__DisplayClass6_0", Member = "<GetStaticNullForUdtType>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "Property", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = "System.Linq.Expressions.MemberExpression")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FormatTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_FullName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal Type GetRootElementType() { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	public override Type GetType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	public static Type GetType(string typeName, bool throwOnError) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "GetSimplyNamedTypeFromAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(string), typeof(Type&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeNameParser), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	public static Type GetType(string typeName) { }

	[CallerCount(Count = 37)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static TypeCode GetTypeCode(Type type) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	protected override TypeCode GetTypeCodeImpl() { }

	[CallerCount(Count = 4641)]
	[CallsUnknownMethods(Count = 1)]
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	protected abstract bool HasElementTypeImpl() { }

	[CalledBy(Type = typeof(Type), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal bool ImplementInterface(Type ifaceType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Type internal_from_handle(IntPtr handle) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal override string InternalGetNameIfAvailable(ref Type rootCauseForFailure) { }

	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	protected abstract bool IsArrayImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "ImplementInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public override bool IsAssignableFrom(Type c) { }

	protected abstract bool IsByRefImpl() { }

	protected abstract bool IsCOMObjectImpl() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override bool IsContextfulImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "IsIntegerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetEnumData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]&), typeof(Array&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 39)]
	[ContainsUnimplementedInstructions]
	public override bool IsEnumDefined(object value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool IsEquivalentTo(Type other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool IsInstanceOfType(object o) { }

	[CalledBy(Type = typeof(Type), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeType), Member = "IsEnumDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEnumName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static bool IsIntegerType(Type t) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override bool IsMarshalByRefImpl() { }

	protected abstract bool IsPointerImpl() { }

	protected abstract bool IsPrimitiveImpl() { }

	[CalledBy(Type = typeof(Type), Member = "get_IsSerializable", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Type), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(Pointer), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsRuntimeImplemented() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ComVisible(True)]
	public override bool IsSubclassOf(Type c) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override bool IsValueTypeImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override Type MakeArrayType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override Type MakeArrayType(int rank) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override Type MakeByRefType() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "MakeGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SignatureConstructedGenericType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[])}, ReturnType = typeof(void))]
	public static Type MakeGenericSignatureType(Type genericTypeDefinition, Type[] typeArguments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override Type MakeGenericType(Type[] typeArguments) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override Type MakePointerType() { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Type left, Type right) { }

	[CallerCount(Count = 544)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(Type left, Type right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

}

