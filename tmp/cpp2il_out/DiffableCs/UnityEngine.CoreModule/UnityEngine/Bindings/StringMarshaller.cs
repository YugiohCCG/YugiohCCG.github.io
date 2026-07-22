namespace UnityEngine.Bindings;

[VisibleToOtherModules]
internal static class StringMarshaller
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool TryMarshalEmptyOrNullString(string s, ref ManagedSpanWrapper managedSpanWrapper) { }

}

