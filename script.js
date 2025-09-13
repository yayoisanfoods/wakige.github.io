let clickCount = 0;
let triggerPoint = Math.floor(Math.random() * 5) + 1;

function handleLink(linkURL) {
  clickCount++;
  if (clickCount === triggerPoint) {
    window.location.href = "vol2_horror.html";
  } else {
    window.location.href = linkURL;
  }
}