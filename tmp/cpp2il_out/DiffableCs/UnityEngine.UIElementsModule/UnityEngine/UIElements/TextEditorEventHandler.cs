namespace UnityEngine.UIElements;

internal class TextEditorEventHandler
{
	protected TextElement textElement; //Field offset: 0x10
	protected TextEditingUtilities editingUtilities; //Field offset: 0x18

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	protected TextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void HandleEventBubbleUp(EventBase evt) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void RegisterCallbacksOnTarget(VisualElement target) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void UnregisterCallbacksFromTarget(VisualElement target) { }

}

