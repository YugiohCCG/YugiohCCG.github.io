namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class TemplateAsset : VisualElementAsset
{
	internal struct AttributeOverride
	{
		public string m_ElementName; //Field offset: 0x0
		public String[] m_NamesPath; //Field offset: 0x8
		public string m_AttributeName; //Field offset: 0x10
		public string m_Value; //Field offset: 0x18

		[CalledBy(Type = typeof(UxmlAttributeDescription), Member = "TryFindValueInAttributeOverrides", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CreationContext), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TemplateAsset+AttributeOverride>), typeof(String&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		public bool NamesPathMatchesElementNamesPath(IList<String> elementNamesPath) { }

	}

	internal struct UxmlSerializedDataOverride
	{
		public int m_ElementId; //Field offset: 0x0
		public List<Int32> m_ElementIdsPath; //Field offset: 0x8
		[SerializeReference]
		public UxmlSerializedData m_SerializedData; //Field offset: 0x10

	}

	[SerializeField]
	private string m_TemplateAlias; //Field offset: 0x90
	[SerializeField]
	private List<AttributeOverride> m_AttributeOverrides; //Field offset: 0x98
	[SerializeField]
	private List<UxmlSerializedDataOverride> m_SerializedDataOverride; //Field offset: 0xA0
	[SerializeField]
	private List<SlotUsageEntry> m_SlotUsages; //Field offset: 0xA8

	public List<AttributeOverride> attributeOverrides
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public List<UxmlSerializedDataOverride> serializedDataOverrides
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<SlotUsageEntry> slotUsages
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 10
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public List<AttributeOverride> get_attributeOverrides() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public List<UxmlSerializedDataOverride> get_serializedDataOverrides() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<SlotUsageEntry> get_slotUsages() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(CreationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.String, UnityEngine.UIElements.VisualElement>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>), typeof(VisualTreeAsset), typeof(VisualElement), typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.Collections.Generic.List`1<System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializedDataOverrideRange), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TemplateAsset+UxmlSerializedDataOverride>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.CreationContext+SerializedDataOverrideRange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Label), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "ResolveTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(VisualTreeAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElementAsset), Member = "Instantiate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreationContext)}, ReturnType = typeof(VisualElement))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.CreationContext+AttributeOverrideRange>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 18)]
	internal virtual VisualElement Instantiate(CreationContext cc) { }

}

