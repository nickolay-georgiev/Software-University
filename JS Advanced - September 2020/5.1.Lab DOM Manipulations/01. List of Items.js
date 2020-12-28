function addItem() {   
    let element = document.getElementById('newItemText');
    let items = document.getElementById('items');

    let inputValue = element.value;

    let li = document.createElement('li');
    li.textContent = inputValue;
    items.appendChild(li);    
}