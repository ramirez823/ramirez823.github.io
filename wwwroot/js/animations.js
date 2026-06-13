// ============================================
// ANIMATIONS — Scroll reveal, navbar, marquee
// No dependencies. Runs after DOM ready.
// ============================================

(function () {
  'use strict';

  // ---- 1. SCROLL REVEAL via IntersectionObserver ----
  function initReveal() {
    const reveals = document.querySelectorAll('.reveal:not(.visible)');
    if (!reveals.length) return;

    // Si el elemento ya está visible en el viewport al cargar,
    // marcarlo visible inmediatamente (no esperar al observer).
    reveals.forEach((el) => {
      const rect = el.getBoundingClientRect();
      const isInView = rect.top < window.innerHeight && rect.bottom > 0;
      if (isInView) {
        el.classList.add('visible');
        return;
      }
    });

    // Para los que quedan fuera del viewport, observar
    const pending = document.querySelectorAll('.reveal:not(.visible)');
    if (!pending.length) return;

    const observer = new IntersectionObserver(
      (entries) => {
        entries.forEach((entry) => {
          if (entry.isIntersecting) {
            entry.target.classList.add('visible');
            observer.unobserve(entry.target);
          }
        });
      },
      { threshold: 0.05, rootMargin: '0px 0px -30px 0px' }
    );

    pending.forEach((el) => observer.observe(el));
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
    initReveal();
    initNavbar();
    initMarquees();
    initHeroTilt();
    initSmoothScroll();
  }

  function scheduleBoot() {
    if (initTimer) clearTimeout(initTimer);
    initTimer = setTimeout(boot, 100);
  }

  document.addEventListener('DOMContentLoaded', scheduleBoot);
  window.addEventListener('load', scheduleBoot);

  // Blazor fires 'enhancedload' on navigation, and the app root mutates.
  // Watch for new reveal elements and re-observe.
  const mo = new MutationObserver(() => {
    initReveal();
    initMarquees();
  });
  mo.observe(document.body, { childList: true, subtree: true });
})();
