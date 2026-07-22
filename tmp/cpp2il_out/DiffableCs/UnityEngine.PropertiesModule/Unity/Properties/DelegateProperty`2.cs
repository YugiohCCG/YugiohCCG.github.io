namespace Unity.Properties;

public class DelegateProperty : Property<TContainer, TValue>
{
	private readonly PropertyGetter<TContainer, TValue> m_Getter; //Field offset: 0x0
	private readonly PropertySetter<TContainer, TValue> m_Setter; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <Name>k__BackingField; //Field offset: 0x0

	public virtual bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	public virtual string Name
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public DelegateProperty`2(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter = null) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool get_IsReadOnly() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public virtual TValue GetValue(ref TContainer container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public virtual void SetValue(ref TContainer container, TValue value) { }

}

