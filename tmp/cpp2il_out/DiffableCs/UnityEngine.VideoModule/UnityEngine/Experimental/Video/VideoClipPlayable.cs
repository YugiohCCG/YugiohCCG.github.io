namespace UnityEngine.Experimental.Video;

[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("VideoClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct VideoClipPlayable : IEquatable<VideoClipPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableHandle), typeof(PlayableHandle)}, ReturnType = typeof(bool))]
	public override bool Equals(VideoClipPlayable other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override PlayableHandle GetHandle() { }

}

