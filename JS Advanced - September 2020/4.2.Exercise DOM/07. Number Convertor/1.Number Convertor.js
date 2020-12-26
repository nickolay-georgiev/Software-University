function solve() {
    let menu = document.getElementById("selectMenuTo");
    menu.appendChild(document.createElement("option"));
    menu.appendChild(document.createElement("option"));
    menu.children[1].value = "binary";
    menu.children[1].textContent = "Binary";

    menu.children[2].value = "hexadecimal";
    menu.children[2].textContent = "Hexadecimal";

    document.querySelector("button").addEventListener("click", () => {

        let number = document.getElementById("input").value;
        let to = document.getElementById("selectMenuTo").value;

        if (number && to == "hexadecimal") {
            document.getElementById("result").value = result =
                (Number(number)).toString(16).toUpperCase();
        } else if (number && to == "binary") {
            document.getElementById("result").value = result =
                (Number(number)).toString(2);
        }
    });
}