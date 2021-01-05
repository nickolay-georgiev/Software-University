function solve() {
  let generateButton = Array.from(document.querySelectorAll('button'))[0];
  let buyButton = Array.from(document.querySelectorAll('button'))[1];

  let tbody = document.querySelector('tbody');

  generateButton.addEventListener('click', function (e) {

    let input = JSON.parse(document.querySelector('#exercise > textarea:nth-child(2)').value);

    for (const element of input) {

      let tr = document.createElement('tr');
      let td = document.createElement('td');
      let img = document.createElement('img')
      img.src = element.img;

      td.appendChild(img);
      tr.appendChild(td);
      tbody.appendChild(tr)

      td = document.createElement('td');
      p = document.createElement('p')
      p.textContent = element.name;

      td.appendChild(p);
      tr.appendChild(td);

      td = document.createElement('td');
      p = document.createElement('p')
      p.textContent = Number(element.price);

      td.appendChild(p);
      tr.appendChild(td);


      td = document.createElement('td');
      p = document.createElement('p')
      p.textContent = Number(element.decFactor);

      td.appendChild(p);
      tr.appendChild(td);

      td = document.createElement('td');
      input = document.createElement('input')
      input.type = 'checkbox';

      td.appendChild(input);
      tr.appendChild(td);
    }

    buyButton.addEventListener('click', function (e) {

      let allMarkButtons = Array.from(document.querySelectorAll('input'));

      let bougthFurniture = [];
      let totalPrice = 0;
      let totalDecorationFactor = 0;

      for (let i = 0; i < allMarkButtons.length; i++) {

        if (allMarkButtons[i].checked === true) {

          let currentProduct = allMarkButtons[i];
          totalDecorationFactor += Number(currentProduct.parentElement.previousElementSibling.textContent);
          totalPrice += Number(currentProduct.parentElement.previousElementSibling.previousElementSibling.textContent);
          bougthFurniture.push(currentProduct.parentElement.previousElementSibling.previousElementSibling.previousElementSibling.textContent);
        }
      }
      
      let resultMessage = `Bought furniture: ${bougthFurniture.join(', ')}\nTotal price: ${totalPrice.toFixed(2)}\nAverage decoration factor: ${totalDecorationFactor / bougthFurniture.length}`
      
      document.querySelector('#exercise > textarea:nth-child(5)').value = resultMessage;
    })
  })
}