namespace System.Xml.Schema;

internal class UpaException : Exception
{
	private object particle1; //Field offset: 0x90
	private object particle2; //Field offset: 0x98

	public object Particle1
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public object Particle2
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public UpaException(object particle1, object particle2) { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public object get_Particle1() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public object get_Particle2() { }

}

