namespace UnityEngine.Rendering;

internal sealed class SerializedDictionaryDebugView
{
	private IDictionary<K, V> dict; //Field offset: 0x0

	[DebuggerBrowsable(DebuggerBrowsableState::RootHidden (3))]
	public KeyValuePair<K, V>[] Items
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 399
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public SerializedDictionaryDebugView`2(IDictionary<K, V> dictionary) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public KeyValuePair<K, V>[] get_Items() { }

}

