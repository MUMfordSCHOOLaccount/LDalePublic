(function () {
  /*
    Author: Larry Mumford
    Date Completed: 12/16/2025
    Required Files: finalExam.html (consuming page), finalExam.css (styles)
    Description: Final Exam for Fall 2025 Quarter — interactive behaviors
  */
  function guardThumbnails(root = document) {
    const thumbs = root.querySelectorAll('img.hover-thumb');
    thumbs.forEach(img => {
      function hide() {
        img.setAttribute('hidden', '');
        img.style.display = 'none';
      }
      if (img.complete && img.naturalWidth === 0) {
        hide();
      } else {
        img.addEventListener('error', hide, { once: true });
      }
      img.setAttribute('aria-hidden', 'true');
    });
  }

  function initHoverBubble(root = document) {
    const bubble = document.createElement('div');
    bubble.className = 'hover-bubble';
    bubble.setAttribute('aria-hidden', 'true');
    const img = document.createElement('img');
    const caption = document.createElement('div');
    caption.className = 'hover-caption';
    bubble.appendChild(img);
    bubble.appendChild(caption);
    document.body.appendChild(bubble);

    const OFFSET_X = 18;
    const OFFSET_Y = 14;

    function place(x, y) {
      const rect = bubble.getBoundingClientRect();
      const vw = Math.max(document.documentElement.clientWidth, window.innerWidth || 0);
      const vh = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);
      let left = x + OFFSET_X;
      let top = y + OFFSET_Y;
      if (left + rect.width > vw - 8) left = x - rect.width - 8;
      if (top + rect.height > vh - 8) top = y - rect.height - 8;
      bubble.style.left = left + 'px';
      bubble.style.top = top + 'px';
    }

    function showFor(anchor, src) {
      if (!src) return;
      img.src = src;
      const custom = anchor.dataset && anchor.dataset.caption;
      caption.textContent = (custom && custom.trim()) || anchor.textContent.trim();
      bubble.style.display = 'block';
    }

    function hide() { bubble.style.display = 'none'; }

    root.querySelectorAll('.thumb-wrap a').forEach(anchor => {
      const thumb = anchor.parentElement.querySelector('img.hover-thumb');
      const src = thumb && thumb.getAttribute('src');
      anchor.addEventListener('mouseenter', e => { showFor(anchor, src); place(e.clientX, e.clientY); });
      anchor.addEventListener('mousemove', e => { if (bubble.style.display === 'block') place(e.clientX, e.clientY); });
      anchor.addEventListener('mouseleave', hide);
      anchor.addEventListener('focus', () => {
        showFor(anchor, src);
        const r = anchor.getBoundingClientRect();
        place(r.right, r.bottom);
      });
      anchor.addEventListener('blur', hide);
    });

    window.addEventListener('scroll', () => { bubble.style.display = 'none'; }, { passive: true });
  }

  function initCollapsibles(root = document) {
    const cards = root.querySelectorAll('.card');
    cards.forEach(card => {
      const button = card.querySelector('.card-toggle');
      const list = card.querySelector('.card-list');
      if (!button || !list) return;

      const controls = button.getAttribute('aria-controls');
      if (!controls || root.getElementById(controls) !== list) {
        const id = 'list-' + Math.random().toString(36).slice(2, 8);
        list.id = id;
        button.setAttribute('aria-controls', id);
      }

      button.setAttribute('aria-expanded', 'false');
      list.hidden = true;

      button.addEventListener('click', () => {
        const expanded = button.getAttribute('aria-expanded') === 'true';
        button.setAttribute('aria-expanded', String(!expanded));
        list.hidden = expanded;
      });
    });
  }

  function initMobileSideNav(root = document) {
    const toggle = root.querySelector('.side-nav-toggle');
    const sideNav = root.querySelector('.side-nav');
    const list = root.getElementById('sideNav');
    if (!toggle || !sideNav || !list) return;

    const mqNarrow = window.matchMedia('(max-width: 800px)');
    const mqLandscapeShort = window.matchMedia('(orientation: landscape) and (max-height: 500px)');
    function ensureToggleOverlay() {
      const shouldOverlay = mqNarrow.matches || mqLandscapeShort.matches;
      const inBody = toggle.parentElement === document.body;
      if (shouldOverlay && !inBody) {
        document.body.appendChild(toggle);
      } else if (!shouldOverlay && inBody) {
        const header = root.querySelector('.site-header') || root.body || root;
        header.insertBefore(toggle, header.firstChild);
      }
    }
    ensureToggleOverlay();
    mqNarrow.addEventListener('change', ensureToggleOverlay);
    mqLandscapeShort.addEventListener('change', ensureToggleOverlay);

    function open() {
      sideNav.classList.add('open');
      toggle.setAttribute('aria-expanded', 'true');
    }
    function close() {
      sideNav.classList.remove('open');
      toggle.setAttribute('aria-expanded', 'false');
    }
    toggle.addEventListener('click', () => {
      const expanded = toggle.getAttribute('aria-expanded') === 'true';
      if (expanded) close(); else open();
    });
    list.querySelectorAll('a').forEach(a => a.addEventListener('click', close));
    window.addEventListener('keydown', (e) => { if (e.key === 'Escape') close(); });
  }

  if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', () => { guardThumbnails(); initHoverBubble(); initCollapsibles(); initMobileSideNav(); });
  } else {
    guardThumbnails();
    initHoverBubble();
    initCollapsibles();
    initMobileSideNav();
  }
})();
