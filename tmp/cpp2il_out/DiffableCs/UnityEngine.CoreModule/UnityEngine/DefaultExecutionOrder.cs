namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4))]
[UsedByNativeCode]
public class DefaultExecutionOrder : Attribute
{
	private int m_Order; //Field offset: 0x10

	public int order
	{
		[CallerCount(Count = 59)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DefaultExecutionOrder(int order) { }

	[CallerCount(Count = 59)]
	[DeduplicatedMethod]
	public int get_order() { }

}

