namespace UnityEngine.UIElements;

internal static class EventInterestReflectionUtils
{
	private struct DefaultEventInterests
	{
		public int DefaultActionCategories; //Field offset: 0x0
		public int DefaultActionAtTargetCategories; //Field offset: 0x4
		public int HandleEventTrickleDownCategories; //Field offset: 0x8
		public int HandleEventBubbleUpCategories; //Field offset: 0xC

	}

	private static readonly Dictionary<Type, DefaultEventInterests> s_DefaultEventInterests; //Field offset: 0x0
	private static readonly Dictionary<Type, EventCategory> s_EventCategories; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private static EventInterestReflectionUtils() { }

	[CalledBy(Type = typeof(EventInterestReflectionUtils), Member = "GetDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32&), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "GetEventCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(EventCategory))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	[CalledBy(Type = typeof(VisualElement), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventInterestReflectionUtils), Member = "GetDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32&), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "GetDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32&), typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventInterestReflectionUtils), Member = "ComputeDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.EventInterestReflectionUtils+DefaultEventInterests>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(DefaultEventInterests)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories, out int handleEventTrickleDownCategories, out int handleEventBubbleUpCategories) { }

	[CalledBy(Type = typeof(EventBase`1), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EventInterestReflectionUtils), Member = "ComputeDefaultEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal static EventCategory GetEventCategory(Type eventType) { }

}

