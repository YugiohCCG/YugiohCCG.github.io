namespace System.Runtime.Serialization;

public sealed class SafeSerializationEventArgs : EventArgs
{
	private StreamingContext m_streamingContext; //Field offset: 0x10
	private List<Object> m_serializedStates; //Field offset: 0x20

	internal IList<Object> SerializedStates
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal SafeSerializationEventArgs(StreamingContext streamingContext) { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal IList<Object> get_SerializedStates() { }

}

