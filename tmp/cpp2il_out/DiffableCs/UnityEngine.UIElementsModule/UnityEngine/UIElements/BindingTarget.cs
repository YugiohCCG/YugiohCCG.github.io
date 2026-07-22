namespace UnityEngine.UIElements;

[IsReadOnly]
internal struct BindingTarget
{
	public readonly VisualElement element; //Field offset: 0x0
	public readonly BindingId bindingId; //Field offset: 0x8

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public BindingTarget(VisualElement element, in BindingId bindingId) { }

}

