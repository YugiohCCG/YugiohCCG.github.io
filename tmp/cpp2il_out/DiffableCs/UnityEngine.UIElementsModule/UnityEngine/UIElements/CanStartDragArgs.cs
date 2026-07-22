namespace UnityEngine.UIElements;

[IsReadOnly]
public struct CanStartDragArgs
{
	public readonly VisualElement draggedElement; //Field offset: 0x0
	public readonly int id; //Field offset: 0x8
	public readonly IEnumerable<Int32> selectedIds; //Field offset: 0x10

	[CalledBy(Type = typeof(BaseVerticalCollectionView), Member = "RaiseCanStartDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ReusableCollectionItem), typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<Int32> selectedIds) { }

}

