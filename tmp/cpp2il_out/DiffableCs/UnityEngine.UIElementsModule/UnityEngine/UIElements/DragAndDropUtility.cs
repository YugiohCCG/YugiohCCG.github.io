namespace UnityEngine.UIElements;

internal static class DragAndDropUtility
{
	private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc; //Field offset: 0x0
	private static IDragAndDrop s_DragAndDropEditor; //Field offset: 0x8
	private static IDragAndDrop s_DragAndDropPlayMode; //Field offset: 0x10

	[CalledBy(Type = typeof(ListViewDragger), Member = "MakeDragAndDropArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DragPosition)}, ReturnType = typeof(DragAndDropArgs))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultDragAndDropClient), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static IDragAndDrop GetDragAndDrop(IPanel panel) { }

}

