// ============================================
// ANIMATIONS — Scroll reveal, navbar, marquee
// No dependencies. Runs after DOM ready.
// ============================================

(function () {
  'use strict';

  // ---- 1. SCROLL REVEAL via IntersectionObserver ----
  // Un solo observer global compartido; el MutationObserver solo
  // agrega al observer los nodos .reveal nuevos, no crea uno nuevo.
  let revealObserver = null;
  const REVEAL_ATTR = 'data-reveal-bound';

  function ensureRevealObserver() {
    if (revealObserver) return revealObserver;
    revealObserver = new IntersectionObserver(
      (entries) => {
        entries.forEach((entry) => {
          if (entry.isIntersecting) {
            entry.target.classList.add('visible');
            revealObserver.unobserve(entry.target);
          }
        });
      },
      { threshold: 0.05, rootMargin: '0px 0px -10% 0px' }
    );
    return revealObserver;
  }

  function bindRevealEl(el) {
    if (!(el instanceof Element)) return;
    if (el.classList.contains('visible')) return;
    if (el.hasAttribute(REVEAL_ATTR)) return;
    // Si ya está en el viewport al momento de bindear, marcar visible de una.
    const rect = el.getBoundingClientRect();
    const inView = rect.top < window.innerHeight && rect.bottom > 0;
    if (inView) {
      el.classList.add('visible');
      el.setAttribute(REVEAL_ATTR, '1');
      return;
    }
    el.setAttribute(REVEAL_ATTR, '1');
    ensureRevealObserver().observe(el);
  }

  function initReveal(root) {
    const scope = root && root.querySelectorAll ? root : document;
    scope.querySelectorAll('.reveal').forEach(bindRevealEl);
  }

  // Red de seguridad: después de 2.5s, forzar visible cualquier .reveal
  // que ya esté en viewport pero no haya sido gatillado (anti race condition).
  function revealSafetyNet() {
    setTimeout(() => {
      document.querySelectorAll('.reveal:not(.visible)').forEach((el) => {
        const rect = el.getBoundingClientRect();
        if (rect.top < window.innerHeight && rect.bottom > 0) {
          el.classList.add('visible');
        }
      });
    }, 2500);
  }

  // ---- 2. NAVBAR scroll state (background más opaco) ----
  function initNavbar() {
    const navbar = document.querySelector('.navbar');
    if (!navbar) return;
    const onScroll = () => {
      if (window.scrollY > 10) navbar.classList.add('scrolled');
      else navbar.classList.remove('scrolled');
    };
    window.addEventListener('scroll', onScroll, { passive: true });
    onScroll();
  }

  // ---- 3. MARQUEE duplicar contenido (seamless loop) ----
  function initMarquees() {
    document.querySelectorAll('.marquee-track').forEach((track) => {
      if (track.dataset.cloned) return;
      // Duplicar items para loop infinito sin gap
      const items = Array.from(track.children);
      items.forEach((item) => {
        const clone = item.cloneNode(true);
        clone.setAttribute('aria-hidden', 'true');
        track.appendChild(clone);
      });
      track.dataset.cloned = 'true';
    });
  }

  // ---- 4. HERO card tilt (mouse follow sutil) ----
  function initHeroTilt() {
    const card = document.querySelector('.hero-card');
    if (!card) return;
    const onMove = (e) => {
      const rect = card.getBoundingClientRect();
      const x = (e.clientX - rect.left) / rect.width - 0.5;
      const y = (e.clientY - rect.top) / rect.height - 0.5;
      card.style.transform = `perspective(1000px) rotateY(${x * -8}deg) rotateX(${y * 8}deg)`;
    };
    const onLeave = () => {
      card.style.transform = 'perspective(1000px) rotateY(-5deg) rotateX(2deg)';
    };
    card.addEventListener('mousemove', onMove);
    card.addEventListener('mouseleave', onLeave);
  }

  // ---- 5. SMOOTH anchor scroll for hash links ----
  function initSmoothScroll() {
    document.querySelectorAll('a[href^="#"]').forEach((a) => {
      a.addEventListener('click', (e) => {
        const target = document.querySelector(a.getAttribute('href'));
        if (target) {
          e.preventDefault();
          target.scrollIntoView({ behavior: 'smooth', block: 'start' });
        }
      });
    });
  }

  // ---- INIT ----
  // Blazor re-renders the DOM, so we need to observe changes.
  // Use MutationObserver to re-attach effects when content swaps.

  let initTimer = null;
  function boot() {
    initReveal(document);
    initNavbar();
    initMarquees();
    initHeroTilt();
    initSmoothScroll();
    revealSafetyNet();
  }

  function scheduleBoot() {
    if (initTimer) clearTimeout(initTimer);
    initTimer = setTimeout(boot, 100);
  }

  // Si Blazor ya terminó de hidratar (pasa tarde en WASM), corré boot YA.
  document.addEventListener('DOMContentLoaded', scheduleBoot);
  window.addEventListener('load', scheduleBoot);
  // Blazor WASM emite 'enhancedload' después del primer render interactivo.
  window.addEventListener('enhancedload', scheduleBoot);

  // Cuando aparezcan nuevos .reveal en el DOM, agregarlos al observer
  // existente (no crear uno nuevo). Escaneamos solo subárboles nuevos
  // para no iterar todo el document en cada mutación.
  const mo = new MutationObserver((mutations) => {
    let needsMarquee = false;
    for (const m of mutations) {
      m.addedNodes.forEach((node) => {
        if (!(node instanceof Element)) return;
        if (node.classList && node.classList.contains('reveal')) {
          bindRevealEl(node);
        }
        if (node.querySelectorAll) {
          node.querySelectorAll('.reveal').forEach(bindRevealEl);
          if (node.querySelector('.marquee-track')) needsMarquee = true;
        }
        if (node.classList && node.classList.contains('marquee-track')) {
          needsMarquee = true;
        }
      });
    }
    if (needsMarquee) initMarquees();
  });
  mo.observe(document.body, { childList: true, subtree: true });
})();
