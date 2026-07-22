namespace System.Runtime.CompilerServices;

internal sealed class TrueReadOnlyCollection : ReadOnlyCollection<T>
{

	[CallerCount(Count = 37)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public TrueReadOnlyCollection`1(T[] list) { }

}

