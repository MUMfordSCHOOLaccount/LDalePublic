document.addEventListener('DOMContentLoaded', () => {
  // Theme Toggle Logic
  const toggleSwitch = document.querySelector('.theme-switch input[type="checkbox"]');
  const currentTheme = localStorage.getItem('theme');

  if (currentTheme) {
    document.documentElement.setAttribute('data-theme', currentTheme);
    if (currentTheme === 'dark') {
      toggleSwitch.checked = true;
    }
  }

  toggleSwitch.addEventListener('change', (e) => {
    if (e.target.checked) {
      document.documentElement.setAttribute('data-theme', 'dark');
      localStorage.setItem('theme', 'dark');
    } else {
      document.documentElement.setAttribute('data-theme', 'light');
      localStorage.setItem('theme', 'light');
    }
  });

  // Intersection Observer for reveal animations
  const observerOptions = { threshold: 0.1 };
  const observer = new IntersectionObserver((entries) => {
    entries.forEach(entry => {
      if (entry.isIntersecting) {
        entry.target.classList.add('active');
      }
    });
  }, observerOptions);

  document.querySelectorAll('.reveal').forEach(el => observer.observe(el));

  // Spotlight and Vault Reveal Logic
  const vault = document.getElementById('vaultContainer');
  const keypadDisp = document.getElementById('keypadDisplay');
  let currentCode = "";

  document.addEventListener('mousemove', (e) => {
    // Only run spotlight if in Dark/Scanner Mode
    const isDarkMode = document.documentElement.getAttribute('data-theme') === 'dark';
    if (!isDarkMode) return;

    const x = e.clientX;
    const y = e.clientY;
    document.documentElement.style.setProperty('--spotlight-x', `${x}px`);
    document.documentElement.style.setProperty('--spotlight-y', `${y}px`);

    // Check Proximity for Vault
    if (vault) {
      const vRect = vault.getBoundingClientRect();
      const vcX = vRect.left + vRect.width / 2;
      const vcY = vRect.top + vRect.height / 2;
      const dist = Math.sqrt(Math.pow(x - vcX, 2) + Math.pow(y - vcY, 2));

      if (dist < 150) {
        vault.classList.add('visible');
      } else {
        vault.classList.remove('visible');
      }
    }

    // Move Background Blobs
    const blobs = document.querySelectorAll('.blob');
    const ux = x / window.innerWidth;
    const uy = y / window.innerHeight;

    blobs.forEach((blob, index) => {
      const speed = (index + 1) * 20;
      blob.style.transform = `translate(${ux * speed}px, ${uy * speed}px)`;
    });
  });

  // Keypad Logic
  if (vault) {
    const keys = vault.querySelectorAll('.key:not(.action-key)');
    const clearBtn = document.getElementById('clearBtn');
    const enterBtn = document.getElementById('enterBtn');

    keys.forEach(key => {
      key.addEventListener('click', () => {
        if (currentCode.length < 4) {
          currentCode += key.textContent;
          keypadDisp.textContent = "*".repeat(currentCode.length);
        }
      });
    });

    clearBtn.addEventListener('click', () => {
      currentCode = "";
      keypadDisp.textContent = "ACCESS CODE";
    });

    enterBtn.addEventListener('click', () => {
      if (currentCode === "2609") {
        keypadDisp.textContent = "GRANTED";
        keypadDisp.style.color = "#10b981";
        setTimeout(() => {
          window.location.href = "admin.html";
        }, 1000);
      } else {
        keypadDisp.textContent = "DENIED";
        keypadDisp.style.color = "#ef4444";
        setTimeout(() => {
          currentCode = "";
          keypadDisp.textContent = "ACCESS CODE";
          keypadDisp.style.color = "";
        }, 1500);
      }
    });
  }

  // Project Gallery Preview
  const preview = document.createElement('div');
  preview.className = 'screenshot-preview glass';
  const previewImg = document.createElement('img');
  preview.appendChild(previewImg);
  document.body.appendChild(preview);

  const projects = document.querySelectorAll('.project-card');
  projects.forEach(card => {
    const screenshot = card.dataset.screenshot;
    if (!screenshot) return;

    card.addEventListener('mouseenter', () => {
      previewImg.src = screenshot;
      preview.classList.add('visible');
    });

    card.addEventListener('mousemove', (e) => {
      const offset = 20;
      let px = e.clientX + offset;
      let py = e.clientY + offset;
      if (px + 350 > window.innerWidth) px = e.clientX - 350 - offset;
      if (py + 250 > window.innerHeight) py = e.clientY - 250 - offset;
      preview.style.left = `${px}px`;
      preview.style.top = `${py}px`;
    });

    card.addEventListener('mouseleave', () => {
      preview.classList.remove('visible');
    });
  });
});
