namespace UnityEngine.Rendering;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(SerializedDictionaryDebugView`2))]
public class SerializedDictionary : SerializedDictionary<K, V, K, V>
{

	[CalledBy(Type = typeof(ProbeVolumeBakingSet), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProbeVolumeStreamableAsset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UnityEngine.Rendering.SerializedDictionary`2<System.Int32, UnityEngine.Rendering.ProbeVolumeStreamableAsset+StreamableCellDesc>), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public SerializedDictionary`2() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual K DeserializeKey(K key) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual V DeserializeValue(V val) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual K SerializeKey(K key) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual V SerializeValue(V val) { }

}

