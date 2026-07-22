namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
[NullableContext(1)]
internal class JPropertyKeyedCollection : Collection<JToken>
{
	private static readonly IEqualityComparer<String> Comparer; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	private Dictionary<String, JToken> _dictionary; //Field offset: 0x18

	public JToken Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		 get { } //Length: 229
	}

	public ICollection<String> Keys
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 78
	}

	public ICollection<JToken> Values
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static JPropertyKeyedCollection() { }

	[CalledBy(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JObject), typeof(JsonCloneSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JObject), Member = "CloneToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonCloneSettings)}, ReturnType = typeof(JToken))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	public JPropertyKeyedCollection() { }

	[CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "ChangeItemKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void AddKey(string key, JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "RemoveKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	protected void ChangeItemKey(JToken item, string newKey) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collection`1), Member = "ClearItems", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	protected virtual void ClearItems() { }

	[CalledBy(Type = typeof(JObject), Member = "DeepEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	public bool Compare(JPropertyKeyedCollection other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public bool Contains(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	private bool ContainsItem(JToken item) { }

	[CalledBy(Type = typeof(JObject), Member = "System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys", ReturnType = typeof(System.Collections.Generic.ICollection`1<System.String>))]
	[CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "AddKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "get_Keys", ReturnType = typeof(System.Collections.Generic.ICollection`1<System.String>))]
	[CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "get_Values", ReturnType = typeof(System.Collections.Generic.ICollection`1<Newtonsoft.Json.Linq.JToken>))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void EnsureDictionary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public JToken get_Item(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ICollection<String> get_Keys() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ICollection<JToken> get_Values() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private string GetKeyForItem(JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CollectionUtils), Member = "IndexOfReference", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", "T"}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public int IndexOfReference(JToken t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void InsertItem(int index, JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public bool Remove(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void RemoveItem(int index) { }

	[CalledBy(Type = typeof(JPropertyKeyedCollection), Member = "ChangeItemKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JToken), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	private void RemoveKey(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JPropertyKeyedCollection), Member = "EnsureDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.ObjectModel.Collection`1<System.Object>), Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	protected virtual void SetItem(int index, JToken item) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public bool TryGetValue(string key, out JToken value) { }

}

