namespace UnityEngine.UIElements;

[IsReadOnly]
public struct SetupDragAndDropArgs
{
	public readonly VisualElement draggedElement; //Field offset: 0x0
	public readonly IEnumerable<Int32> selectedIds; //Field offset: 0x8
	public readonly StartDragArgs startDragArgs; //Field offset: 0x10

	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RaiseSetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>), typeof(StartDragArgs)}, ReturnType = typeof(StartDragArgs))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<Int32> selectedIds, StartDragArgs startDragArgs) { }

}

