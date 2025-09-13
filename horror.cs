body {
  margin: 0;
  padding: 0;
  background-color: black;
  animation: flash 0.3s infinite;
}

@keyframes flash {
  0% { background-color: black; }
  50% { background-color: red; }
  100% { background-color: black; }
}

#overlay {
  position: fixed;
  top: 0; left: 0;
  width: 100%; height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}

#scaryImage {
  width: 80%;
  max-width: 800px;
  animation: shake 0.2s infinite;
}

@keyframes shake {
  0% { transform: translate(0, 0); }
  25% { transform: translate(-5px, 5px); }
  50% { transform: translate(5px, -5px); }
  75% { transform: translate(-5px, -5px); }
  100% { transform: translate(5px, 5px); }
}

.hidden {
  display: none;
}

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
}

#returnLink:hover {
  background-color: #f00;
  color: #000;
}