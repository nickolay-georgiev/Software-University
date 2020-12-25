function solve() {

   let sendButton = document.getElementById('send');

   sendButton.addEventListener('click', function (e) {

      let allMessages = document.getElementById('chat_messages');

      let inputMessage = sendButton.previousElementSibling.value;

      let div = document.createElement('div');

      div.setAttribute('class', "message my-message");

      div.textContent = inputMessage;
      
      allMessages.appendChild(div);
      
      sendButton.previousElementSibling.value = '';
   })
}


