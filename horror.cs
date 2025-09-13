/* 全体設定 */
body {
  margin: 0;
  padding: 0;
  background-color: black;
  animation: flash 0.3s infinite;
  font-family: 'Courier New', monospace;
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
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  padding: 0;
  box-sizing: border-box;
}

/* 怖い画像（画面サイズに強制フィット） */
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

/* 非表示クラス */
.hidden {
  display: none;
}

/* フッターリンク */
footer {
  position: fixed;
  bottom: 20px;
  width: 100%;
  text-align: center;
}

#returnLink {
  color: #f00;
  font-size: 1.2em;
  text-decoration: none;
  border: 1px solid #f00;
  padding: 10px 20px;
  background-color: #111;
  transition: 0.3s;
  display: inline-block;
}

#returnLink:hover {
  background-color: #f00;
  color: #000;
}

/* 📱 スマホ対応（念のため） */
@media screen and (max-width: 600px) {
  #returnLink {
    font-size: 1em;
    padding: 8px 16px;
  }
}