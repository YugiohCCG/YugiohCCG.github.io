namespace UnityEngine.VFX;

[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
[RequiredByNativeCode]
public sealed class VFXEventAttribute : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(VFXEventAttribute eventAttibute) { }

	}

	private IntPtr m_Ptr; //Field offset: 0x10
	private bool m_Owner; //Field offset: 0x18
	private VisualEffectAsset m_VfxAsset; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static VFXEventAttribute CreateEventAttributeWrapper() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static IntPtr Internal_Create() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsThreadSafe = True)]
	internal static void Internal_Destroy(IntPtr ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_InitFromAsset_Injected(IntPtr _unity_self, IntPtr vfxAsset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void Release() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void SetWrapValue(IntPtr ptrToEventAttribute) { }

}

