namespace UnityEngine.UIElements;

[IsReadOnly]
public struct HandleDragAndDropArgs
{
	private readonly DragAndDropArgs m_DragAndDropArgs; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Vector2 <position>k__BackingField; //Field offset: 0x20

	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RaiseHandleDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(DragVisualMode))]
	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RaiseDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(DragAndDropArgs)}, ReturnType = typeof(DragVisualMode))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal HandleDragAndDropArgs(Vector2 position, DragAndDropArgs dragAndDropArgs) { }

}

