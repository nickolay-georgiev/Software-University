function growingWord() {

  let text = document.querySelector('#exercise > p');

  //text.setAttribute('style', 'color: blue; font-size: px;');

  textSize = parseInt(text.style.fontSize);
  textColor = text.style.color; 

  if (!textSize) {
    text.style.color = 'blue';
    text.style.fontSize = 2 + 'px';
  }
  else if (textColor === 'blue') {
    text.style.color = 'green';
    text.style.fontSize = textSize * 2 + 'px';
  }
  else if (textColor === 'green') {
    text.style.color = 'red';
    text.style.fontSize = textSize * 2 + 'px';
  }
  else if (textColor === 'red') {
    text.style.color = 'blue';
    text.style.fontSize = textSize * 2 + 'px';
  }
}