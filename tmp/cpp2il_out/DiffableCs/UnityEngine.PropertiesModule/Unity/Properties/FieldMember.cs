namespace Unity.Properties;

[IsReadOnly]
internal struct FieldMember : IMemberInfo
{
	internal readonly FieldInfo m_FieldInfo; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <Name>k__BackingField; //Field offset: 0x8

	public override bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldInfo), Member = "get_IsInitOnly", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 28
	}

	public override string Name
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public override Type ValueType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 38
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReflectionUtilities), Member = "SanitizeMemberName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public FieldMember(FieldInfo fieldInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsInitOnly", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public override string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Attribute>))]
	[DeduplicatedMethod]
	public override IEnumerable<Attribute> GetCustomAttributes() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override object GetValue(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void SetValue(object obj, object value) { }

}

