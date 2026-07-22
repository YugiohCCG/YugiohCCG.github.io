namespace Unity.Collections;

[DebuggerDisplay("Key = {Key}, Value = {Value}")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
public struct KVPair
{
	internal HashMapHelper<TKey>* m_Data; //Field offset: 0x0
	internal int m_Index; //Field offset: 0x0
	internal int m_Next; //Field offset: 0x0

	public TKey Key
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 46
	}

	public static KVPair<TKey, TValue> Null
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public TValue Value
	{
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TKey get_Key() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static KVPair<TKey, TValue> get_Null() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public TValue get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public bool GetKeyValue(out TKey key, out TValue value) { }

}

