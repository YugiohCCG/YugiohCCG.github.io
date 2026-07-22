namespace UnityEngine.InputForUI;

internal class NavigationEventRepeatHelper
{
	private int m_ConsecutiveMoveCount; //Field offset: 0x10
	private Direction m_LastDirection; //Field offset: 0x14
	private DiscreteTime m_PrevActionTime; //Field offset: 0x18
	private readonly DiscreteTime m_InitialRepeatDelay; //Field offset: 0x20
	private readonly DiscreteTime m_ConsecutiveRepeatDelay; //Field offset: 0x28

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public NavigationEventRepeatHelper() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public void Reset() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public bool ShouldSendMoveEvent(DiscreteTime timestamp, Direction direction, bool axisButtonsWherePressedThisFrame) { }

}

