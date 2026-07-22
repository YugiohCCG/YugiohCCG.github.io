namespace Newtonsoft.Json.Serialization;

public sealed class SerializationCallback : MulticastDelegate
{

	[CallerCount(Count = 58)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public SerializationCallback(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public override void Invoke(object o, StreamingContext context) { }

}

