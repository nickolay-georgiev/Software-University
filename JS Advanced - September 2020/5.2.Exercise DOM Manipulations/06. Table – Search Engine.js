function solve() {
   let data = Array.from(document.querySelectorAll('td'));
   let searchButton = document.querySelector('button');

   searchButton.addEventListener('click', function (e) {

      for (let i = 1; i < data.length; i++) {

         data[i].parentElement.classList.remove('select')
      }

      let input = e.target.previousElementSibling.value;

      for (let i = 1; i < data.length; i++) {

         if (data[i].textContent.includes(input)) {

            data[i].parentElement.classList.add('select')
         }
      }
      e.target.previousElementSibling.value = '';
   })
}