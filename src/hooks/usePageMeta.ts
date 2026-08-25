import { useEffect } from "react";

export default function usePageMeta(title: string, description?: string) {
  useEffect(() => {
    const previousTitle = document.title;
    const meta = document.querySelector<HTMLMetaElement>('meta[name="description"]');
    const ogTitle = document.querySelector<HTMLMetaElement>('meta[property="og:title"]');
    const ogDescription = document.querySelector<HTMLMetaElement>('meta[property="og:description"]');
    const ogUrl = document.querySelector<HTMLMetaElement>('meta[property="og:url"]');
    const canonical = document.querySelector<HTMLLinkElement>('link[rel="canonical"]');
    const previousDescription = meta?.content;
    const fullTitle = `${title} | Yu-Gi-Oh! CCG`;
    document.title = fullTitle;
    if (meta && description) meta.content = description;
    if (ogTitle) ogTitle.content = fullTitle;
    if (ogDescription && description) ogDescription.content = description;
    if (ogUrl) ogUrl.content = window.location.href;
    if (canonical) canonical.href = window.location.href.split(/[?#]/)[0];
    return () => {
      document.title = previousTitle;
      if (meta && previousDescription != null) meta.content = previousDescription;
    };
  }, [description, title]);
}
