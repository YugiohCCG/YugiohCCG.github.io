namespace Internal.Cryptography;

internal static class OidLookup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		internal string <.cctor>b__10_0(KeyValuePair<String, String> kvp) { }

		[CallerCount(Count = 0)]
		internal string <.cctor>b__10_1(KeyValuePair<String, String> kvp) { }

	}

	private static readonly ConcurrentDictionary<String, String> s_lateBoundOidToFriendlyName; //Field offset: 0x0
	private static readonly ConcurrentDictionary<String, String> s_lateBoundFriendlyNameToOid; //Field offset: 0x8
	private static readonly Dictionary<String, String> s_friendlyNameToOid; //Field offset: 0x10
	private static readonly Dictionary<String, String> s_oidToFriendlyName; //Field offset: 0x18
	private static readonly Dictionary<String, String> s_compatOids; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>), typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>>), typeof(System.Func`2<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>, System.Object>), typeof(System.Func`2<System.Collections.Generic.KeyValuePair`2<System.Object, System.Object>, System.Object>)}, ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private static OidLookup() { }

	[CalledBy(Type = typeof(OidLookup), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[CalledBy(Type = typeof(OidLookup), Member = "ToFriendlyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	[CalledBy(Type = typeof(Oid), Member = "FromOidValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup)}, ReturnType = typeof(Oid))]
	[CalledBy(Type = typeof(Oid), Member = "get_FriendlyName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_SignatureAlgorithm", ReturnType = typeof(Oid))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OidLookup), Member = "NativeOidToFriendlyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[CalledBy(Type = typeof(Oid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OidLookup), Member = "NativeFriendlyNameToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

}

