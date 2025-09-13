/* 全体設定 */
body {
  margin: 0;
  padding: 0;
  background-color: black;
  animation: flash 0.3s infinite;
  font-family: 'Courier New', monospace;
  height: 100vh;
  width: 100vw;
  overflow: hidden;
}

/* 点滅背景 */
@keyframes flash {
  0% { background-color: black; }
  50% { background-color: red; }
  100% { background-color: black; }
}

/* オーバーレイ */
#overlay {
  position: fixed;
  top: 0; left: 0;
  width: 100vw;
  height: 100vh;
  overflow: hidden;
}

/* scary.jpg を画面に完全フィット（縦横比無視） */
#scaryImage {
  width: 100vw;
  height: 100vh;
  object-fit: cover;
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