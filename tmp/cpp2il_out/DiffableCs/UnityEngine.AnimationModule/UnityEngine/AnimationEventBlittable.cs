namespace UnityEngine;

[RequiredByNativeCode]
internal struct AnimationEventBlittable : IDisposable
{
	[ThreadStatic]
	private static GCHandlePool s_handlePool; //Field offset: 0x80000000
	internal float m_Time; //Field offset: 0x0
	internal IntPtr m_FunctionName; //Field offset: 0x8
	internal IntPtr m_StringParameter; //Field offset: 0x10
	internal IntPtr m_ObjectReferenceParameter; //Field offset: 0x18
	internal float m_FloatParameter; //Field offset: 0x20
	internal int m_IntParameter; //Field offset: 0x24
	internal int m_MessageOptions; //Field offset: 0x28
	internal AnimationEventSource m_Source; //Field offset: 0x2C
	internal IntPtr m_StateSender; //Field offset: 0x30
	internal AnimatorStateInfo m_AnimatorStateInfo; //Field offset: 0x38
	internal AnimatorClipInfo m_AnimatorClipInfo; //Field offset: 0x5C

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandlePool), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GCHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationEventBlittable), Member = "ToAnimationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationEventBlittable)}, ReturnType = typeof(AnimationEvent))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static AnimationEvent PointerToAnimationEvent(IntPtr animationEventBlittable) { }

	[CalledBy(Type = typeof(AnimationEventBlittable), Member = "PointerToAnimationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(AnimationEvent))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	internal static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable) { }

}

