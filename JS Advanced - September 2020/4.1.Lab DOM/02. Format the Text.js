function solve() {
  let inputText = document.getElementById('input').innerText.split('.').filter(x=> x !== '');

  let output = document.getElementById('output');

  while(inputText.length > 0) {

    let paragraph = document.createElement('p');
    output.appendChild(paragraph);

    let counter = 0;
    while (inputText.length > 0 && counter !== 3) {

      paragraph.textContent += inputText.shift() + '.';
      counter++;
    }
  }
}