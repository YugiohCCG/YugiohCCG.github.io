namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct Playable : IEquatable<Playable>
{
	private static readonly Playable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	public static Playable Null
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 96
	}

	[CallerCount(Count = 0)]
	private static Playable() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[VisibleToOtherModules]
	internal Playable(PlayableHandle handle) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Playable other) { }

	[CallerCount(Count = 0)]
	public static Playable get_Null() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override PlayableHandle GetHandle() { }

}

