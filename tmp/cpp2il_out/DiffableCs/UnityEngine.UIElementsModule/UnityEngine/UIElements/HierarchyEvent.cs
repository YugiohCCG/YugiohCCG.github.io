namespace UnityEngine.UIElements;

internal sealed class HierarchyEvent : MulticastDelegate
{

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public HierarchyEvent(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

}

