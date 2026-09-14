'use strict';
(() => {
  const loader = document.createElement('div');
  loader.className = 'page-loading';
  loader.setAttribute('role', 'status');
  loader.setAttribute('aria-label', '待機中');
  loader.innerHTML = '<span class="loading-orbit" aria-hidden="true"></span><img src="assets/cat-loading.png" width="1024" height="1536" alt="" fetchpriority="high"><span class="loading-label">待機中<span aria-hidden="true">…</span></span>';
  document.body.append(loader);
  let dismissed = false;
  const dismiss = () => {
    if (dismissed) return;
    dismissed = true;
    loader.classList.add('is-complete');
    setTimeout(() => loader.remove(), 350);
  };
  if (document.readyState === 'complete') dismiss();
  else window.addEventListener('load', dismiss, {once:true});
  window.addEventListener('pageshow', event => { if (event.persisted) dismiss(); });
  setTimeout(dismiss, 8000);
})();
document.querySelectorAll('[data-filter]').forEach(button => {
  button.addEventListener('click', () => {
    const category = button.dataset.filter;
    document.querySelectorAll('[data-filter]').forEach(item => item.setAttribute('aria-pressed', String(item === button)));
    let visible = 0;
    document.querySelectorAll('[data-category]').forEach(card => {
      card.hidden = category !== 'all' && card.dataset.category !== category;
      if (!card.hidden) visible++;
    });
    const count = document.getElementById('story-count');
    if (count) count.textContent = `${visible}篇の物語`;
  });
});
const tabs = [...document.querySelectorAll('[data-tab]')];
function selectTab(tab, focus = false) {
  tabs.forEach(item => {
    const selected = item === tab;
    item.setAttribute('aria-selected', String(selected));
    item.tabIndex = selected ? 0 : -1;
    const panel = document.getElementById(item.getAttribute('aria-controls'));
    if (panel) panel.hidden = !selected;
  });
  if (focus) tab.focus();
}
tabs.forEach((tab, index) => {
  tab.addEventListener('click', () => selectTab(tab));
  tab.addEventListener('keydown', event => {
    let next;
    if (event.key === 'ArrowRight') next = (index + 1) % tabs.length;
    if (event.key === 'ArrowLeft') next = (index - 1 + tabs.length) % tabs.length;
    if (event.key === 'Home') next = 0;
    if (event.key === 'End') next = tabs.length - 1;
    if (next !== undefined) { event.preventDefault(); selectTab(tabs[next], true); }
  });
});
