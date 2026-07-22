namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class TextGenerationInfo
{

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "AddTextInfoToPermanentCache", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ThreadSafe]
	public static IntPtr Create() { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ReleaseResourcesIfPossible", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void Destroy(IntPtr ptr) { }

}

