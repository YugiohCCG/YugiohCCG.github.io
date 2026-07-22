namespace UnityEngine.UIElements;

internal interface IDragAndDropController
{

	public bool CanStartDrag(IEnumerable<Int32> itemIds) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void DragCleanup() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public IEnumerable<Int32> GetSortedSelectedIds() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	public DragVisualMode HandleDragAndDrop(TArgs args) { }

	public void OnDrop(TArgs args) { }

	public StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}

