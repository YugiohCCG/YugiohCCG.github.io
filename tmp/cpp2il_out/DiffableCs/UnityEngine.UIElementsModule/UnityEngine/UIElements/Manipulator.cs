namespace UnityEngine.UIElements;

public abstract class Manipulator : IManipulator
{
	private VisualElement m_Target; //Field offset: 0x10

	public override VisualElement target
	{
		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 92
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Manipulator() { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public override VisualElement get_target() { }

	protected abstract void RegisterCallbacksOnTarget() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_target(VisualElement value) { }

	protected abstract void UnregisterCallbacksFromTarget() { }

}

