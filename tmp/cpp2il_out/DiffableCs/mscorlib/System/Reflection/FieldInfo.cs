namespace System.Reflection;

public abstract class FieldInfo : MemberInfo
{

	public abstract FieldAttributes Attributes
	{
		 get { } //Length: 0
	}

	public abstract RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 0
	}

	public abstract Type FieldType
	{
		 get { } //Length: 0
	}

	public override bool IsInitOnly
	{
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Properties.FieldMember", Member = "get_IsReadOnly", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 30
	}

	public override bool IsLiteral
	{
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), "System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 30
	}

	public override bool IsNotSerialized
	{
		[CalledBy(Type = typeof(FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(MemberInfo[]))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 33
	}

	public override bool IsPrivate
	{
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils+<>c", Member = "<GetChildPrivateFields>b__41_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 32
	}

	public override bool IsPublic
	{
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanReadMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 33
	}

	public override bool IsStatic
	{
		[CalledBy(Type = typeof(TypedReference), Member = "MakeTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FieldInfo[])}, ReturnType = typeof(TypedReference))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
		[CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(ICollection), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "GetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.Collections.Generic.List`1<MemberInfo>")]
		[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(FieldInfo)}, ReturnType = "System.Linq.Expressions.MemberExpression")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.InstructionList", Member = "GetLoadField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = "System.Linq.Expressions.Interpreter.Instruction")]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.InstructionList", Member = "EmitStoreField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), "System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "IsValidMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 12)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 30
	}

	public virtual MemberTypes MemberType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected FieldInfo() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Equals(object obj) { }

	public abstract FieldAttributes get_Attributes() { }

	public abstract RuntimeFieldHandle get_FieldHandle() { }

	public abstract Type get_FieldType() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.FieldMember", Member = "get_IsReadOnly", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsInitOnly() { }

	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "RequiresCanWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), "System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(int)}, ReturnType = "System.Linq.Expressions.Interpreter.ByRefUpdater")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsLiteral() { }

	[CalledBy(Type = typeof(FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsNotSerialized() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils+<>c", Member = "<GetChildPrivateFields>b__41_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsPrivate() { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanReadMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "CanSetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider+<GetPropertyMembers>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsPublic() { }

	[CalledBy(Type = typeof(TypedReference), Member = "MakeTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FieldInfo[])}, ReturnType = typeof(TypedReference))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Attribute))]
	[CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(ICollection), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "GetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.Collections.Generic.List`1<MemberInfo>")]
	[CalledBy(Type = "System.Linq.Expressions.Expression", Member = "Field", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(FieldInfo)}, ReturnType = "System.Linq.Expressions.MemberExpression")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.InstructionList", Member = "GetLoadField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = "System.Linq.Expressions.Interpreter.Instruction")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.InstructionList", Member = "EmitStoreField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMemberAssignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(MemberInfo), "System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(MemberInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.ReflectedPropertyBagProvider", Member = "IsValidMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsStatic() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private MarshalAsAttribute get_marshal_info() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual MemberTypes get_MemberType() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ComVisible(False)]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	[CalledBy(Type = typeof(RuntimeFieldHandle), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal override int GetFieldOffset() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsExplicitLayout", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	internal Object[] GetPseudoCustomAttributes() { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsExplicitLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(ConstructorInfo))]
	[Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 28)]
	[ContainsUnimplementedInstructions]
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override object GetRawConstantValue() { }

	public abstract object GetValue(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	[CallerCount(Count = 264)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	[CallerCount(Count = 165)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "SetValueSpecified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.StoreStaticFieldInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.StoreFieldInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "SetMemberValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory+<>c__DisplayClass8_0`1", Member = "<CreateSet>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMemberElement", Member = "SetChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.FieldByRefUpdater", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.NamedValue", Member = "ApplyToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBindingResolver", Member = "AssignCompositePartIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputBindingResolver", Member = "ApplyParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<NamedValue>", typeof(object), "UnityEngine.InputSystem.InputActionMap", "UnityEngine.InputSystem.InputBinding&", typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionRebindingExtensions", Member = "ApplyParameterOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputActionState", typeof(int), "ParameterOverride[]&", typeof(Int32&), "UnityEngine.InputSystem.InputActionRebindingExtensions+ParameterOverride"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(IntPtr), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Serialization.XmlTypeMapMember", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.FieldMember", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public override void SetValue(object obj, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	public override void SetValueDirect(TypedReference obj, object value) { }

}

