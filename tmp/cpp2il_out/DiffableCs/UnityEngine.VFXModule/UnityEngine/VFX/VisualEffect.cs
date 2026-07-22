namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
[RequireComponent(typeof(Transform))]
public class VisualEffect : Behaviour
{
	private VFXEventAttribute m_cachedEventAttribute; //Field offset: 0x18
	public Action<VFXOutputEventArgs> outputEventReceived; //Field offset: 0x20

	public VisualEffectAsset visualEffectAsset
	{
		[CalledBy(Type = typeof(VisualEffect), Member = "CreateVFXEventAttribute", ReturnType = typeof(VFXEventAttribute))]
		[CalledBy(Type = typeof(VisualEffect), Member = "InvokeGetCachedEventAttributeForOutputEvent_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualEffect)}, ReturnType = typeof(VFXEventAttribute))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 294
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualEffect), Member = "get_visualEffectAsset", ReturnType = typeof(VisualEffectAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public VFXEventAttribute CreateVFXEventAttribute() { }

	[CalledBy(Type = typeof(VisualEffect), Member = "CreateVFXEventAttribute", ReturnType = typeof(VFXEventAttribute))]
	[CalledBy(Type = typeof(VisualEffect), Member = "InvokeGetCachedEventAttributeForOutputEvent_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualEffect)}, ReturnType = typeof(VFXEventAttribute))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public VisualEffectAsset get_visualEffectAsset() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_visualEffectAsset_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualEffect), Member = "get_visualEffectAsset", ReturnType = typeof(VisualEffectAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[RequiredByNativeCode]
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId) { }

}

