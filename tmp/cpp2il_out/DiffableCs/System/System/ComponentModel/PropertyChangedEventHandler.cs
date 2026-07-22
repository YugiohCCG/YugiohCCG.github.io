namespace System.ComponentModel;

public sealed class PropertyChangedEventHandler : MulticastDelegate
{

	[CallerCount(Count = 290)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public PropertyChangedEventHandler(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object sender, PropertyChangedEventArgs e) { }

}

