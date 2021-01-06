function solve() {

   let firstPlayerCards = document.getElementById('player1Div');
   let secondPlayerCards = document.getElementById('player2Div');

   let resultField = document.getElementById('history');

   let firstPlayerResultField = Array.from(document.getElementsByTagName('span'))[0];
   let secondPlayerResultField = Array.from(document.getElementsByTagName('span'))[2];

   let valuesOfSelectedCards = [-1, -1];
   let selectedCards = [];

   firstPlayerCards.addEventListener('click', function (e) {

      let target = e.target;

      let cards = Array.from(firstPlayerCards.children);

      let cardValue = 0;
      if (cards.some(x => x === target)) {

         cardValue = Number(target.name);
      } else { return; }

      firstPlayerResultField.textContent = cardValue;

      target.src = 'images/whiteCard.jpg'

      valuesOfSelectedCards[0] = cardValue;
      selectedCards[0] = target;

      let ifGotWinner = checkForWinner(valuesOfSelectedCards);

      if (ifGotWinner) {
         createBorderOnCard(valuesOfSelectedCards, selectedCards);
         printResult(firstPlayerResultField);
         clearPreviousCardResult();
         clearResultSpanFields();
      }
   })

   secondPlayerCards.addEventListener('click', function (e) {

      let target = e.target;

      let cards = Array.from(secondPlayerCards.children);

      let cardValue = 0;
      if (cards.some(x => x === target)) {

         cardValue = Number(target.name);
      } else { return; }

      secondPlayerResultField.textContent = cardValue;

      target.src = 'images/whiteCard.jpg'

      valuesOfSelectedCards[1] = cardValue;
      selectedCards[1] = target;

      let ifGotWinner = checkForWinner(valuesOfSelectedCards);

      if (ifGotWinner) {
         createBorderOnCard(valuesOfSelectedCards, selectedCards);
         printResult(secondPlayerResultField);
         clearPreviousCardResult();
         clearResultSpanFields();
      }
   })

   function checkForWinner(results) {
      let firstPlayerCard = results[0];
      let secondPlayerCard = results[1];

      if (firstPlayerCard !== -1 && secondPlayerCard !== -1) {

         return true;
      }
      return false;
   }

   function createBorderOnCard(result, selectedCards) {
      let firstPlayerCardValue = result[0];
      let secondPlayerCardValue = result[1];

      let firstPlayerCard = selectedCards[0];
      let secondPlayerCard = selectedCards[1];

      if (firstPlayerCardValue > secondPlayerCardValue) {
         firstPlayerCard.style.border = '2px solid green'
         secondPlayerCard.style.border = '2px solid red'
      } else {
         firstPlayerCard.style.border = '2px solid red'
         secondPlayerCard.style.border = '2px solid green'
      }
   }

   function printResult(targetInput) {
      resultField.textContent += `[${valuesOfSelectedCards[0]} vs ${valuesOfSelectedCards[1]}] `;
   }

   function clearPreviousCardResult() {
      valuesOfSelectedCards[0] = -1;
      valuesOfSelectedCards[1] = -1;
   }

   function clearResultSpanFields() {
      firstPlayerResultField.textContent = '';
      secondPlayerResultField.textContent = '';
   }
}