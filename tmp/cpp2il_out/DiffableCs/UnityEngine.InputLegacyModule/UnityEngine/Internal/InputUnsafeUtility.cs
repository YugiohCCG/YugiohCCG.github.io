namespace UnityEngine.Internal;

[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility
{

	[CalledBy(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeThrows]
	internal static float GetAxis(string axisName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float GetAxis_Injected(ref ManagedSpanWrapper axisName) { }

	[CalledBy(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeThrows]
	internal static float GetAxisRaw(string axisName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float GetAxisRaw_Injected(ref ManagedSpanWrapper axisName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[CalledBy(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeThrows]
	internal static bool GetButtonDown(string buttonName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool GetButtonDown_Injected(ref ManagedSpanWrapper buttonName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeThrows]
	internal static bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

}

