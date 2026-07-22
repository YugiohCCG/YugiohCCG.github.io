namespace System.Data;

internal sealed class DataRowCreatedEventHandler : MulticastDelegate
{

	[CallerCount(Count = 290)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public DataRowCreatedEventHandler(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object sender, DataRow r) { }

}

