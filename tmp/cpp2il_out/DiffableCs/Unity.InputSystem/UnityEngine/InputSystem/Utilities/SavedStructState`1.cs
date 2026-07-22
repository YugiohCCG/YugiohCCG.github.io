namespace UnityEngine.InputSystem.Utilities;

internal sealed class SavedStructState : ISavedState
{
	internal sealed class TypedRestore : MulticastDelegate
	{

		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public TypedRestore(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public override IAsyncResult BeginInvoke(ref T state, AsyncCallback callback, object object) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void EndInvoke(ref T state, IAsyncResult result) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(ref T state) { }

	}

	private T m_State; //Field offset: 0x0
	private TypedRestore<T> m_RestoreAction; //Field offset: 0x0
	private Action m_StaticDisposeCurrentState; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	internal SavedStructState`1(ref T state, TypedRestore<T> restoreAction, Action staticDisposeCurrentState = null) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public override void RestoreSavedState() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	public override void StaticDisposeCurrentState() { }

}

