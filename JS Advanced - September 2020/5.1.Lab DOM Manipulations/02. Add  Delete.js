function addItem() {
    let textValue = document.getElementById("newText").value;

    let list = document.getElementById("items");

    if (textValue.length === 0) return;

    let li = document.createElement("li");

    li.textContent = textValue;

    let remove = document.createElement("a");

    let removeLinkText = document.createTextNode("[Delete]");

    remove.appendChild(removeLinkText);

    remove.href = "#";

    remove.addEventListener("click", deleteItem);

    li.appendChild(remove);

    list.appendChild(li);

    function deleteItem() {

        li.remove();
    }
}

