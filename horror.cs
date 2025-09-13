/* 全体を画面に固定し、スクロール禁止 */
html, body {
  margin: 0;
  padding: 0;
  height: 100vh;
  width: 100vw;
  overflow: hidden;
  background-color: black;
  animation: flash 0.3s infinite;
}

/* 点滅背景 */
@keyframes flash {
  0% { background-color: black; }
  50% { background-color: red; }
  100% { background-color: black; }
}

/* scary.jpg を画面サイズに合わせて強制変形 */
#scaryImage {
  position: fixed;
  top: 0;
  left: 0;
  width: 100vw;
  height: 100vh;
  object-fit: fill; /* ← 縦横比を無視して画面にぴったり */
  animation: shake 0.2s infinite;
}

/* 揺れ演出 */
@keyframes shake {
  0% { transform: translate(0, 0); }
  25% { transform: translate(-5px, 5px); }
  50% { transform: translate(5px, -5px); }
  75% { transform: translate(-5px, -5px); }
  100% { transform: translate(5px, 5px); }
}