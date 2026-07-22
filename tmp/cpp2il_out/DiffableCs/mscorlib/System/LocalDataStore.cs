namespace System;

internal sealed class LocalDataStore
{
	private LocalDataStoreElement[] m_DataTable; //Field offset: 0x10
	private LocalDataStoreMgr m_Manager; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "DeleteLocalDataStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStore)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal void FreeData(int slot, long cookie) { }

	[CalledBy(Type = typeof(Context), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public object GetData(LocalDataStoreSlot slot) { }

	[CalledBy(Type = typeof(LocalDataStore), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

	[CalledBy(Type = typeof(Context), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalDataStore), Member = "PopulateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(LocalDataStoreElement))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void SetData(LocalDataStoreSlot slot, object data) { }

}

