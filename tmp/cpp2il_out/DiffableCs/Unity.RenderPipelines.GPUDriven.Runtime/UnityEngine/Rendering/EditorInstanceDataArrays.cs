namespace UnityEngine.Rendering;

internal struct EditorInstanceDataArrays : IDataArrays
{
	[IsReadOnly]
	public struct ReadOnly
	{

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public ReadOnly(in CPUInstanceData instanceData) { }

	}


	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Grow(int newCapacity) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Initialize(int initCapacity) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Remove(int index, int lastIndex) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void SetDefault(int index) { }

}

