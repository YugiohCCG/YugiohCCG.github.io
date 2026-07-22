namespace System;

public sealed class Func : MulticastDelegate
{

	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+InputForUIProcessor", Member = "ProcessPointerEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.PointerEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessMouseEvents", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.EnhancedTouch.Finger", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Touchscreen", typeof(int), "UnityEngine.InputSystem.LowLevel.InputUpdateType"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public Func`4(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override TResult Invoke(T1 arg1, T2 arg2, T3 arg3) { }

}

