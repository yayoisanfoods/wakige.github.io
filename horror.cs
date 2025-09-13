html, body {
  margin: 0;
  padding: 0;
  height: 100%;
  width: 100%;
  background-color: black;
  animation: flash 0.3s infinite;
  overflow: hidden;
}

/* 点滅背景 */
@keyframes flash {
  0% { background-color: black; }
  50% { background-color: red; }
  100% { background-color: black; }
}

/* scary.jpg を画面に強制フィット（縦横比変更） */
#scaryImage {
  position: fixed;
  top: 0;
  left: 0;
  width: 100vw;
  height: 100vh;
  object-fit: fill; /* ← ここがポイント！ */
  animation: shake 0.2s infinite;
}