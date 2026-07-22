namespace UnityEngine.Rendering;

public sealed class ScaleFunc : MulticastDelegate
{

	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ScaleFunc(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override IAsyncResult BeginInvoke(Vector2Int size, AsyncCallback callback, object object) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override Vector2Int EndInvoke(IAsyncResult result) { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override Vector2Int Invoke(Vector2Int size) { }

}

