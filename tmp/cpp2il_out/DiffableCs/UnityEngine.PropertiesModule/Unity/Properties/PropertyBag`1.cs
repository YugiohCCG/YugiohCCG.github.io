namespace Unity.Properties;

public abstract class PropertyBag : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; //Field offset: 0x0

	protected override InstantiationKind InstantiationKind
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	private override InstantiationKind Unity.Properties.IConstructor.InstantiationKind
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 17
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeTraits), Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private static PropertyBag`1() { }

	[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IndexedCollectionPropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected PropertyBag`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override void Accept(ITypeVisitor visitor) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected override InstantiationKind get_InstantiationKind() { }

	public abstract PropertyCollection<TContainer> GetProperties() { }

	public abstract PropertyCollection<TContainer> GetProperties(ref TContainer container) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override TContainer Instantiate() { }

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBagStore), Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyBag), Member = "AcceptWithSpecializedVisitor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", typeof(IPropertyBagVisitor), "TContainer&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	private override void Unity.Properties.IPropertyBag.Accept(IPropertyBagVisitor visitor, ref object container) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override void Unity.Properties.IPropertyBag<TContainer>.Accept(IPropertyBagVisitor visitor, ref TContainer container) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties(ref TContainer container) { }

}

