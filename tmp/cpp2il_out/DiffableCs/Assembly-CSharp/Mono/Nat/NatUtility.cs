namespace Mono.Nat;

public static class NatUtility
{
	[CompilerGenerated]
	private static EventHandler<DeviceEventArgs> DeviceFound; //Field offset: 0x0
	[CompilerGenerated]
	private static EventHandler<DeviceEventUnknownArgs> UnknownDeviceFound; //Field offset: 0x8
	private static readonly NatProtocol[] AllProtocols; //Field offset: 0x10
	private static readonly object Locker; //Field offset: 0x18
	private static readonly Dictionary<NatProtocol, ISearcher> Searchers; //Field offset: 0x20

	public static event EventHandler<DeviceEventArgs> DeviceFound
	{
		[CalledBy(Type = typeof(NATHandler), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 259
		[CalledBy(Type = "Manager.NATHandler+<Stop>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 259
	}

	public static event EventHandler<DeviceEventUnknownArgs> UnknownDeviceFound
	{
		[CalledBy(Type = typeof(NATHandler), Member = "Start", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 263
		[CalledBy(Type = "Manager.NATHandler+<Stop>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 263
	}

	public static bool IsSearching
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NatUtility), Member = "get_pmp", ReturnType = typeof(ISearcher))]
		[Calls(Type = typeof(NatUtility), Member = "get_upnp", ReturnType = typeof(ISearcher))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 241
	}

	private static ISearcher pmp
	{
		[CalledBy(Type = typeof(NatUtility), Member = "get_IsSearching", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 145
	}

	private static ISearcher upnp
	{
		[CalledBy(Type = typeof(NatUtility), Member = "get_IsSearching", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 145
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(Int32Enum[]))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static NatUtility() { }

	[CalledBy(Type = typeof(NATHandler), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_DeviceFound(EventHandler<DeviceEventArgs> value) { }

	[CalledBy(Type = typeof(NATHandler), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_UnknownDeviceFound(EventHandler<DeviceEventUnknownArgs> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NatUtility), Member = "get_pmp", ReturnType = typeof(ISearcher))]
	[Calls(Type = typeof(NatUtility), Member = "get_upnp", ReturnType = typeof(ISearcher))]
	[CallsUnknownMethods(Count = 3)]
	public static bool get_IsSearching() { }

	[CalledBy(Type = typeof(NatUtility), Member = "get_IsSearching", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static ISearcher get_pmp() { }

	[CalledBy(Type = typeof(NatUtility), Member = "get_IsSearching", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static ISearcher get_upnp() { }

	[CalledBy(Type = typeof(NatUtility), Member = "Search", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(NatProtocol)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NatUtility), Member = "StartDiscovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NatProtocol[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NatUtility), Member = "ParseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NatProtocol), typeof(IPAddress), typeof(Byte[]), typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PmpSearcher), Member = "Create", ReturnType = typeof(PmpSearcher))]
	[Calls(Type = typeof(UpnpSearcher), Member = "Create", ReturnType = typeof(UpnpSearcher))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static ISearcher GetOrCreate(NatProtocol protocol) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void HandleDeviceFound(object sender, DeviceEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void HandleUnknownDeviceFound(object sender, DeviceEventUnknownArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NatUtility), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NatProtocol)}, ReturnType = typeof(ISearcher))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void ParseMessage(NatProtocol type, IPAddress localAddress, Byte[] content, IPEndPoint source) { }

	[CalledBy(Type = "Manager.NATHandler+<Stop>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_DeviceFound(EventHandler<DeviceEventArgs> value) { }

	[CalledBy(Type = "Manager.NATHandler+<Stop>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_UnknownDeviceFound(EventHandler<DeviceEventUnknownArgs> value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NatUtility), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NatProtocol)}, ReturnType = typeof(ISearcher))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void Search(IPAddress gatewayAddress, NatProtocol type) { }

	[CalledBy(Type = typeof(NATHandler), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NatUtility), Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NatProtocol)}, ReturnType = typeof(ISearcher))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void StartDiscovery(NatProtocol[] devices) { }

	[CalledBy(Type = "Manager.NATHandler+<Stop>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public static void StopDiscovery() { }

}

