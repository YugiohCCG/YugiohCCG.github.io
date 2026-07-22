namespace System.Collections.ObjectModel;

internal static class EventArgsCache
{
	internal static readonly PropertyChangedEventArgs CountPropertyChanged; //Field offset: 0x0
	internal static readonly PropertyChangedEventArgs IndexerPropertyChanged; //Field offset: 0x8
	internal static readonly NotifyCollectionChangedEventArgs ResetCollectionChanged; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static EventArgsCache() { }

}

