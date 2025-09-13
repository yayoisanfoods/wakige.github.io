/* 全体設定：画面サイズにフィット＋スクロール禁止 */
html, body {
  margin: 0;
  padding: 0;
  height: 100vh;
  width: 100vw;
  overflow: hidden;
  background-color: black;
  animation: flash 0.3s infinite;
  font-family: 'Courier New', monospace;
}

/* 点滅演出 */
@keyframes flash {
  0% { background-color: black; }
  50% { background-color: red; }
  100% { background-color: black; }
}

/* 揺れ演出 */
@keyframes shake {
  0% { transform: translate(0, 0); }
  25% { transform: translate(-5px, 5px); }
  50% { transform: translate(5px, -5px); }
  75% { transform: translate(-5px, -5px); }
  100% { transform: translate(5px, 5px); }
}

/* scary.jpg を画面にぴったり表示（縦横比維持） */
#scaryImage {
  max-width: 100vw;
  max-height: 100vh;
  width: auto;
  height: auto;
  object-fit: contain;
  animation: shake 0.2s infinite;
}

/* オーバーレイ中央配置 */
#overlay {
  height: 100vh;
  width: 100vw;
  display: flex;
  justify-content: center;
  align-items: center;
}

/* 「もどる」表示（10秒後） */
#return {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  font-size: 10vw; /* 画面の約1/3サイズ */
  color: red;
  text-align: center;
  animation: flash 0.5s infinite;
}

#return a {
  color: red;
  text-decoration: none;
}

.hidden {
  display: none;
}