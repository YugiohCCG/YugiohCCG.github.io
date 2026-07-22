namespace Scenes.Battle.DuelLogging;

public interface ILogEventData : IPooledData
{

	public DuelLog Event
	{
		 get { } //Length: 0
	}

	public DuelLog get_Event() { }

}

