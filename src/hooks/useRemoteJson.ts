import { useEffect, useState } from "react";
import { asset } from "../utils/assets";

export default function useRemoteJson<T>(path: string) {
  const [data, setData] = useState<T | null>(null);
  const [error, setError] = useState<unknown | null>(null);

  useEffect(() => {
    const controller = new AbortController();
    fetch(asset(path), { signal: controller.signal, cache: "no-cache" })
      .then((response) => {
        if (!response.ok) throw new Error(`${path}: HTTP ${response.status}`);
        return response.json() as Promise<T>;
      })
      .then(setData)
      .catch((reason) => {
        if ((reason as Error).name !== "AbortError") setError(reason);
      });
    return () => controller.abort();
  }, [path]);

  return { data, loading: !data && !error, error };
}
