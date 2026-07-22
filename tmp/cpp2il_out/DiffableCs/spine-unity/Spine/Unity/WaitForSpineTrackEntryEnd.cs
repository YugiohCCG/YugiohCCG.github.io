namespace Spine.Unity;

public class WaitForSpineTrackEntryEnd : IEnumerator
{
	private bool m_WasFired; //Field offset: 0x10

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		private get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackEntry), Member = "add_End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public WaitForSpineTrackEntryEnd(TrackEntry trackEntry) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	private void HandleEnd(TrackEntry trackEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackEntry), Member = "add_End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public WaitForSpineTrackEntryEnd NowWaitFor(TrackEntry trackEntry) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TrackEntry), Member = "add_End", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackEntryDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SafeSubscribe(TrackEntry trackEntry) { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	private override object System.Collections.IEnumerator.get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	private override void System.Collections.IEnumerator.Reset() { }

}

