function create(words) {   
   let content = document.getElementById('content');

   for(let i = 0; i < words.length; i++){

      let currentWord = words[i];      
      
      let div = document.createElement('div');
      let p = document.createElement('p');

      p.style.display = 'none';

      p.textContent = currentWord;

      div.appendChild(p);

      content.appendChild(div);

      div.addEventListener('click', function(e){

         e.target.firstElementChild.style.display = 'block';        
      })      
   }
}