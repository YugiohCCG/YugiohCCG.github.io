namespace Newtonsoft.Json.Serialization;

public sealed class ObjectConstructor : MulticastDelegate
{

	[CallerCount(Count = 131)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public ObjectConstructor`1(object object, IntPtr method) { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override IAsyncResult BeginInvoke(Object[] args, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override object EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public override object Invoke(Object[] args) { }

}

