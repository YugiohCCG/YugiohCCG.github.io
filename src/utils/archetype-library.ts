import records from "../data/archetype-classification.json";
import { consolidatedArchetypes } from "./memberships";
export const archetypeFamilies = records.filter((record) => record.kind !== "standalone").map((record) => ({ ...record, group: consolidatedArchetypes.find((group) => group.name === record.family)! })).sort((a, b) => a.family.localeCompare(b.family));
