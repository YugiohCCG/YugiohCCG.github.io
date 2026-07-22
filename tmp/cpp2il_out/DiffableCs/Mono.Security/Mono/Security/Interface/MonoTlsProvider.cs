namespace Mono.Security.Interface;

public abstract class MonoTlsProvider
{

	public abstract Guid ID
	{
		 get { } //Length: 0
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public abstract SslProtocols SupportedProtocols
	{
		 get { } //Length: 0
	}

	internal abstract bool SupportsCleanShutdown
	{
		internal get { } //Length: 0
	}

	public abstract bool SupportsConnectionInfo
	{
		 get { } //Length: 0
	}

	public abstract bool SupportsMonoExtensions
	{
		 get { } //Length: 0
	}

	public abstract bool SupportsSslStream
	{
		 get { } //Length: 0
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MonoTlsProvider() { }

	public abstract Guid get_ID() { }

	public abstract string get_Name() { }

	public abstract SslProtocols get_SupportedProtocols() { }

	internal abstract bool get_SupportsCleanShutdown() { }

	public abstract bool get_SupportsConnectionInfo() { }

	public abstract bool get_SupportsMonoExtensions() { }

	public abstract bool get_SupportsSslStream() { }

}

