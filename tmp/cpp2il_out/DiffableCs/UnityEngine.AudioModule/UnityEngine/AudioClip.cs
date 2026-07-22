namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioClip : AudioResource
{
	internal sealed class PCMReaderCallback : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public PCMReaderCallback(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Single[] data) { }

	}

	internal sealed class PCMSetPositionCallback : MulticastDelegate
	{

		[CallerCount(Count = 79)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public PCMSetPositionCallback(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(int position) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMReaderCallback m_PCMReaderCallback; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PCMSetPositionCallback m_PCMSetPositionCallback; //Field offset: 0x20

	[NativeProperty("LengthSec")]
	public float length
	{
		[CalledBy(Type = "Manager.Sound", Member = "PlaySFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Sound", Member = "DefineTimeForNextTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Extensions.General", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(AudioClip), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[CalledBy(Type = "Manager.Sound", Member = "PlaySFX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Sound", Member = "DefineTimeForNextTrack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AudioClip), typeof(AudioClip), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_length() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_length_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private void InvokePCMReaderCallback_Internal(Single[] data) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[RequiredByNativeCode]
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

