namespace UnityEngine;

[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
{

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PlayerConnectionInternal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	private static void DisconnectAll() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	private static void Initialize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	private static bool IsConnected() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	private static void PollInternal() { }

	[CalledBy(Type = typeof(PlayerConnectionInternal), Member = "UnityEngine.IPlayerEditorConnectionNative.RegisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	private static void RegisterInternal(string messageId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RegisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

	[CalledBy(Type = typeof(PlayerConnectionInternal), Member = "UnityEngine.IPlayerEditorConnectionNative.SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	private static void SendMessage(string messageId, Byte[] data, int playerId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }

	[CalledBy(Type = typeof(PlayerConnectionInternal), Member = "UnityEngine.IPlayerEditorConnectionNative.TrySendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	private static bool TrySendMessage(string messageId, Byte[] data, int playerId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TrySendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private override void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerConnectionInternal), Member = "RegisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private override void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerConnectionInternal), Member = "SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private override void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, int playerId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerConnectionInternal), Member = "TrySendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private override bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PlayerConnectionInternal), Member = "UnregisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private override void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	[CalledBy(Type = typeof(PlayerConnectionInternal), Member = "UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	private static void UnregisterInternal(string messageId) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UnregisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

}

