function solve() {

  let correctAnswers = ['onclick', 'JSON.stringify()', 'A programming API for HTML and XML documents']
  let counter = 0;
  let rightAnswers = 0;

  
  let elements = document.querySelector('#quizzie');
  let sections = document.getElementsByTagName('section');
  
  elements.addEventListener('click', function (e) {

    if (e.target.className !== 'answer-text') {
      return;
    }

    let answer = e.target.textContent;

    if (answer === correctAnswers[counter]) {

      rightAnswers++;
    }

    counter++;

    if (counter === 3) {

      sections[2].style.display = 'none';

      let resultDiv = document.querySelector('#results');
      let resultArea = document.querySelector('#results > li > h1');
      
      if (rightAnswers === 3) {

        resultArea.innerText = 'You are recognized as top JavaScript fan!';
        
      } else {
        
        resultArea.innerText = `You have ${rightAnswers} right answers`;
      }
      
      resultDiv.style.display = 'block';
      return;
    }

    sections[counter - 1].style.display = 'none';
    sections[counter].style.display = 'block';
  })
}
