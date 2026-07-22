namespace Newtonsoft.Json.Serialization;

public sealed class ExtensionDataGetter : MulticastDelegate
{

	[CallerCount(Count = 225)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public ExtensionDataGetter(object object, IntPtr method) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IEnumerable<KeyValuePair`2<Object, Object>> EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public override IEnumerable<KeyValuePair`2<Object, Object>> Invoke(object o) { }

}

