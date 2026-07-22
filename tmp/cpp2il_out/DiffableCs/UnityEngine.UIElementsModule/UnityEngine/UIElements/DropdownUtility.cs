namespace UnityEngine.UIElements;

internal static class DropdownUtility
{
	internal static Func<IGenericMenu> MakeDropdownFunc; //Field offset: 0x0

	[CalledBy(Type = typeof(BasePopupField`2), Member = "ShowMenu", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GenericDropdownMenu), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IGenericMenu CreateDropdown() { }

}

