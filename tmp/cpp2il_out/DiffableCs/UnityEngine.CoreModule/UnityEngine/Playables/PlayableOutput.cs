namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct PlayableOutput : IEquatable<PlayableOutput>
{
	private static readonly PlayableOutput m_NullPlayableOutput; //Field offset: 0x0
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[CallerCount(Count = 0)]
	private static PlayableOutput() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[VisibleToOtherModules]
	internal PlayableOutput(PlayableOutputHandle handle) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(PlayableOutput other) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override PlayableOutputHandle GetHandle() { }

}

