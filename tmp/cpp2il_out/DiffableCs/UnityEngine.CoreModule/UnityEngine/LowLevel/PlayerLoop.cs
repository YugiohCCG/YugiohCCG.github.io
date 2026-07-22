namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
public class PlayerLoop
{

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "InsertIntoPlayerLoop", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "RemoveFromPlayerLoop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystemInternal[]), typeof(Int32&)}, ReturnType = typeof(PlayerLoopSystem))]
	[CallsUnknownMethods(Count = 2)]
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsFreeFunction = True)]
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	[CalledBy(Type = typeof(PlayerLoop), Member = "GetCurrentPlayerLoop", ReturnType = typeof(PlayerLoopSystem))]
	[CalledBy(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystemInternal[]), typeof(Int32&)}, ReturnType = typeof(PlayerLoopSystem))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerLoop), Member = "InternalToPlayerLoopSystem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystemInternal[]), typeof(Int32&)}, ReturnType = typeof(PlayerLoopSystem))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	[CalledBy(Type = typeof(PlayerLoop), Member = "SetPlayerLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerLoop), Member = "PlayerLoopSystemToInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem), typeof(List`1<PlayerLoopSystemInternal>&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerLoop), Member = "PlayerLoopSystemToInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem), typeof(List`1<PlayerLoopSystemInternal>&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal>& internalSys) { }

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "InsertIntoPlayerLoop", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "RemoveFromPlayerLoop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerLoop), Member = "PlayerLoopSystemToInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayerLoopSystem), typeof(List`1<PlayerLoopSystemInternal>&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(IsFreeFunction = True)]
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }

}

