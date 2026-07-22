namespace System.Runtime.Serialization;

public sealed class SerializationEventHandler : MulticastDelegate
{

	[CallerCount(Count = 178)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public SerializationEventHandler(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(StreamingContext context) { }

}

