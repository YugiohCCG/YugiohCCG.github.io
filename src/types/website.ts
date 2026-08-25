export type ReleaseArtifact = {
  label: string;
  group: "installer" | "database" | "scripts" | "banlist" | "arts" | "pics" | "holograms";
  path: string;
  bytes: number;
  sha256: string;
};

export type ReleaseManifest = {
  schema_version: number;
  version: string;
  released_at: string;
  card_count: number;
  monster_count: number;
  files: ReleaseArtifact[];
};

export type SupportIssue = {
  verdict: string;
  clause?: string;
  notes?: string;
};

export type SupportCard = {
  passcode: number;
  name: string;
  verdict: string;
  review_state: string;
  issue_count: number;
  issues: SupportIssue[];
};

export type SupportStatus = {
  schema_version: number;
  generated_at?: string;
  summary: {
    active_cards: number;
    verdicts: Record<string, number>;
    unresolved_cards: number;
  };
  cards: SupportCard[];
};
