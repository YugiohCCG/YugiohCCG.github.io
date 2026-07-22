namespace Unity.Properties;

public abstract class Property : IProperty<TContainer>, IProperty, IPropertyAccept<TContainer>, IAttributes
{
	private List<Attribute> m_Attributes; //Field offset: 0x0

	public abstract bool IsReadOnly
	{
		 get { } //Length: 0
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	private override List<Attribute> Unity.Properties.Internal.IAttributes.Attributes
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		private get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Property`2() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Accept(IPropertyVisitor visitor, ref TContainer container) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected void AddAttribute(Attribute attribute) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected void AddAttributes(IEnumerable<Attribute> attributes) { }

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[DeduplicatedMethod]
	public override Type DeclaredValueType() { }

	public abstract bool get_IsReadOnly() { }

	public abstract string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override TAttribute GetAttribute() { }

	public abstract TValue GetValue(ref TContainer container) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool HasAttribute() { }

	public abstract void SetValue(ref TContainer container, TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private override void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttributesScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttributes), typeof(System.Collections.Generic.List`1<System.Attribute>)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override AttributesScope Unity.Properties.Internal.IAttributes.CreateAttributesScope(IAttributes attributes) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	private override List<Attribute> Unity.Properties.Internal.IAttributes.get_Attributes() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override void Unity.Properties.Internal.IAttributes.set_Attributes(List<Attribute> value) { }

}

