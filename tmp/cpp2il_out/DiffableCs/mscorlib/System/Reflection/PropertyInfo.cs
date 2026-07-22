namespace System.Reflection;

public abstract class PropertyInfo : MemberInfo
{

	public abstract bool CanRead
	{
		 get { } //Length: 0
	}

	public abstract bool CanWrite
	{
		 get { } //Length: 0
	}

	public override MethodInfo GetMethod
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 19
	}

	public virtual MemberTypes MemberType
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public abstract Type PropertyType
	{
		 get { } //Length: 0
	}

	public override MethodInfo SetMethod
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 19
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected PropertyInfo() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	public abstract bool get_CanRead() { }

	public abstract bool get_CanWrite() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MethodInfo get_GetMethod() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public virtual MemberTypes get_MemberType() { }

	public abstract Type get_PropertyType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MethodInfo get_SetMethod() { }

	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
	[CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(ICollection), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsPublic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MethodInfo GetGetMethod() { }

	public abstract MethodInfo GetGetMethod(bool nonPublic) { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	public abstract ParameterInfo[] GetIndexParameters() { }

	[CalledBy(Type = "SQLite.FastColumnSetter", Member = "CreateNullableTypedSetterDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", "ColumnMemberType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.TableMapping+Column", "System.Func`3<IntPtr, Int32, ColumnMemberType>"}, ReturnType = "System.Action`3<ObjectType, IntPtr, Int32>")]
	[CalledBy(Type = "SQLite.FastColumnSetter", Member = "CreateTypedSetterDelegate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"ObjectType", "ColumnMemberType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SQLite.TableMapping+Column", "System.Func`3<IntPtr, Int32, ColumnMemberType>"}, ReturnType = "System.Action`3<ObjectType, IntPtr, Int32>")]
	[CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
	[CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsPublic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetExtensionDataDelegates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonObjectContract", typeof(MemberInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override MethodInfo GetSetMethod() { }

	public abstract MethodInfo GetSetMethod(bool nonPublic) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	public override object GetValue(object obj, Object[] index) { }

	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	[CalledBy(Type = typeof(DependencyInjector), Member = "get_SystemProvider", ReturnType = typeof(ISystemDependencyProvider))]
	[CalledBy(Type = typeof(DependencyInjector), Member = "ReflectionLoad", ReturnType = typeof(ISystemDependencyProvider))]
	[CalledBy(Type = "UnityEngine.Rendering.SceneExtensions", Member = "GetGUID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.SceneManagement.Scene"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.PropertyMember", Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public object GetValue(object obj) { }

	[CallerCount(Count = 264)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	[CallerCount(Count = 165)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	[CalledBy(Type = "SQLite.TableMapping+Column", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.PropertyByRefUpdater", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.PropertyMember", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public void SetValue(object obj, object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public override void SetValue(object obj, object value, Object[] index) { }

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

}

