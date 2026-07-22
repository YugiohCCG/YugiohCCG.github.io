namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UxmlAsset : IUxmlAttributes
{
	public const string NullNodeType = "null"; //Field offset: 0x0
	[SerializeField]
	private string m_FullTypeName; //Field offset: 0x10
	[SerializeField]
	private UxmlNamespaceDefinition m_XmlNamespace; //Field offset: 0x18
	[SerializeField]
	private int m_Id; //Field offset: 0x28
	[SerializeField]
	private int m_OrderInDocument; //Field offset: 0x2C
	[SerializeField]
	private int m_ParentId; //Field offset: 0x30
	[SerializeField]
	private List<UxmlNamespaceDefinition> m_NamespaceDefinitions; //Field offset: 0x38
	[SerializeField]
	protected List<String> m_Properties; //Field offset: 0x40

	public string fullTypeName
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int id
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int orderInDocument
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int parentId
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public UxmlAsset(string fullTypeName, UxmlNamespaceDefinition xmlNamespace = null) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_fullTypeName() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_id() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_orderInDocument() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public int get_parentId() { }

	[CalledBy(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBagAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(String&), typeof(VisualTreeAsset&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveAttribute(string attributeName) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_id(int value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public void set_parentId(int value) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void SetAttribute(string name, string value) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void SetOrAddProperty(string propertyName, string propertyValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public override bool TryGetAttributeValue(string propertyName, out string value) { }

}

