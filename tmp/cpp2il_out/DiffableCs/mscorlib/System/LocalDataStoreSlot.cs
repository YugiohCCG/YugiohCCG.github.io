namespace System;

[ComVisible(True)]
public sealed class LocalDataStoreSlot
{
	private LocalDataStoreMgr m_mgr; //Field offset: 0x10
	private int m_slot; //Field offset: 0x18
	private long m_cookie; //Field offset: 0x20

	internal long Cookie
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal LocalDataStoreMgr Manager
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int Slot
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "FreeDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal long get_Cookie() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal LocalDataStoreMgr get_Manager() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_Slot() { }

}

