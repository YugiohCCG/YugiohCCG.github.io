namespace Unity.Properties;

public sealed class PropertyGetter : MulticastDelegate
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public PropertyGetter`2(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override TValue Invoke(ref TContainer container) { }

}

