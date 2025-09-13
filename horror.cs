body {
  margin: 0;
  padding: 0;
  background-color: black;
  animation: flash 0.3s infinite;
  font-family: 'Courier New', monospace;
  height: 100vh;
  width: 100vw;
  display: flex;
  justify-content: center;
  align-items: center;
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
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
}

/* scary.jpg を画面にフィットさせる */
#scaryImage {
  max-width: 100%;
  max-height: 100%;
  width: auto;
  height: auto;
  object-fit: contain;
  animation: shake 0.2s infinite;
}