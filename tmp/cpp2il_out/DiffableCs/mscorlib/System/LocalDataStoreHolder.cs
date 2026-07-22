namespace System;

internal sealed class LocalDataStoreHolder
{
	private LocalDataStore m_Store; //Field offset: 0x10

	public LocalDataStore Store
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public LocalDataStoreHolder(LocalDataStore store) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "DeleteLocalDataStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStore)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public LocalDataStore get_Store() { }

}

