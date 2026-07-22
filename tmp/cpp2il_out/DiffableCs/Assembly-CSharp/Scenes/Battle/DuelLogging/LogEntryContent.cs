namespace Scenes.Battle.DuelLogging;

public abstract class LogEntryContent : MonoBehaviour
{

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected LogEntryContent() { }

	public abstract void Setup(ILogEventData data) { }

}

