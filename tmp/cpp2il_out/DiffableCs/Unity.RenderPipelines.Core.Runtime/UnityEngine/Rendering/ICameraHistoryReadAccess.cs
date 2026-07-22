namespace UnityEngine.Rendering;

public interface ICameraHistoryReadAccess
{
	internal sealed class HistoryRequestDelegate : MulticastDelegate
	{

		[CallerCount(Count = 389)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public HistoryRequestDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(IPerFrameHistoryAccessTracker historyAccess, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(IPerFrameHistoryAccessTracker historyAccess) { }

	}


	public event HistoryRequestDelegate OnGatherHistoryRequests
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnGatherHistoryRequests(HistoryRequestDelegate value) { }

	public Type GetHistoryForRead() { }

	[CompilerGenerated]
	public void remove_OnGatherHistoryRequests(HistoryRequestDelegate value) { }

}

