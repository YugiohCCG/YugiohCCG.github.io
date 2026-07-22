namespace Unity.Collections;

internal struct Long1024 : IIndexable<Int64>
{
	internal Long512 f0; //Field offset: 0x0
	internal Long512 f1; //Field offset: 0x1000

	public override int Length
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	[CalledBy(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ConcurrentMask), Member = "TryFree", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ConcurrentMask), Member = "TryAllocate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(Int32&), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	public override long ElementAt(int index) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override int get_Length() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void set_Length(int value) { }

}

