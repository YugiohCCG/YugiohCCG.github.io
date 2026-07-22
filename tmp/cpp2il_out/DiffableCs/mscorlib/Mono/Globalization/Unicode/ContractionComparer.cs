namespace Mono.Globalization.Unicode;

internal class ContractionComparer : IComparer<Contraction>
{
	public static readonly ContractionComparer Instance; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static ContractionComparer() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ContractionComparer() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override int Compare(Contraction c1, Contraction c2) { }

}

