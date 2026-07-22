namespace UnityEngine.UI;

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

	[CalledBy(Type = typeof(Image), Member = "set_preserveAspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "set_fillCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "set_fillClockwise", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "set_useSpriteMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "set_shouldHideMobileInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LayoutElement), Member = "set_ignoreLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Slider), Member = "set_wholeNumbers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Boolean>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Boolean>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	[DeduplicatedMethod]
	public static bool SetStruct(ref T currentValue, T newValue) { }

}

