namespace System.Reflection;

public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo
{
	private const int MetadataToken_ParamDef = 134217728; //Field offset: 0x0
	protected ParameterAttributes AttrsImpl; //Field offset: 0x10
	protected Type ClassImpl; //Field offset: 0x18
	protected object DefaultValueImpl; //Field offset: 0x20
	protected MemberInfo MemberImpl; //Field offset: 0x28
	protected string NameImpl; //Field offset: 0x30
	protected int PositionImpl; //Field offset: 0x38

	public override ParameterAttributes Attributes
	{
		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public override object DefaultValue
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public bool IsIn
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 27
	}

	public bool IsOptional
	{
		[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 30
	}

	public bool IsOut
	{
		[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
		[CalledBy(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage), typeof(MonoMethodMessage)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ArgInfoType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(Object[])}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 30
	}

	public override MemberInfo Member
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override string Name
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override Type ParameterType
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override int Position
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected ParameterInfo() { }

	[CallerCount(Count = 94)]
	[DeduplicatedMethod]
	public override ParameterAttributes get_Attributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override object get_DefaultValue() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool get_IsIn() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsOptional() { }

	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CalledBy(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMethodReturnMessage), typeof(MonoMethodMessage)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(ArgInfoType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(Object[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_IsOut() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public override MemberInfo get_Member() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public override string get_Name() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public override Type get_ParameterType() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public override int get_Position() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Object[] GetCustomAttributes(bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 25)]
	public override object GetRealObject(StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "FormatTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

