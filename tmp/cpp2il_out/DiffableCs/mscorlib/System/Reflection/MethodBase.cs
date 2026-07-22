namespace System.Reflection;

public abstract class MethodBase : MemberInfo
{

	public abstract MethodAttributes Attributes
	{
		 get { } //Length: 0
	}

	public override CallingConventions CallingConvention
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public override bool ContainsGenericParameters
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsAbstract
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 33
	}

	public override bool IsConstructor
	{
		[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(CADMethodRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Dynamic.Utils.TypeExtensions", Member = "GetReturnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(Type))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		 get { } //Length: 144
	}

	public override bool IsGenericMethod
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsGenericMethodDefinition
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override bool IsPublic
	{
		[CalledBy(Type = "SQLite.TableMapping+<>c__DisplayClass31_0", Member = "<.ctor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
		[CalledBy(Type = "System.SecurityUtils", Member = "MethodInfoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(object), "System.Object[]"}, ReturnType = typeof(object))]
		[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.IExtenderProvider"}, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionObject", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodBase), "System.String[]"}, ReturnType = "Newtonsoft.Json.Utilities.ReflectionObject")]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsPublic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]", "System.Linq.Expressions.Expression[]", typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 33
	}

	public override bool IsSecurityCritical
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public override bool IsSpecialName
	{
		[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 33
	}

	public override bool IsStatic
	{
		[CallerCount(Count = 39)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 30
	}

	public override bool IsVirtual
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
		[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsVirtual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "IsValidCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), "System.Reflection.ParameterInfo[]", typeof(Type), typeof(MethodInfo), typeof(Type&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 30
	}

	public abstract RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected MethodBase() { }

	[CalledBy(Type = typeof(MethodBase), Member = "FormatNameAndSig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(MethodBase), Member = "ConstructParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[]), typeof(CallingConventions), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	internal override string FormatNameAndSig(bool serialization) { }

	public abstract MethodAttributes get_Attributes() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public override CallingConventions get_CallingConvention() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_ContainsGenericParameters() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsAbstract() { }

	[CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RealProxy), typeof(IMessage), typeof(Exception&), typeof(Object[]&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CADMethodRef), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Dynamic.Utils.TypeExtensions", Member = "GetReturnType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool get_IsConstructor() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsGenericMethod() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public override bool get_IsGenericMethodDefinition() { }

	[CalledBy(Type = "SQLite.TableMapping+<>c__DisplayClass31_0", Member = "<.ctor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
	[CalledBy(Type = "System.SecurityUtils", Member = "MethodInfoInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), typeof(object), "System.Object[]"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetExtendedProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.IExtenderProvider"}, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionObject", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodBase), "System.String[]"}, ReturnType = "Newtonsoft.Json.Utilities.ReflectionObject")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsPublic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "FindMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), "System.Type[]", "System.Linq.Expressions.Expression[]", typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsPublic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override bool get_IsSecurityCritical() { }

	[CalledBy(Type = "System.Dynamic.Utils.TypeUtils", Member = "GetBooleanOperator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsSpecialName() { }

	[CallerCount(Count = 39)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsStatic() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyInfo)}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventInfo)}, ReturnType = typeof(EventInfo))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider)}, ReturnType = typeof(ICustomAttributeProvider))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsVirtual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "IsValidCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodInfo), "System.Reflection.ParameterInfo[]", typeof(Type), typeof(MethodInfo), typeof(Type&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsVirtual() { }

	public abstract RuntimeMethodHandle get_MethodHandle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override Type[] GetGenericArguments() { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(RuntimeMethodHandle), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "CompileILPPMethod2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "GetILPPMethodFunctionPointer2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(RuntimeMethodHandle), typeof(RuntimeTypeHandle)}, ReturnType = "System.Void*")]
	[CalledBy(Type = "Unity.Burst.BurstCompiler", Member = "<GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate&), typeof(GCHandle&), "<>c__DisplayClass17_0&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	public abstract MethodImplAttributes GetMethodImplementationFlags() { }

	public abstract ParameterInfo[] GetParameters() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal override int GetParametersCount() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal override ParameterInfo[] GetParametersInternal() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal override ParameterInfo[] GetParametersNoCopy() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	internal override Type[] GetParameterTypes() { }

	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public override object Invoke(object obj, Object[] parameters) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractFormattedStackTrace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StackTrace)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StackFrame), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(MethodResponse), Member = "get_MethodBase", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(MethodCall), Member = "get_GenericArguments", ReturnType = typeof(Type[]))]
	[CalledBy(Type = typeof(MethodCall), Member = "get_MethodBase", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	[CalledBy(Type = typeof(Type), Member = "get_IsGenericMethodParameter", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Exception), Member = "get_Source", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(Type[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(MethodCall), Member = "get_MethodSignature", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_MethodName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_MethodSignature", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ReturnMessage), Member = "get_TypeName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "init_frames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionObject", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodBase), "System.String[]"}, ReturnType = "Newtonsoft.Json.Utilities.ReflectionObject")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

}

