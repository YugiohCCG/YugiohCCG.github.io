namespace UnityEngine;

[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
public static class JsonUtility
{

	[CalledBy(Type = "UI.Dates.DatePicker", Member = "SetConfigFromJsonString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionMap", Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputActionMap[]")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout+Collection", Member = "TryLoadLayoutInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InternedString"}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout", Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public static T FromJson(string json) { }

	[CalledBy(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(JsonUtility), Member = "FromJsonInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static object FromJson(string json, Type type) { }

	[CalledBy(Type = typeof(JsonUtility), Member = "FromJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("FromJsonInternal", True, ThrowsException = True)]
	[ThreadSafe]
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static object FromJsonInternal_Injected(ref ManagedSpanWrapper json, object objectToOverwrite, Type type) { }

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(JsonUtility), Member = "ToJsonInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static string ToJson(object obj) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionAsset", Member = "ToJson", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionMap", Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<InputActionMap>"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionMap", Member = "ToJson", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.HID.HID+HIDDeviceDescriptor", Member = "ToJson", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout", Member = "ToJson", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceDescription", Member = "ToJson", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JsonUtility), Member = "ToJsonInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsInvalidInstructions]
	public static string ToJson(object obj, bool prettyPrint) { }

	[CalledBy(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("ToJsonInternal", True)]
	[ThreadSafe]
	private static string ToJsonInternal(object obj, bool prettyPrint) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ToJsonInternal_Injected(object obj, bool prettyPrint, out ManagedSpanWrapper ret) { }

}

