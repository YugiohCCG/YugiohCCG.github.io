namespace PooledScrollList.Data;

public abstract class PooledDataProvider : MonoBehaviour
{

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected PooledDataProvider() { }

	public abstract List<IPooledData> GetData() { }

}

