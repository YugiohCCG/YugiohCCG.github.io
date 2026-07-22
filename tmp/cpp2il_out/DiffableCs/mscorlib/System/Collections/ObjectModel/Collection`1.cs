namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
public class Collection : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private IList<T> items; //Field offset: 0x0

	public override int Count
	{
		[CallerCount(Count = 25)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 70
	}

	public override T Item
	{
		[CallerCount(Count = 40)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 84
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 204
	}

	protected IList<T> Items
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 73
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 92
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		private get { } //Length: 167
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 73
	}

	private override object System.Collections.IList.Item
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		private get { } //Length: 127
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		[DeduplicatedMethod]
		private set { } //Length: 437
	}

	[CalledBy(Type = "System.Net.NetworkInformation.IPAddressCollection", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IIdentity), typeof(System.Collections.Generic.IEnumerable`1<System.Security.Claims.Claim>), typeof(string), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClaimsIdentity)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClaimsIdentity), Member = "OnDeserializingMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.ProcessStartInfo", Member = "get_ArgumentList", ReturnType = "System.Collections.ObjectModel.Collection`1<String>")]
	[CalledBy(Type = "System.Collections.ObjectModel.ObservableCollection`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.GatewayIPAddressInformationCollection", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.Win32IPInterfaceProperties2", Member = "get_GatewayAddresses", ReturnType = "System.Net.NetworkInformation.GatewayIPAddressInformationCollection")]
	[CalledBy(Type = "Newtonsoft.Json.JsonConverterCollection", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonSerializer", Member = "get_Converters", ReturnType = "Newtonsoft.Json.JsonConverterCollection")]
	[CalledBy(Type = "ZXing.Aztec.Internal.HighLevelEncoder", Member = "encode", ReturnType = "ZXing.Common.BitArray")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public Collection`1() { }

	[CallerCount(Count = 25)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Collection`1(IList<T> list) { }

	[CalledBy(Type = "Game.Duel+<OverlayCard>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override void Add(T item) { }

	[CalledBy(Type = "Game.DuelManager+<OnSummoned>d__202", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChainEnd>d__142", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChainSolved>d__104", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChaining>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnMove>d__133", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnNewPhase>d__127", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoning>d__203", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSummoning>d__199", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnTagSwap>d__125", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager", Member = "ClearTargeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.ClientCard"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard", Member = "ClearCardTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void Clear() { }

	[CalledBy(Type = typeof(KeyedCollection`2), Member = "ClearItems", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.ObjectModel.ObservableCollection`1", Member = "ClearItems", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = "ClearItems", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected override void ClearItems() { }

	[CalledBy(Type = "Card.ClientCard", Member = "HasXyzMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override bool Contains(T item) { }

	[CalledBy(Type = "System.Net.NetworkInformation.GatewayIPAddressInformationCollection", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.NetworkInformation.GatewayIPAddressInformation[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.IPAddressCollection", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.IPAddress[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.NetworkInformation.UnicastIPAddressInformation[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void CopyTo(T[] array, int index) { }

	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override int get_Count() { }

	[CallerCount(Count = 40)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override T get_Item(int index) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected IList<T> get_Items() { }

	[CalledBy(Type = "Card.ClientCard", Member = "ClearCardTargets", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchemaGenerator", Member = "GenerateObjectSchema", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "Newtonsoft.Json.Serialization.JsonObjectContract"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", "Newtonsoft.Json.Serialization.JsonObjectContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>", typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonObjectContract", Member = "get_HasRequiredOrDefaultValueProperties", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<UnicastIPAddressInformation>")]
	[CalledBy(Type = "System.Net.NetworkInformation.IPAddressCollection", Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<IPAddress>")]
	[CalledBy(Type = "System.Net.NetworkInformation.GatewayIPAddressInformationCollection", Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<GatewayIPAddressInformation>")]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject+<GetEnumerator>d__64", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Card.ClientCard", Member = "RefreshTargetInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard", Member = "set_ShowLevelInHand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSummoned>d__202", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnSpSummoned>d__204", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnShuffleDeck>d__115", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChainSolved>d__104", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnChainEnd>d__142", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.DuelManager+<OnBecomeTarget>d__146", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.ClientCard", Member = "ClearTargetingIcons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<String, JToken>[]", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 27)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override IEnumerator<T> GetEnumerator() { }

	[CalledBy(Type = "Game.Duel", Member = "DetachCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.ClientCard", typeof(int)}, ReturnType = "Card.ClientCard")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override int IndexOf(T item) { }

	[CalledBy(Type = "Card.ClientCard", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override void Insert(int index, T item) { }

	[CalledBy(Type = "System.Collections.ObjectModel.ObservableCollection`1", Member = "InsertItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected override void InsertItem(int index, T item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static bool IsCompatibleObject(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override bool Remove(T item) { }

	[CalledBy(Type = "Game.Duel+<OverlayCard>d__47", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.Duel", Member = "DetachCard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Card.ClientCard", typeof(int)}, ReturnType = "Card.ClientCard")]
	[CalledBy(Type = "Card.ClientCard", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BinaryReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override void RemoveAt(int index) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected override void RemoveItem(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override void set_Item(int index, T value) { }

	[CalledBy(Type = "System.Collections.ObjectModel.ObservableCollection`1", Member = "SetItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected override void SetItem(int index, T item) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	[DeduplicatedMethod]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[DeduplicatedMethod]
	private override int System.Collections.IList.Add(object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.Contains(object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private override object System.Collections.IList.get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	private override int System.Collections.IList.IndexOf(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	private override void System.Collections.IList.Remove(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "IfNullAndNullsAreIllegalThenThrow", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

