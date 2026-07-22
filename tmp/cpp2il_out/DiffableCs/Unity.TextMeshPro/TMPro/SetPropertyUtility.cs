namespace TMPro;

internal static class SetPropertyUtility
{

	[CallerCount(Count = 28)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool SetClass(ref T currentValue, T newValue) { }

	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	public static bool SetEquatableStruct(ref T currentValue, T newValue) { }

	[CalledBy(Type = typeof(TMP_InputField), Member = "set_shouldHideMobileInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_InputField), Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool SetStruct(ref T currentValue, T newValue) { }

}

