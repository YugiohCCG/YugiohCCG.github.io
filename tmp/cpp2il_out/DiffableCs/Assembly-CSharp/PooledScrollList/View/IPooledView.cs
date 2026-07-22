namespace PooledScrollList.View;

public interface IPooledView
{

	public IPooledData Data
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IPooledData get_Data() { }

	public void set_Data(IPooledData value) { }

	public void SetData(IPooledData data) { }

}

