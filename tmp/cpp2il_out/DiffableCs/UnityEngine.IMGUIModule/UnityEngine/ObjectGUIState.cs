namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIState.h")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class ObjectGUIState : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(ObjectGUIState objectGUIState) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "get_guiState", ReturnType = typeof(ObjectGUIState))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ObjectGUIState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Destroy() { }

	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Internal_Create() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

}

