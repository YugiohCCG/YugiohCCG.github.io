namespace System.Runtime.Serialization;

[ComVisible(True)]
[IsReadOnly]
public struct StreamingContext
{
	internal readonly object m_additionalContext; //Field offset: 0x0
	internal readonly StreamingContextStates m_state; //Field offset: 0x8

	public object Context
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public StreamingContextStates State
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public StreamingContext(StreamingContextStates state) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public StreamingContext(StreamingContextStates state, object additional) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public object get_Context() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public StreamingContextStates get_State() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

