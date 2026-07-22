namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
[DefaultMember("Item")]
public abstract class KeyedCollection : Collection<TItem>
{
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
	private Dictionary<TKey, TItem> dict; //Field offset: 0x0
	private int keyCount; //Field offset: 0x0
	private readonly int threshold; //Field offset: 0x0

	protected IDictionary<TKey, TItem> Dictionary
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public TItem Item
	{
		[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = "AddProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaModelBuilder", Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaNode", "Newtonsoft.Json.Schema.JsonSchema"}, ReturnType = "Newtonsoft.Json.Schema.JsonSchemaNode")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(KeyedCollection`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TItem&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 181
	}

	private List<TItem> Items
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 134
	}

	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaModelBuilder", Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchema"}, ReturnType = "Newtonsoft.Json.Schema.JsonSchemaModel")]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaModelBuilder", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaNodeCollection", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected KeyedCollection`2() { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected KeyedCollection`2(IEqualityComparer<TKey> comparer) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	protected KeyedCollection`2(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyedCollection`2), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KeyedCollection`2), Member = "CreateDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	private void AddKey(TKey key, TItem item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection`1), Member = "ClearItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void ClearItems() { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", "System.Dynamic.IDynamicMetaObjectProvider", "Newtonsoft.Json.Serialization.JsonDynamicContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyedCollection`2), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TItem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = "AddProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.Serialization.JsonObjectContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "WriteObjectStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.Serialization.JsonContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "HasCreatorParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "WriteStartArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.Serialization.JsonArrayContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeISerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(ISerializable), "Newtonsoft.Json.Serialization.JsonISerializableContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeDictionary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(IDictionary), "Newtonsoft.Json.Serialization.JsonDictionaryContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaModelBuilder", Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaNode", "Newtonsoft.Json.Schema.JsonSchema"}, ReturnType = "Newtonsoft.Json.Schema.JsonSchemaNode")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	[DeduplicatedMethod]
	public bool Contains(TKey key) { }

	[CalledBy(Type = typeof(KeyedCollection`2), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TItem"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private void CreateDictionary() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	protected IDictionary<TKey, TItem> get_Dictionary() { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = "AddProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaModelBuilder", Member = "AddSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Schema.JsonSchemaNode", "Newtonsoft.Json.Schema.JsonSchema"}, ReturnType = "Newtonsoft.Json.Schema.JsonSchemaNode")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(KeyedCollection`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TItem&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public TItem get_Item(TKey key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private List<TItem> get_Items() { }

	protected abstract TKey GetKeyForItem(TItem item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void InsertItem(int index, TItem item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected virtual void RemoveItem(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private void RemoveKey(TKey key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	protected virtual void SetItem(int index, TItem item) { }

	[CalledBy(Type = typeof(KeyedCollection`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public bool TryGetValue(TKey key, out TItem item) { }

}

