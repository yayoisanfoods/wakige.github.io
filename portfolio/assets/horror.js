'use strict';
(() => {
  const buttons = [...document.querySelectorAll('.door-button')];
  const overlay = document.getElementById('reveal');
  const picture = document.getElementById('reveal-image');
  const audio = document.getElementById('scream');
  const sound = document.getElementById('sound-enabled');
  const status = document.getElementById('portal-status');
  const choices = ['assets/horror-reveal.jpg', 'assets/couple-reveal.jpg'];
  const speech = window.speechSynthesis;
  let japaneseVoice;
  function updateVoice() {
    if (speech) japaneseVoice = speech.getVoices().find(voice => voice.lang.startsWith('ja'));
  }
  updateVoice();
  if (speech) speech.addEventListener('voiceschanged', updateVoice);
  let active = false;
  let timer;
  let origin;
  function finish() {
    if (!active) return;
    clearTimeout(timer);
    active = false;
    overlay.hidden = true;
    overlay.classList.remove('is-showing');
    document.body.classList.remove('revealing');
    audio.pause();
    audio.currentTime = 0;
    if (speech) speech.cancel();
    buttons.forEach(button => { button.disabled = false; });
    status.textContent = 'もう一度、扉を選べます。';
    if (origin) origin.focus({preventScroll:true});
  }
  function reveal(button) {
    if (active) return;
    active = true;
    origin = button;
    const horror = Math.floor(Math.random() * 3) === 0;
    picture.src = choices[horror ? 0 : 1];
    picture.alt = horror ? '架空の不気味な仮面が迫るホラー画像' : '笑顔で寄り添う架空の成人カップル';
    overlay.dataset.outcome = horror ? 'horror' : 'couple';
    buttons.forEach(item => { item.disabled = true; });
    overlay.hidden = false;
    overlay.classList.add('is-showing');
    document.body.classList.add('revealing');
    overlay.focus({preventScroll:true});
    if (sound.checked) {
      audio.currentTime = 0;
      audio.volume = 0.7;
      if (japaneseVoice && window.SpeechSynthesisUtterance) {
        const utterance = new SpeechSynthesisUtterance('キャー！');
        utterance.voice = japaneseVoice;
        utterance.lang = 'ja-JP';
        utterance.pitch = 2;
        utterance.rate = 1.2;
        utterance.volume = 0.7;
        utterance.onerror = () => { if (active) audio.play().catch(() => {}); };
        speech.cancel();
        speech.speak(utterance);
      } else audio.play().catch(() => {});
    }
    timer = setTimeout(finish, 1000);
  }
  Promise.all(choices.map(src => new Promise((resolve, reject) => {
    const image = new Image();
    image.onload = resolve;
    image.onerror = reject;
    image.src = src;
  }))).then(() => {
    buttons.forEach(button => { button.disabled = false; });
    status.textContent = '好きな扉を選んでください。';
  }).catch(() => { status.textContent = '画像を読み込めませんでした。ページを再読み込みしてください。'; });
  buttons.forEach(button => button.addEventListener('click', () => reveal(button)));
  document.addEventListener('keydown', event => { if (event.key === 'Escape') finish(); });
  document.addEventListener('visibilitychange', () => { if (document.hidden) finish(); });
  window.addEventListener('pagehide', finish);
})();
