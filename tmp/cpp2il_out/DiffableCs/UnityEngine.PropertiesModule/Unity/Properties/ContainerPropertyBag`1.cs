namespace Unity.Properties;

public abstract class ContainerPropertyBag : PropertyBag<TContainer>, INamedProperties<TContainer>
{
	private readonly List<IProperty`1<TContainer>> m_PropertiesList; //Field offset: 0x0
	private readonly Dictionary<String, IProperty`1<TContainer>> m_PropertiesHash; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeTraits), Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private static ContainerPropertyBag`1() { }

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	protected ContainerPropertyBag`1() { }

	[CallerCount(Count = 106)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected void AddProperty(Property<TContainer, TValue> property) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual PropertyCollection<TContainer> GetProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public virtual PropertyCollection<TContainer> GetProperties(ref TContainer container) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer>& property) { }

}

