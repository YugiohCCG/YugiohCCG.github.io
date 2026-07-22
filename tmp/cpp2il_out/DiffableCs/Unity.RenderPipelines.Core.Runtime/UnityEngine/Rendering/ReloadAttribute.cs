namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Field (256))]
public sealed class ReloadAttribute : Attribute
{
	internal enum Package
	{
		Builtin = 0,
		Root = 1,
		BuiltinExtra = 2,
	}


	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReloadAttribute(String[] paths, Package package = 1) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public ReloadAttribute(string path, Package package = 1) { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReloadAttribute(string pathFormat, int rangeMin, int rangeMax, Package package = 1) { }

}

