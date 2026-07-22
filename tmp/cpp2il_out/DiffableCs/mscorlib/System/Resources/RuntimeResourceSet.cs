namespace System.Resources;

internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable
{
	internal const int Version = 2; //Field offset: 0x0
	private Dictionary<String, ResourceLocator> _resCache; //Field offset: 0x28
	private ResourceReader _defaultReader; //Field offset: 0x30
	private Dictionary<String, ResourceLocator> _caseInsensitiveTable; //Field offset: 0x38
	private bool _haveReadFromReader; //Field offset: 0x40

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Resources.ResourceLocator>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal RuntimeResourceSet(string fileName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Resources.ResourceLocator>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal RuntimeResourceSet(Stream stream) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceSet), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetEnumeratorHelper", ReturnType = typeof(IDictionaryEnumerator))]
	[DeduplicatedMethod]
	public virtual IDictionaryEnumerator GetEnumerator() { }

	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	public virtual object GetObject(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	public virtual object GetObject(string key, bool ignoreCase) { }

	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "ResolveResourceLocator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceLocator), typeof(string), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Resources.ResourceLocator>), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Resources.ResourceLocator>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ResourceLocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Resources.ResourceLocator>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ResourceLocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ResourceReader), Member = "FindPosForResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 54)]
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetString(string key) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string GetString(string key, bool ignoreCase) { }

	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Resources.ResourceLocator>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ResourceLocator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<String, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetEnumeratorHelper", ReturnType = typeof(IDictionaryEnumerator))]
	[DeduplicatedMethod]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

